using EvalueAge.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvalueAge
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblAnswer_Click(object sender, EventArgs e)
        {
          
        }

        private void btnEvaluate_Click(object sender, EventArgs e)
        {
            try
            {

                int age = Convert.ToInt32(lblAnswer.Text);
                evaluate evalue = new evaluate();
                lblAnswer.Text = "Tienes " + age + "años. " +
                   evalue.EvalAge(age);
                tbAge.Text = "";
                tbAge.Focus();
            }
            catch (Exception ex)
            {
                lblAnswer.Text = ex.Message;
            }
        }

        private void tbAge_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
