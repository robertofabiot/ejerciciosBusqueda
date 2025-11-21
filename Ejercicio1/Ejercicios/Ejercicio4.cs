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
    public partial class Ejercicio4 : Form
    {
        class Estudiante
        {
            public int Id { get; set; }
            public string Nombre { get; set; }
        }

        //Colores
        private Color colorRecorrido = Color.Blue;
        private Color colorCorrecto = Color.Green;
        private Color colorDefecto;

        private List<Estudiante> estudiantes = new List<Estudiante>()
        {
            new Estudiante { Id = 1, Nombre = "Ana López" },
            new Estudiante { Id = 2, Nombre = "Carlos Martínez" },
            new Estudiante { Id = 3, Nombre = "Sofía Herrera" },
            new Estudiante { Id = 4, Nombre = "Luis González" },
            new Estudiante { Id = 5, Nombre = "María Fernández" },
            new Estudiante { Id = 6, Nombre = "Diego Sánchez" },
            new Estudiante { Id = 7, Nombre = "Elena Torres" },
            new Estudiante { Id = 8, Nombre = "Javier Ruiz" },
            new Estudiante { Id = 9, Nombre = "Gabriela Castro" },
            new Estudiante { Id = 10, Nombre = "Fernando Vega" }
        };

        public Ejercicio4()
        {
            InitializeComponent();
            dgvEstudiantes.DataSource = new List<Estudiante>(estudiantes);
            dgvEstudiantes.DefaultCellStyle.SelectionBackColor = dgvEstudiantes.DefaultCellStyle.BackColor;
            dgvEstudiantes.DefaultCellStyle.SelectionForeColor = dgvEstudiantes.DefaultCellStyle.ForeColor;
            this.colorDefecto = dgvEstudiantes.DefaultCellStyle.ForeColor;
        }

        private async void btnBuscarIDLineal_Click(object sender, EventArgs e)
        {
            int i = 0;
            string indexIDEncontrado = null;
            string idBuscado = tbID.Text.ToString();
            lblResultado.Text = "Haciendo búsqueda lineal...";
            lblResultado.Visible = true;
            foreach (DataGridViewRow filaActual in dgvEstudiantes.Rows)
            {
                i = 0;
                foreach (DataGridViewCell celdaActual in filaActual.Cells)
                {
                    if (i == 0)
                    {
                        celdaActual.Style.ForeColor = colorRecorrido;
                        await Task.Delay(300);
                        if (celdaActual.Value.ToString() == idBuscado)
                        {
                            celdaActual.Style.ForeColor = colorCorrecto;
                            celdaActual.Style.SelectionForeColor = colorCorrecto;
                            indexIDEncontrado = celdaActual.RowIndex.ToString();
                        }
                        else
                        {
                            celdaActual.Style.ForeColor = colorDefecto;
                        }
                    }
                    i = 1;
                }
            }
            if(indexIDEncontrado != null)
            {
                lblResultado.Text = $"Encontrado en el índice: {indexIDEncontrado}";
            }
        }

        private void OrdenarFilas()
        {
            dgvEstudiantes.Sort(dgvEstudiantes.Columns["Nombre"], ListSortDirection.Ascending);

        }

        private void btnBuscarNombreBinaria_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn column in dgvEstudiantes.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.Automatic;
            }
        }
    }
}
