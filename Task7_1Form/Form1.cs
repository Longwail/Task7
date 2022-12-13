using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task7_1Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str;

            try
            {
                str = textBoxArea.Text;
                if (str.Length == 0) throw new Exception("Пустая строка. Введите что нибудь!");
                string[] strsplit = str.Split(':');
                Console.Write(strsplit[strsplit.Length - 1]);
                textBoxRes.Text += strsplit[strsplit.Length - 1].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
