using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sesion6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregarNombre_Click(object sender, EventArgs e)
        {
            agregar();
        }
        private void agregar()
        {
            string nombre = tbNombre.Text.Trim();
            if (string.IsNullOrEmpty(nombre))
            {
                Message.Show("No puede quedar vacio el nombre");
                tbNombre.Focus();
                return;
            }
            cmbNombres.Items.Add(nombre);
            tbNombre.Focus();
            tbNombre.Text = "";
        }

        private void tbNombre_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
    




        