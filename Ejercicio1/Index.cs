using Ejercicio1.Ejercicios;
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
    public partial class Index : Form
    {
        public Index()
        {
            InitializeComponent();
        }

        private void btnEjercicio1_Click(object sender, EventArgs e)
        {
            new Ejercicio1().ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Ejercicio2().ShowDialog();
        }

        private void btnEjercicio3_Click(object sender, EventArgs e)
        {
            new Ejercicio3().ShowDialog();
        }
    }
}
