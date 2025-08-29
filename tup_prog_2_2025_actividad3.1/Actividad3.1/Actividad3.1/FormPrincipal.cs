using Actividad3._1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad3._1
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnSimular_Click(object sender, EventArgs e)
        {
            Granja granja = new Granja();

            tbDescripcion.Clear();
            foreach (string acciones in granja.SimularDia())
            {
                tbDescripcion.Text += acciones + "\r\n";
            }
        }
    }
}
