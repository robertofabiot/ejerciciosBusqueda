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
    public partial class Ejercicio2 : Form
    {
        private Label[] labelsNumerosBinaria;
        private int[] numerosRandom = new int[30];
        public Ejercicio2()
        {
            InitializeComponent();
            this.labelsNumerosBinaria = new Label[]
            {
                lblNumeros0, lblNumeros1, lblNumeros2, lblNumeros3, lblNumeros4,
                lblNumeros5, lblNumeros6, lblNumeros7, lblNumeros8, lblNumeros9,
                lblNumeros10, lblNumeros11, lblNumeros12, lblNumeros13, lblNumeros14,
                lblNumeros15, lblNumeros16, lblNumeros17, lblNumeros18, lblNumeros19,
                lblNumeros20, lblNumeros21, lblNumeros22, lblNumeros23, lblNumeros24,
                lblNumeros25, lblNumeros26, lblNumeros27, lblNumeros28, lblNumeros29
            };
        }
        private void Ejercicio2_Load(object sender, EventArgs e)
        {
            GenerarNumeros();
        }
        private void GenerarNumeros()
        {
            Random random = new Random();
            for(int i = 0; i < 30; i++)
            {
                int randomInRange = random.Next(1, 101);
                numerosRandom[i] = randomInRange;
            }
            int index = 0;
            foreach (Label labelActual in labelsNumerosBinaria)
            {
                labelActual.Text = Convert.ToString(numerosRandom[index++]);
            }
        }
        private void OrdenarNumeros()
        {
            Array.Sort(numerosRandom);
            int i = 0;
            foreach (Label labelActual in labelsNumerosBinaria)
            {
                labelActual.Text = Convert.ToString(numerosRandom[i++]);
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
        private bool AllDisabled()
        {
            bool allDisabled = true;
            foreach(Label labelActual in labelsNumerosBinaria)
            {
                if (labelActual.Enabled == true) allDisabled = false;
            }
            return allDisabled;
        }
        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            //Paso 0: Obtener número
            string numero = AsignarNumero();
            if (numero == "no")
            {
                tbNumeroBuscado.Text = null;
                return;
            }
            else
            {
                //Paso 1: Ordenar
                lblExiste.Visible = true;
                lblExiste.Text = "Ordenar";
                await Task.Delay(200);
                OrdenarNumeros();

                //Paso 2: Definir índices
                int i_menor = 0;
                int i_mayor = labelsNumerosBinaria.Count();

                //Preparar para la búsqueda
                Color colorRecorrido = Color.Blue;
                Color colorDefecto = lblNumeros0.ForeColor;
                Color colorEncontrado = Color.Green;

                //Paso 3: Empezar búsqueda
                while (true)
                {
                    foreach (Label labelActual in labelsNumerosBinaria)
                    {
                        labelActual.ForeColor = colorDefecto;
                    }
                    int i_media = Convert.ToInt32(Math.Truncate(Convert.ToDouble((i_menor + i_mayor) / 2)));

                    //Visuales para el usuario
                    lblExiste.Text = $"Evaluar si {numerosRandom[i_media]} es igual a {numero}";
                    labelsNumerosBinaria[i_media].ForeColor = colorRecorrido;

                    //Compruebo si el número del índice medio es igual al número buscado
                    //Si es así, la búsqueda finaliza
                    if (numerosRandom[i_media] == Convert.ToInt32(numero))
                    {
                        labelsNumerosBinaria[i_media].ForeColor = colorEncontrado;
                        lblExiste.Visible = true;
                        lblExiste.Text = "ENCONTRADO";
                        lblTextoPosicion.Visible = true;
                        lblPosicion.Visible = true;
                        lblPosicion.Text = i_media.ToString();
                        break;
                    }
                    //Compruebo si i_media es mayor o menor al número buscado y descarto la otra mitad.

                    //Visual
                    lblExiste.Text = $"Evaluar si {numerosRandom[i_media]} es mayor a {numero}";
                    for (int i = i_media; i < i_mayor; i++)
                    {
                        labelsNumerosBinaria[i].ForeColor = colorRecorrido;
                    }
                    await Task.Delay(2000);

                    if (numerosRandom[i_media] > Convert.ToInt32(numero))
                    {
                        lblExiste.Text = $"Sí lo es. Descartando segunda mitad.";

                        //Visual
                        for (int i = i_media; i < i_mayor; i++)
                        {
                            labelsNumerosBinaria[i].ForeColor = colorDefecto;
                            labelsNumerosBinaria[i].Enabled = false;
                        }
                        //Interno
                        i_mayor = i_media--;
                        await Task.Delay(2000);
                    }
                    else
                    {
                        lblExiste.Text = $"No lo es. Descartando primera mitad.";

                        //Visual
                        for (int i = i_media; i >= i_menor; i--)
                        {
                            labelsNumerosBinaria[i].ForeColor = colorDefecto;
                            labelsNumerosBinaria[i].Enabled = false;
                            foreach (Label labelActual in labelsNumerosBinaria)
                            {
                                labelActual.ForeColor = colorDefecto;
                            }
                        }
                        i_menor = i_media++;
                        await Task.Delay(2000);
                    }
                    if(AllDisabled())
                    {
                        lblExiste.Text = "No encontrado";
                        return;
                    }
                }
            }
        }
    }
}
