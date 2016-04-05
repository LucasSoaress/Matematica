using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grafico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void alunosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Alunos frm = new Alunos();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            Inteiros();   
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }
        }

            private double logbase2(double x)
        {
            return (Double.IsInfinity(Math.Log(x, 2))) ? -1 : Math.Log(x, 2);
        }

        private double expoente2(double x)
        {
            return Math.Pow(2, x);
        }

        private void Naturais(int start = 0, int end = 10)
        {
           chart1.Series["Naturais"].Points.Clear();
            for (int i = start; i < end; i++)
            {
                
                chart1.Series["Naturais"].Points.AddXY(i, logbase2(i));
            }
        }

        private void Inteiros(int start = -10, int end = 10)
        {
           chart1.Series["Inteiros"].Points.Clear();
            for (double i = start; i < end; i += 1)
            {
                
                chart1.Series["Inteiros"].Points.AddXY(i, logbase2(i));
            }
        }

        private void Reais(int start = -10, int end = 10)
        {
           chart1.Series["Reais"].Points.Clear();
            for (double i = start; i < end; i += 0.01)
            {
                
                chart1.Series["Reais"].Points.AddXY(i, logbase2(i));
            }
        }

        private double expoente(double y)
        {
            return (Double.IsInfinity(Math.Pow(2, y))) ? -1 : Math.Pow(2, y);
        }

        private double Potencia(double y)
        {
            return Math.Pow(2, y);
        }

        private void _Naturais(int start = 0, int end = 10)
        {
           chart2.Series["Naturais"].Points.Clear();
            for (int i = start; i < end; i++)
            {
               
                chart2.Series["Naturais"].Points.AddXY(i, expoente(i));
            }
        }

        private void _Inteiros(int start = -10, int end = 10)
        {
           chart2.Series["Inteiros"].Points.Clear();
            for (double i = start; i < end; i += 1)
            {
                
                chart2.Series["Inteiros"].Points.AddXY(i, expoente(i));
            }
        }

        private void _Reais(int start = -10, int end = 10)
        {
           chart2.Series["Reais"].Points.Clear();
            for (double i = start; i < end; i += 0.01)
            {
                
                chart2.Series["Reais"].Points.AddXY(i, expoente(i));
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            foreach (var series in chart2.Series)
            {
                series.Points.Clear();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            _Reais();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Naturais();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Reais();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            _Naturais();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            _Inteiros();
        }
    }
}

