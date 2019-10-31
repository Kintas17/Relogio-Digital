using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Relogio_Digital
{
    
    public partial class Form1 : Form
    {
        int contador = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            contador = 0;
            mostrar();
        }

        private void mostrar()
        {
            int dia = 24 * (int)Math.Pow(60, 2);
            if (contador < 0) contador += dia;
            if (contador >= dia) contador -= dia;
            label1.Text = TimeSpan.FromSeconds(contador).ToString();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            contador++;
            label1.Text = TimeSpan.FromSeconds(contador).ToString();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            contador += 3600;
            mostrar();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            contador += 60;
            mostrar();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            contador += 1;
            mostrar();
        }
        private void Acerta_Relogio(object sender, MouseEventArgs e)
        {
            int valor = 1;
            if (((Button)sender).Name == "minutos") valor = 60;
            if (((Button)sender).Name == "horas") valor = 3600;
            if (e.Button == MouseButtons.Left) contador += valor;
            if (e.Button == MouseButtons.Right) contador -= valor;
            mostrar();
        }
    }
}
