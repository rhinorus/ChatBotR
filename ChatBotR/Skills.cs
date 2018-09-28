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
    public partial class Skills : Form
    {
        //ссылка на главное окно
        Form1 MainWindow;

        //конструктор формы
        public Skills(Form1 mainWindow)
        {
            MainWindow = mainWindow;
            InitializeComponent();
        }

        //обработчик нажания на кнопку "Понятно"
        private void GorItBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //вызывается при закрытии формы
        private void Skills_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainWindow.Show();
        }
    }
}
