using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estructuras
{
    public partial class Form1 : Form
    {
        struct Punto
        {
            public int X;
            public int Y;

            public Punto(int x, int y)
            {
                X = x;
                Y = y;
            }

            public string Mostrar()
            {
                return $"X: {X}, Y: {Y}";
            }
        }
        const int MAX = 10;
        Punto[] puntos = new Punto[10];
        int i = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            int x = int.Parse(tbX.Text);
            int y = int.Parse(tbY.Text);
            Punto punto = new Punto(x, y);

            if (i < MAX)
            {
                puntos[i] = punto;
                i++;
            }
            else
            {
                MessageBox.Show("No se pueden agregar más puntos", "Puntos",
                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            showData();
        }

        private void showData()
        {
            dgvPuntos.DataSource = dgvPuntos;
            dgvPuntos.Refresh();
        }
    }
}
