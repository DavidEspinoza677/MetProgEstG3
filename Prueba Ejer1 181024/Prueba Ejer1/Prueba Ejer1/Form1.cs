using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba_Ejer1
{
    public partial class Form1 : Form
    {

        private List<Estudiante> estudiantes = new List<Estudiante>();

        public Form1()
        {
            InitializeComponent();
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            double notaFinal;


            if (double.TryParse(txtNotaFinal.Text, out notaFinal))
            {

                Estudiante estudiante = new Estudiante(nombre, apellido, notaFinal);
                estudiantes.Add(estudiante);


                ActualizarListaEstudiantes();


                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("Ingrese una nota válida.");
            }
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {

            Estudiante[] estudiantesArray = estudiantes.ToArray();
            Ordenador.MergeSort(estudiantesArray, 0, estudiantesArray.Length - 1);
            estudiantes = estudiantesArray.ToList();


            ActualizarListaEstudiantes();
        }


        private void ActualizarListaEstudiantes()
        {
            lstEstudiantes.Items.Clear();
            foreach (Estudiante estudiante in estudiantes)
            {
                lstEstudiantes.Items.Add(estudiante.ToString());
            }
        }


        private void LimpiarCampos()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtNotaFinal.Text = "";
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            double notaFinal;

            
            if (double.TryParse(txtNotaFinal.Text, out notaFinal))
            {
                
                Estudiante estudiante = new Estudiante(nombre, apellido, notaFinal);
                estudiantes.Add(estudiante);

                
                ActualizarListaEstudiantes();

                
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("Ingrese una nota válida.");
            }
        }

        private void btnOrdenar_Click_1(object sender, EventArgs e)
        {
            
            Estudiante[] estudiantesArray = estudiantes.ToArray();
            Ordenador.MergeSort(estudiantesArray, 0, estudiantesArray.Length - 1);
            estudiantes = estudiantesArray.ToList();

            
            ActualizarListaEstudiantes();
        }
    }


    public struct Estudiante
    {
        public string Nombre;
        public string Apellido;
        public double NotaFinal;

        public Estudiante(string nombre, string apellido, double notaFinal)
        {
            Nombre = nombre;
            Apellido = apellido;
            NotaFinal = notaFinal;
        }


        public string ObtenerCalificacionLetra()
        {
            if (NotaFinal >= 90)
                return "A";
            else if (NotaFinal >= 80)
                return "B";
            else if (NotaFinal >= 70)
                return "C";
            else if (NotaFinal >= 60)
                return "D";
            else
                return "F";
        }


        public override string ToString()
        {
            return $"{Nombre} {Apellido}, Nota Final: {NotaFinal}, Calificación: {ObtenerCalificacionLetra()}";
        }
    }


    public class Ordenador
    {

        public static void MergeSort(Estudiante[] estudiantes, int left, int right)
        {
            if (left < right)
            {
                int middle = (left + right) / 2;

                MergeSort(estudiantes, left, middle);
                MergeSort(estudiantes, middle + 1, right);

                Merge(estudiantes, left, middle, right);
            }
        }


        private static void Merge(Estudiante[] estudiantes, int left, int middle, int right)
        {
            int n1 = middle - left + 1;
            int n2 = right - middle;

            Estudiante[] leftArray = new Estudiante[n1];
            Estudiante[] rightArray = new Estudiante[n2];

            Array.Copy(estudiantes, left, leftArray, 0, n1);
            Array.Copy(estudiantes, middle + 1, rightArray, 0, n2);

            int i = 0, j = 0, k = left;
            while (i < n1 && j < n2)
            {
                if (leftArray[i].NotaFinal <= rightArray[j].NotaFinal)
                {
                    estudiantes[k] = leftArray[i];
                    i++;
                }
                else
                {
                    estudiantes[k] = rightArray[j];
                    j++;
                }
                k++;
            }

            while (i < n1)
            {
                estudiantes[k] = leftArray[i];
                i++;
                k++;
            }

            while (j < n2)
            {
                estudiantes[k] = rightArray[j];
                j++;
                k++;
            }
        }
    }
}