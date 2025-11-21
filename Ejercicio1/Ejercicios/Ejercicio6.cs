using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1.Ejercicios
{
    public partial class Ejercicio6 : Form
    {
        private DataTable numeros = new DataTable();

        //Colores
        private Color colorRecorrido = Color.Blue;
        private Color colorCorrecto = Color.Green;
        private Color colorDefecto;
        public Ejercicio6()
        {
            InitializeComponent();
            GenerarNumeros();
            this.colorDefecto = dgvNumeros.DefaultCellStyle.ForeColor;
            dgvNumeros.DefaultCellStyle.SelectionBackColor = dgvNumeros.DefaultCellStyle.BackColor;
            dgvNumeros.DefaultCellStyle.SelectionForeColor = dgvNumeros.DefaultCellStyle.ForeColor;
        }
        private void GenerarNumeros()
        {
            for(int iColumna = 0; iColumna < 10; iColumna++)
            {
                DataColumn nuevaColumna = new DataColumn();
                numeros.Columns.Add(nuevaColumna);
            }
            Random random = new Random();
            for (int iFila = 0; iFila < 10; iFila++)
            {
                DataRow nuevaFila = numeros.NewRow();
                for(int iCelda = 0; iCelda < 10;  iCelda++)
                {
                    int randomInRange = random.Next(1, 101);
                    nuevaFila[iCelda] = randomInRange;
                }
                numeros.Rows.Add(nuevaFila);
            }
            dgvNumeros.DataSource = numeros;
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

        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            string numeroBuscado = AsignarNumero();
            if(numeroBuscado == "no")
            {
                tbNumeroBuscado = null;
                return;
            }
            else
            {
                List<string> indexEncontrados = new List<string>();
                foreach (DataGridViewRow filaActual in dgvNumeros.Rows)
                {
                    foreach (DataGridViewCell celdaActual in filaActual.Cells)
                    {
                        celdaActual.Style.ForeColor = colorRecorrido;
                        lblResultado.Visible = true;
                        lblResultado.Text = "Recorriendo toda la tabla...";
                        await Task.Delay(300);
                        if (celdaActual.Value.ToString() == numeroBuscado)
                        {
                            celdaActual.Style.ForeColor = colorCorrecto;
                            celdaActual.Style.SelectionForeColor = colorCorrecto;
                            string indexColumna = celdaActual.ColumnIndex.ToString();
                            string indexFila = celdaActual.RowIndex.ToString();
                            string indexEncontrado = $"[{indexFila}, {indexColumna}]";
                            indexEncontrados.Add(indexEncontrado);
                        }
                        else
                        {
                            celdaActual.Style.ForeColor = colorDefecto;
                        }
                    }
                }
                if(indexEncontrados.Count != 0)
                {
                    lblResultado.Text = "Coincidencias encontradas en las celdas " + string.Join(" ,", indexEncontrados);
                }
                else
                {
                    lblResultado.Text = "No se encontraron coincidencias";
                }
            }
        }
    }
}
