using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1.Ejercicios
{
    public partial class Ejercicio3 : Form
    {
        //Colores
        private Color colorRecorrido = Color.Blue;
        private Color colorCorrecto = Color.Green;
        private Color colorDefecto;
        public Ejercicio3()
        {
            InitializeComponent();
            colorDefecto = tbParrafo.ForeColor;
        }

        private void Ejercicio3_Load(object sender, EventArgs e)
        {
            GenerarTextoDefecto();
        }

        private void GenerarTextoDefecto()
        {
            string texto = "Puedo escribir los versos más tristes esta noche.\r\nEscribir, por ejemplo: «La noche está estrellada,\r\ny tiritan, azules, los astros, a lo lejos».\r\nEl viento de la noche gira en el cielo y canta.\r\nPuedo escribir los versos más tristes esta noche.\r\nYo la quise, y a veces ella también me quiso.\r\nEn las noches como ésta la tuve entre mis brazos.\r\nLa besé tantas veces bajo el cielo infinito.\r\nElla me quiso, a veces yo también la quería.\r\nCómo no haber amado sus grandes ojos fijos.\r\nPuedo escribir los versos más tristes esta noche.\r\nPensar que no la tengo. Sentir que la he perdido.\r\nOír la noche inmensa, más inmensa sin ella.\r\nY el verso cae al alma como al pasto el rocío.\r\nQué importa que mi amor no pudiera guardarla.\r\nLa noche está estrellada y ella no está conmigo.\r\nEso es todo. A lo lejos alguien canta. A lo lejos\r\nMi alma no se contenta con haberla perdido.\r\nComo para acercarla mi mirada la busca.\r\nMi corazón la busca, y ella no está conmigo.\r\nLa misma noche que hace blanquear los mismos árboles.\r\nNosotros, los de entonces, ya no somos los mismos.\r\nYa no la quiero, es cierto, pero cuánto la quise.\r\nMi voz buscaba el viento para tocar su oído.\r\nDe otro. Será de otro. Como antes de mis besos.\r\nSu voz, su cuerpo claro. Sus ojos infinitos.\r\nYa no la quiero, es cierto, pero tal vez la quiero.\r\nEs tan corto el amor, y es tan largo el olvido.\r\nPorque en noches como ésta la tuve entre mis brazos,\r\nmi alma no se contenta con haberla perdido.\r\nAunque éste sea el último dolor que ella me causa,\r\ny estos sean los últimos versos que yo le escribo.";
            tbParrafo.Text = texto;
        }

        private int ObtenerNumCaracteres(string palabraNormalizada)
        {
            int caracteres = palabraNormalizada.Length;
            return caracteres;
        }
        private char ObtenerPrimeraLetra(string palabraNormalizada)
        {
            char primeraLetra = palabraNormalizada[0];
            return primeraLetra;
        }


        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            tbParrafo.SelectAll();
            tbParrafo.SelectionColor = colorDefecto;

            //Obtener caracteres y primera letra de la palabra buscada
            string palabraNormalizada = tbPalabra.Text.ToString().ToLower().Trim();
            int numCaracteres = ObtenerNumCaracteres(palabraNormalizada);
            char primeraLetra = ObtenerPrimeraLetra(palabraNormalizada);
            string texto = tbParrafo.Text.ToLower().Trim();

            //Buscar primera letra con búsqueda lineal
            List<int> indices = new List<int>();
            for (int i = 0; i < texto.Length; i++)
            {
                //Guardar los índices en los que aparezcan
                if (primeraLetra == texto[i])
                {
                    tbParrafo.Select(i, 1);
                    tbParrafo.SelectionColor = colorRecorrido;
                    indices.Add(i);
                }
                lblEstado.Visible = true;
            }
            lblEstado.Text = "Buscando la primera letra...";
            await Task.Delay(2000);

            //Ver si el resto de caracteres coinciden
            lblEstado.Text = "Viendo si el resto de caracteres coinciden...";
            int apariciones = 0;
            foreach(int i in indices)
            {
                tbParrafo.Select(i, numCaracteres);
                tbParrafo.SelectionColor = colorRecorrido;
                await Task.Delay(500);
                tbParrafo.SelectionColor = colorDefecto;
                if (tbParrafo.SelectedText.ToLower().Trim() == palabraNormalizada)
                {
                    tbParrafo.SelectionColor = colorCorrecto;
                    apariciones++;
                }
            }

            if(apariciones == 0)
            {
                lblEstado.Text = "No se encontraron coincidencias.";
            }
            else
            {
                lblEstado.Text = $"Se encontraron {apariciones} coincidencias.";
            }
        }

        private void btnTextoDefecto_Click(object sender, EventArgs e)
        {
            GenerarTextoDefecto();
        }
    }
}
