using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PJ012
{
    public partial class frmTriangulo : Form
    {
        public frmTriangulo()
        {
            InitializeComponent();
        }

        private void Calcular(object sender, EventArgs e)
        {
            triangulo t;
            t = new triangulo();
            t.setVlado1(int.Parse(txtlado1.Text));
            t.setVlado2(int.Parse(txtlado2.Text));
            t.setVlado3(int.Parse(txtlado3.Text));
            t.calcularValores();

            lblResultado.Text = t.calcularValores();
        }
    }
}
