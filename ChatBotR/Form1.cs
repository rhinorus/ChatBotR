using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace ChatBotR
{
    public partial class Form1 : Form
    {
        //база вопрос-ответ
        public List<QuestionWithAnswers> QuestionsList;

        //найденные индексы вопроса и ответа в базе
        int CurrentQuestionIndex = -1,
            CurrentAnswerIndex = -1;

        string CurrentUserMessage = string.Empty; //текущее сообщение пользователя

        //конструктор формы
        public Form1()
        {
            InitializeComponent(); //инициализация компонентов формы
            this.FormClosing += Form1_FormClosing; //создаём обработчик закрытия формы

            //поток для чтения базы вопрос-ответ
            FileStream fs = null;
            try
            {
                //открываем поток
                fs = new FileStream("base.xml", FileMode.OpenOrCreate);

                //объявляем сериализатор
                var serializer = new XmlSerializer(typeof(List<QuestionWithAnswers>));

                //извлекаем данные из файла.
                QuestionsList = (List<QuestionWithAnswers>)serializer.Deserialize(fs);
            }
            catch
            {
                MessageBox.Show("Не удалось прочитать базу вопрос-ответ.");
                QuestionsList = new List<QuestionWithAnswers>();
            }
            finally
            {
                if (fs != null) //если поток был открыт, то закрываем его.
                    fs.Close();
            }
        }

        //обработчик закрытия формы
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            FileStream fs = null;

            try
            {
                //открываем поток на запись
                fs = new FileStream("base.xml", FileMode.OpenOrCreate);

                //объявляем сериализатор
                var serializer = new XmlSerializer(typeof(List<QuestionWithAnswers>));

                //сохраняем список
                serializer.Serialize(fs, QuestionsList);
            }
            catch
            {
                MessageBox.Show("Невозможно обновить базу.");
            }
            finally
            {
                if (fs != null) //закрываем поток, если он был открыт
                    fs.Close();
            }
        }

        //обработчик кнопки "Отправить"
        private void BtnSend_Click(object sender, EventArgs e)
        {
            if (QuestionTextBox.Text != "")
            {
                ShowUserMessage();

                CurrentUserMessage = QuestionTextBox.Text;
                ClearCurrentMessageFromSymbols();

                //обработка поиска в браузере
                if(CurrentUserMessage.Contains("что такое"))
                {
                    var stringToFind = CurrentUserMessage.Replace("что такое", "");

                    System.Diagnostics.Process.Start("https://yandex.ru/search/?text=" + stringToFind);

                    PrintRBot();
                    MessagesTextBox.AppendText("Открываю поиск по запросу \"" + stringToFind + "\"\r\n\r\n");

                    MessagesTextBox.ScrollToCaret(); //позволяет прокрутить окно чата до конца.
                    QuestionTextBox.Clear();

                    return;
                }

                //ищем сообщение пользователя в базе
                FindCurrentQuestionIndex();

                if (CurrentQuestionIndex == -1) //если не нашли - показываем ответ по умолчанию
                    ShowDefaultAnswer();
                else
                    ShowAnswer();

            }
            else
                MessageBox.Show("Вы пытаетесь отправить пустое сообщение. Вам не ответят.");

            MessagesTextBox.ScrollToCaret(); //позволяет прокрутить окно чата до конца.
            QuestionTextBox.Clear();
        }

        //метод, очищающий сообщение пользователя от лишних символов
        public void ClearCurrentMessageFromSymbols()
        {
            var SymbolsToReplace = new string[] { ".", ",", "!", "?", "\r\n", "\"", "'", ";",":", ")", "("};

            CurrentUserMessage = CurrentUserMessage.Trim().ToLower();

            foreach (var symbol in SymbolsToReplace)
                CurrentUserMessage = CurrentUserMessage.Replace(symbol, "");

        }

        //метод, показывающий ответ по умолчанию
        private void ShowDefaultAnswer()
        {
            PrintRBot();
            MessagesTextBox.AppendText("Я тебя не понимаю.\r\n\r\n");
        }

        //метод, распечатывающий имя бота синим цветом перед сообщением
        private void PrintRBot()
        {
            var startOfSelection = MessagesTextBox.TextLength;
            MessagesTextBox.AppendText("R-Bot: ");
            MessagesTextBox.Select(startOfSelection, "R-Bot:".Length);
            MessagesTextBox.SelectionColor = Color.Blue;
        }

        //метод, показывающий ответ на вопрос, который есть в базе.
        private void ShowAnswer()
        {
            var rand = new Random();

            //берем случайный ответ из списка ответов.
            CurrentAnswerIndex = rand.Next(QuestionsList[CurrentQuestionIndex].Answers.Count);

            PrintRBot();
            StringBuilder sb = new StringBuilder();
            sb.Append(QuestionsList[CurrentQuestionIndex].Answers[CurrentAnswerIndex]);
            sb.Append("\r\n\r\n");

            MessagesTextBox.AppendText(sb.ToString());
        }

        //обработчик ввода символов в окно чата
        private void MessagesTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true; //запрещаем вводить любые символы.
        }

        //метод, который определяет индекс текущего сообщения пользователя в базе
        private void FindCurrentQuestionIndex()
        {
            CurrentQuestionIndex = -1;

            for (int i = 0; i < QuestionsList.Count; i++)
                if (QuestionsList[i].Question.Contains(CurrentUserMessage))
                {
                    CurrentQuestionIndex = i;
                    break;
                }
        }

        //обработчик нажатия клавиш при вводе текста сообщения.
        private void QuestionTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            //позволяет отправлять сообщение по нажатию на Enter
            if (e.KeyCode == Keys.Enter)
                BtnSend_Click(null, null);
        }

        //обработчик пункта меню "Плохой ответ бота"
        private void плохойОтветБотаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CurrentAnswerIndex != -1)
            {
                QuestionsList[CurrentQuestionIndex].Answers.RemoveAt(CurrentAnswerIndex);
                CurrentAnswerIndex = -1;

                if (QuestionsList[CurrentQuestionIndex].Answers.Count == 0) //если в базе больше нет ответа на этот вопрос, то вопрос тоже стираем
                    QuestionsList.RemoveAt(CurrentQuestionIndex);

                MessageBox.Show("Последний ответ бота удалён из базы.");
            }
            else
                MessageBox.Show("Бот не сказал ничего плохого.");
        }

        //обработчик пункта меню "Обучить бота"
        private void обучитьБотаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TeachForm teach = new TeachForm(this);

            this.Hide(); //прячем текущее окно
            teach.Show(); //показываем окно обучения
        }

        //обработчик пункта меню "Возможности бота"
        private void возможностиБотаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //открываем окно информации
            Skills skillsWindow = new Skills(this);

            skillsWindow.Show();
            this.Hide();
        }

        //обработчик пункта меню "Очистить чат"
        private void очиститьЧатToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessagesTextBox.Clear();
        }

        //метод, отобращающий пользовательское сообщение
        private void ShowUserMessage()
        {
            var startOfSelection = MessagesTextBox.TextLength;
            MessagesTextBox.AppendText("Вы: ");
            MessagesTextBox.Select(startOfSelection, "Вы:".Length);
            MessagesTextBox.SelectionColor = Color.Green;

            MessagesTextBox.AppendText(QuestionTextBox.Text + "\r\n\r\n");
        }
    }
}
