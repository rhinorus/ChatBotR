using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatBotR
{
    public class QuestionWithAnswers
    {
        //вопрос пользователя
        public string Question { get; set; }

        //список ответов бота на данный вопрос
        public List<string> Answers { get; set; }

        //конструктор с параметром
        public QuestionWithAnswers(string question)
        {
            //инициализация полей класса
            Question = question;
            Answers = new List<string>();
        }

        //конструктор по умолчанию
        public QuestionWithAnswers()
        {
            Question = "";
            Answers = new List<string>();
        }
    }
}
