using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraSencilla
{
    public partial class MainCalc : Form
    {
        Calculadora Calc;
        public MainCalc()
        {
            InitializeComponent();
            Calc = new Calculadora();
            lbPantalla.Text = Calc.ObtenerValor();
        }

        private void btnNum1_Click(object sender, EventArgs e)
        {
            lbPantalla.Text = Calc.PulsarNumeros("1");
        }

        private void btnNum2_Click(object sender, EventArgs e)
        {
            lbPantalla.Text = Calc.PulsarNumeros("2");
        }

        private void btnNum3_Click(object sender, EventArgs e)
        {
            lbPantalla.Text = Calc.PulsarNumeros("3");
        }

        private void btnNum4_Click(object sender, EventArgs e)
        {
            lbPantalla.Text = Calc.PulsarNumeros("4");
        }

        private void btnNum5_Click(object sender, EventArgs e)
        {
            lbPantalla.Text = Calc.PulsarNumeros("5");
        }

        private void btnNum6_Click(object sender, EventArgs e)
        {
            lbPantalla.Text = Calc.PulsarNumeros("6");
        }

        private void btnNum7_Click(object sender, EventArgs e)
        {
            lbPantalla.Text = Calc.PulsarNumeros("7");
        }

        private void btnNum8_Click(object sender, EventArgs e)
        {
            lbPantalla.Text = Calc.PulsarNumeros("8");
        }

        private void btnNum9_Click(object sender, EventArgs e)
        {
            lbPantalla.Text = Calc.PulsarNumeros("9");
        }

        private void btnOpSuma_Click(object sender, EventArgs e)
        {
            lbPantalla.Text = Calc.Sumar();
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            lbPantalla.Text = Calc.Resultado();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lbPantalla.Text = Calc.Clear();
        }

        private void btnOpResta_Click(object sender, EventArgs e)
        {
            lbPantalla.Text = Calc.Restar();
        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            lbPantalla.Text = Calc.PulsarNumeros(".");
        }

        private void btnOpMulti_Click(object sender, EventArgs e)
        {
            lbPantalla.Text = Calc.Multiplicar();
        }

        private void btnOpDiv_Click(object sender, EventArgs e)
        {
            lbPantalla.Text = Calc.Dividir();
        }

        private void btnNum0_Click(object sender, EventArgs e)
        {
            lbPantalla.Text = Calc.PulsarNumeros("0");
        }
    }
}
