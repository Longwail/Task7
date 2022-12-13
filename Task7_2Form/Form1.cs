using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task7_2Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string data = textBoxArea.Text;
                if (data.Length == 0) throw new Exception("Пустая строка. Введите что нибудь!");
                var result = data.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .GroupBy(x => x)
                    .Where(x => x.Count() == 1)
                    .Select(x => x.Key);
                foreach (var item in result) textBoxRes.Text = item;
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
