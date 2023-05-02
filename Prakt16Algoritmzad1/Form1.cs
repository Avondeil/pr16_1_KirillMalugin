using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prakt16Algoritm
{
    public partial class Form1 : Form
    {

        string readtext;
        int count = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string file = openFileDialog1.FileName;
                readtext = File.ReadAllText(file);
                button1.Visible = false;
                panel1.Visible = true;
                button2.Visible = true;
            }
            else
            {
                MessageBox.Show("Файл не был выбран!");
            }
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string read="";
            count = 0;
            for (int i = 0; i < readtext.Length; i++)
            {
                if (!char.IsPunctuation(readtext[i]))
                {
                    read += readtext[i];
                }
            }
            string[] text = read.Split(' ');
            foreach (string textone in text)
            {
                string textbox = textBox1.Text.ToLower();
                if (textone.ToLower() == textbox)
                {
                    count++;
                }
            }
            if (count>0)
            MessageBox.Show($"В тексте {readtext} было найдено {count} вхождений слова {textBox1.Text}", "Нахождение вхождений слова", MessageBoxButtons.OK);
            else MessageBox.Show($"Вхождений не было найдено", "Нахождение вхождений слова", MessageBoxButtons.OK);
        }
    }
}
