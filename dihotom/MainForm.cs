using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dihotom
{

    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        double e = 0.001;
        double a, b;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void one_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
       "Метод дихотомии применяется для унимодальных функций. " +
"Метод дихотомии заключается в том, что исходный" +
" интервал [а,b] делится средней точкой с = (b + a) / 2 " +
"на два подинтервала [а,с] и [с,b] в одном из которых лежит точка минимума х*.",
       "Сообщение",
       MessageBoxButtons.YesNo,
       MessageBoxIcon.Information,
       MessageBoxDefaultButton.Button1,
       MessageBoxOptions.DefaultDesktopOnly);

            if (result == DialogResult.Yes)
            this.TopMost = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 mainForm = new Form1();
            mainForm.Show();
            Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            a = Convert.ToDouble(one.Text);

            b = Convert.ToDouble(two.Text);

            double kuw = 0.001;

            double c = (a + b) / 2;
            double g = kuw + kuw;

            while (b - a >= 2 * kuw)
            {
                if ((Math.Pow(a, 2) - 2) * (Math.Pow(c, 2) - 2) < 0)
                {
                    b = c;
                }
                else
                {
                    a = c;
                }

                c = (a + b) / 2;
            }

            tutu.Text = Convert.ToString("Результат: ");
            result.Text = Convert.ToString(c);

            
        }
    }

   
    }


