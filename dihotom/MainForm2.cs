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
    public partial class MainForm2 : Form
    {
        public MainForm2()
        {
            InitializeComponent();
        }
        double x;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MainForm2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
              void AddLog(String str)
            {

            }

             double Phi(double x)
            {
                return (x * x + 4) / 5;

            }

            x = Convert.ToDouble(iks.Text);
            double Xlast;
            
            double dx = double.MaxValue;
            while (Math.Pow(dx, 2) > 1e-13)
            {
                AddLog(x.ToString());
                Xlast = x;
                x = Phi(Xlast);
                dx = x - Xlast;
            }
            result.Text=Convert.ToString($"x0={x}");
            tutu2.Text = Convert.ToString("Результат: ");
        }

        private void result_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
      "Метод итерации или метод простой итерации — численный метод решения системы линейных" +
      " алгебраических уравнений. " +
      "Суть метода заключается в нахождении по приближённому значению " +
      "величины следующего приближения, являющегося более точным.",
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
    }
}
