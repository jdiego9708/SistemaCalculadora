using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SISCalculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.btnSumar.Click += btnSumar_Click;
            this.btnRestar.Click += BtnRestar_Click;
            this.btnMultiplicar.Click += BtnMultiplicar_Click;
            this.btnDividir.Click += BtnDividir_Click;
        }



        private void AbrirConexionBD()
        {

        }

        private void BtnDividir_Click(object sender, EventArgs e)
        {
            try
            {
                decimal numero1 = Convert.ToDecimal(this.txtNumero1.Text);
                decimal numero2 = Convert.ToDecimal(this.txtNumero2.Text);

                decimal resultado = numero1 / numero2;

                this.lblResultado.Text = $"Resultado = {resultado}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error = {ex.Message}");
            }
        }

        private void BtnMultiplicar_Click(object sender, EventArgs e)
        {
            try
            {
                int numero1 = Convert.ToInt32(this.txtNumero1.Text);
                int numero2 = Convert.ToInt32(this.txtNumero2.Text);

                int resultado = numero1 * numero2;

                this.lblResultado.Text = $"Resultado = {resultado}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error = {ex.Message}");
            }
        }

        private void BtnRestar_Click(object sender, EventArgs e)
        {
            try
            {
                int numero1 = Convert.ToInt32(this.txtNumero1.Text);
                int numero2 = Convert.ToInt32(this.txtNumero2.Text);

                int resultado = numero1 - numero2;

                this.lblResultado.Text = $"Resultado = {resultado}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error = {ex.Message}");
            }
        }

        //Este botón es para sumar dos números
        private void btnSumar_Click(object sender, EventArgs e)
        {
            try
            {
                int numero1 = Convert.ToInt32(this.txtNumero1.Text);
                int numero2 = Convert.ToInt32(this.txtNumero2.Text);

                int resultado = numero1 + numero2;

                this.lblResultado.Text = $"Resultado = {resultado} {Environment.NewLine}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error = {ex.Message}");
            }                     
        }
    }
}
