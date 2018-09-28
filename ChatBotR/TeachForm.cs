using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatBotR
{
    public partial class TeachForm : Form
    {
        string CurrentUserMessage = string.Empty;
        Form1 MainForm;
        //конструктор формы
        public TeachForm(Form1 mainForm)
        {
            MainForm = mainForm;
            InitializeComponent();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            CurrentUserMessage = UserMessage.Text;

            ClearCurrentMessageFromSymbols();

            if (UserMessage.Text != "" && BotMessage.Text != "")
            {
                int UserMessageIndex = -1;

                foreach(var question in MainForm.QuestionsList)
                    if(question.Question.Contains(CurrentUserMessage))
                    {
                        UserMessageIndex = MainForm.QuestionsList.IndexOf(question);
                        break;
                    }

                if (UserMessageIndex == -1)
                {
                    MainForm.QuestionsList.Add(new QuestionWithAnswers(CurrentUserMessage));
                    UserMessageIndex = MainForm.QuestionsList.Count - 1;
                }

                MainForm.QuestionsList[UserMessageIndex].Answers.Add(BotMessage.Text);
                BotMessage.Text = "";
                MessageBox.Show("Бот запомнил новый ответ!");
            }
            else
                MessageBox.Show("Поля не заполненеы.");
        }

        public void ClearCurrentMessageFromSymbols()
        {
            var SymbolsToReplace = new string[] { ".", ",", "!", "?", "\r\n", "\"", "'", ";", ":", ")", "(" };

            CurrentUserMessage = CurrentUserMessage.Trim().ToLower();

            foreach (var symbol in SymbolsToReplace)
                CurrentUserMessage = CurrentUserMessage.Replace(symbol, "");

        }

        private void TeachForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainForm.Show();
        }
    }
}
