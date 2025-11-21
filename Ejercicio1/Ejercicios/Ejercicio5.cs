using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1.Ejercicios
{
    public partial class Ejercicio5 : Form
    {
        private List<int> numeros = new List<int>();
        public Ejercicio5()
        {
            InitializeComponent();
        }

        private void btnAddNumero_Click(object sender, EventArgs e)
        {
            try
            {
                int numero = Convert.ToInt32(tbNumero.Text.ToString());
                numeros.Add(numero);
            }
            catch
            {
                MessageBox.Show("INGRESE UN ENTERO, no sea imbécil");
            }
            rtbListaNumeros.Text = string.Join(", ", numeros);
            tbNumero.Text = null;
        }

        private async void btnEncontrar_Click(object sender, EventArgs e)
        {
            numeros.Sort();
            rtbListaNumeros.Text = string.Join(", ", numeros);
            lblResultado.Text = "Ordenando lista";
            lblResultado.Visible = true;
            await Task.Delay(300);

            int indexMaximo = numeros.Count() - 1;
            int minimo = numeros[0];
            int maximo = numeros[indexMaximo];
            int lengthMinimo = numeros[0].ToString().Length;
            int lengthMaximo = numeros[indexMaximo].ToString().Length;

            int caracteresTexto = rtbListaNumeros.Text.ToString().Length;
            rtbListaNumeros.Select(0, lengthMinimo);
            rtbListaNumeros.SelectionColor = Color.Green;
            rtbListaNumeros.Select(caracteresTexto - lengthMaximo, lengthMaximo);
            rtbListaNumeros.SelectionColor = Color.Green;

            lblResultado.Text = $"Mínimo: {minimo}\nMáximo: {maximo}";
        }

        private void tbNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                btnAddNumero_Click(sender, e);
            }
        }
    }
}
