using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class Ejercicio1 : Form
    {
        //Me da pereza hacer MVC

        public Ejercicio1()
        {
            InitializeComponent();
            labelsNumeros = new Label[]
            {
                lblNumeros0, lblNumeros1, lblNumeros2, lblNumeros3, lblNumeros4,
                lblNumeros5, lblNumeros6, lblNumeros7, lblNumeros8, lblNumeros9,
                lblNumeros10, lblNumeros11, lblNumeros12, lblNumeros13, lblNumeros14,
                lblNumeros15, lblNumeros16, lblNumeros17, lblNumeros18, lblNumeros19
            };
          
        }

        public List<int> indices = new List<int>();
        private void Form1_Load(object sender, EventArgs e)
        {
            GenerarNumeros();
        }

        public Label[] labelsNumeros;
        private void GenerarNumeros()
        {
            Random random = new Random();
            foreach (Label labelActual in labelsNumeros)
            {
                int randomInRange = random.Next(1, 101);
                labelActual.Text = Convert.ToString(randomInRange);
            }
        }
        private string AsignarNumero()
        {
            try
            {
                int numeroBuscado = Convert.ToInt32(tbNumeroBuscado.Text);
                if (!(numeroBuscado > 0 || numeroBuscado < 101))
                {
                    throw new FormatException();
                }
                return tbNumeroBuscado.Text.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("El número debe ser entre 1 y 100", "Error del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return "no";
            
        }
        private async Task<bool> BuscarNumero(string numero)
        {

            bool encontrado = false;
            int indice = 0;
            foreach (Label labelActual in labelsNumeros)
            {
                Color colorPorDefecto = labelActual.ForeColor;
                labelActual.ForeColor = Color.Blue;
                await Task.Delay(500);
                if (labelActual.Text.ToString() == numero)
                {
                    labelActual.ForeColor = Color.Green;
                    encontrado = true;
                    indices.Add(indice);
                }
                else
                {
                    labelActual.ForeColor = colorPorDefecto;
                }
                indice++;
            }
            return encontrado;
        }
        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            string numero = AsignarNumero();
            if(numero == "no")
            {
                return;
            }
            else
            {
                bool numeroEncontrado = await BuscarNumero(numero);
                if (numeroEncontrado)
                {
                    lblExiste.Visible = true;
                    lblExiste.Text = "ENCONTRADO";
                    lblTextoPosicion.Visible = true;
                    lblPosicion.Visible = true;
                    lblPosicion.Text = string.Join(", ", indices);
                }
                else
                {
                    lblExiste.Visible = true;
                    lblExiste.Text = "NO ENCONTRADO";
                }
            } 
        }
    }
}
