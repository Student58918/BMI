using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_bmi(object sender, EventArgs e)
        {
            double waga;
            double wzrost;
            double Bmi;
            waga = double.Parse(textBox1.Text);
            wzrost = double.Parse(textBox2.Text);
            Bmi = (waga) / ((wzrost / 100.0) * (wzrost / 100.0));
            label5.Text = "Uwaga, osoby regularnie uprawiające sport," + "\nmogą być klasyfikowane jako osoby z nadwagą lub otyłe." + "\nPonieważ mięśnie są 3 razy cięższe od tkanki tłuszczowej.";
            if (Bmi < 18.5)
            {
                label4.ForeColor = Color.Blue;
                label4.Text = "Wskaźnik wynosi:" + Bmi + "\nMasz niedowagę";
            }
            else if (Bmi > 18.5 && Bmi < 24.9)
            {
                label4.ForeColor = Color.Green;
                label4.Text = "Wskaźnik wynosi:" + Bmi + "\nGratulacje, twoja sylwetka jest prawidłowa";
            }
            else if (Bmi > 25 && Bmi < 29.9)
            {
                label4.ForeColor = Color.OrangeRed;
                label4.Text = "Wskaźnik wynosi:" + Bmi + "\nUwaga masz nadwagę ";
            }
            else if (Bmi > 30 && Bmi < 34.9)
            {
                label4.ForeColor = Color.Red;
                label4.Text = "Wskaźnik wynosi:" + Bmi + "\nCierpisz na otyłość ";
            }
            else if (Bmi > 35 && Bmi < 39.9)
            {
                label4.ForeColor = Color.Crimson;
                label4.Text = "Wskaźnik wynosi:" + Bmi + "\nUwaga, masz II stopień otyłości";
            }
            else if (Bmi > 40)
            {
                label4.ForeColor = Color.DarkRed;
                label4.Text = "Wskaźnik wynosi:" + Bmi + "\nTwoje życie jest zagrożone, cierpisz na otyłość olbrzymią ";
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_reset(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            label4.Text = "Wynik:";
            label5.Text = "Uwaga";
        }

        private void btn_exit(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Otw(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                label5.Text = openFileDialog1.FileName;
                textBox3.Text = File.ReadAllText(label5.Text);
            }
        }

        private void btn_zap(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            { 
                File.WriteAllText(saveFileDialog1.FileName, textBox3.Text);
            }
        }
    }
}
