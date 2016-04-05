using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zumbi
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();   
        }

        private void jogoToolStripMenuItem_Click(object sender, EventArgs e) // ABRE O FORM DE SOBRE
        {
            Sobre frm = new Sobre();
            frm.Show();
        }

         private void alunosToolStripMenuItem_Click_1(object sender, EventArgs e) // ABRE O FORM DE ALUNOS
        {
            alunos frm = new alunos();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e) // MOSTRA AS RESPOSTAS
        {
            label1.Text = "O número de zumbis tende a aumentar";
            label2.Text = "Não, como (x=1), o número de zumbis será zero, pois qualquer número elevado a zero é um (x^0 = 1)";
            label3.Text = "A população será de 300 zumbis"; 
            label4.Text = "A diferença é de aproximadamente 200 zumbis";
            label9.Text = "Domínio: R*        Imagem: R";
        }

        private void button2_Click(object sender, EventArgs e) // MOSTRA O GRAFICO ATÉ 30
        {
           chart1.Series["Pontos"].Points.Clear();
            for (double x = 1; x <= 30; x++)
            {
                chart1.Series["Pontos"].Points.AddXY(x, Math.Log(Math.Pow(x, 4), (5 * Math.Pow(5f, 1f / 3f))));
            }
        }

        private void button3_Click(object sender, EventArgs e) // LIMPA O GRÁFICO
        {
            chart1.Series["Pontos"].Points.Clear();
        }

        private void button4_Click(object sender, EventArgs e) // MOSTRA O GRÁFICO ATÉ 60
        {
            chart1.Series["Pontos"].Points.Clear();
            for (double x = 1; x <= 60; x++)
            {
                chart1.Series["Pontos"].Points.AddXY(x, Math.Log(Math.Pow(x, 4), (5 * Math.Pow(5f, 1f / 3f))));
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";
            label9.Text = "";
        }

    }
}
