using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //declarar variable receptoras de los valores
            double valor1 = 0;
            double valor2 = 0;
            double result = 0;

            //leer los valores desde los campos de texto
            valor1 = Convert.ToDouble(textBox2.Text);
            valor2 = Convert.ToDouble(textBox3.Text);
            //suma
            result = valor1 + valor2;
            //mostrar el resultadode la suma en la interfaz
            textBox1.Text = Convert.ToString(result);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //declarar variable receptoras de los valores
            double valor1 = 0;
            double valor2 = 0;
            double result = 0;

            //leer los valores desde los campos de texto
            valor1 = Convert.ToDouble(textBox2.Text);
            valor2 = Convert.ToDouble(textBox3.Text);
            //suma
            result = valor1 - valor2;
            //mostrar el resultadode la suma en la interfaz
            textBox1.Text = Convert.ToString(result);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //declarar variable receptoras de los valores
            double valor1 = 0;
            double valor2 = 0;
            double result = 0;

            //leer los valores desde los campos de texto
            valor1 = Convert.ToDouble(textBox2.Text);
            valor2 = Convert.ToDouble(textBox3.Text);
            //suma
            result = valor1 * valor2;
            //mostrar el resultadode la suma en la interfaz
            textBox1.Text = Convert.ToString(result);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //declarar variable receptoras de los valores
            double valor1 = 0;
            double valor2 = 0;
            double result = 0;

            //leer los valores desde los campos de texto
            valor1 = Convert.ToDouble(textBox2.Text);
            valor2 = Convert.ToDouble(textBox3.Text);
            //suma
            result = valor1 / valor2;
            //mostrar el resultadode la suma en la interfaz
            textBox1.Text = Convert.ToString(result);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }
    }
}