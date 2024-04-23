using System;
using System. IO;// добавили для сохранения 
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            saveFileDialog1.Filter = "Text File(*.txt)|*.txt";//для сохранения файла в блокнот и для комп
        }

        // цвет для ошибки 
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox6.Text == "")//+
            {
                label12.Visible = true;
                textBox6.BackColor = Color.LightCoral;
            }

               if (textBox5.Text == "")
            {
                label7.Visible = true;//+
                textBox5.BackColor = Color.LightCoral;
            }

                  if  (textBox4.Text == "" )//+
            {
                label9.Visible = true;//+
                textBox4.BackColor = Color.LightCoral;
            }

                        if( textBox3.Text == "" )
            {
                label8.Visible = true;//+
                textBox3.BackColor = Color.LightCoral;
            }

                            if(textBox2.Text == "")
            {
                label11.Visible = true;//+
                textBox2.BackColor = Color.LightCoral;
            }

                                if( textBox1.Text == "")
            {
                label10.Visible = true;//+
                textBox1.BackColor = Color.LightCoral;
            }

            
            
            
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)   // нужно для сохранений
                return;
            string std = "\n";
            string filename = saveFileDialog1.FileName;
            string result = textBox5.Text+ std+ textBox3.Text+std + textBox4.Text+ std + textBox1.Text+ std + textBox2.Text + std + textBox6.Text; // вывод текста и сохран.
            File.WriteAllText(filename, result);
           

            MessageBox.Show("Файл сохранен!");// для пользователя 
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

      
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;// для того чтоб форма не уничтожалась
            Hide();// а скрылась 

        }

        private void pictureBox3_Click(object sender, EventArgs e)// кнопка очистки 
        {
           textBox1.Clear();
           textBox2.Clear();
           textBox3.Clear();
           textBox4.Clear();
           textBox5.Clear();
           textBox6.Clear();
        }

        // цвет для ошибки 
        private void textBox5_Enter(object sender, EventArgs e)
        {
            label7.Visible = false;//+
            textBox5.BackColor = Color.White;
           
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            label8.Visible = false;//+
            textBox3.BackColor = Color.White;
        }

        private void textBox4_Enter(object sender, EventArgs e)
        {
            label9.Visible = false;//+
            textBox4.BackColor = Color.White;
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            label10.Visible = false;//+
            textBox1.BackColor = Color.White;
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            label11.Visible = false;//+
            textBox2.BackColor = Color.White;
        }

        private void textBox6_Enter(object sender, EventArgs e)
        {
            label12.Visible = false;//+
            textBox6.BackColor = Color.White;

        }
    }
}

