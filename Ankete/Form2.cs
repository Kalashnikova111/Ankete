using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ankete
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            form1 = new Form1(); // создали объект формы1
        }
        Form1 form1; //привязали форму2 к 1 
        // создаем глобальные переменные для логина и пароля 
        string Login = "admin"; // это нужно вводить и их пожно поменять ,но уже в самом коде  
        string Password = "Anna123";// это нужно вводить

        private void button1_Click(object sender, EventArgs e)
        {
            // для ввода данных польз.
            string Log = textBox2.Text;
            string Pas = textBox1.Text;
            //Проверка данных через цикл 
            if (Log == Login && Pas == Password)
            {
                form1.Show();// правильный ввод то переход на форму 1 

            }
            else
            {
                MessageBox.Show("Ошибка в логине или пароле.Попробуйте снова!", "Ошибка Авторизации");
            }
        }
    }
}
