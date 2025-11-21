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

        private void btnEjercicio2_Click(object sender, EventArgs e)
        {
            new Ejercicio2().ShowDialog();
        }

        private void btnEjercicio3_Click(object sender, EventArgs e)
        {
            new Ejercicio3().ShowDialog();
        }

        private void btnEjercicio4_Click(object sender, EventArgs e)
        {
            new Ejercicio4().ShowDialog();
        }

        private void btnEjercicio5_Click(object sender, EventArgs e)
        {
            new Ejercicio5().ShowDialog();
        }

        private void btnEjercicio6_Click(object sender, EventArgs e)
        {
            new Ejercicio6().ShowDialog();
        }
    }
}
