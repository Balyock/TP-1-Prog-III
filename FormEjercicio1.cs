using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_GRUPO_19
{
    public partial class FormEjercicio1 : Form
    {
        public FormEjercicio1()
        {
            InitializeComponent();
        }

        private void FormEjercicio1_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (textBoxNombres.Text.Trim().Length != 0)
            {
                lbNombres.Items.Add(textBoxNombres.Text.Trim());
                textBoxNombres.Text = "";
                MessageBox.Show("Nombre agregado");
            }
            else
            {
                MessageBox.Show("Debe ingresar un nombre");
                textBoxNombres.Text = "";
            }
        }
    }
}
