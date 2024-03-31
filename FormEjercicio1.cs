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
            bool valido = true;
            if (textBoxNombres.Text.Trim().Length != 0)
            {
                foreach(String aux in lbNombres.Items)
                {
                    String nombre = textBoxNombres.Text.Trim().ToUpper();
                    if (aux.ToUpper() == nombre)
                    {
                        MessageBox.Show("Ese nombre ya está en la lista");
                        valido = false;
                    }
                }
                if (valido)
                {
                    lbNombres.Items.Add(textBoxNombres.Text.Trim());
                    textBoxNombres.Text = "";
                    MessageBox.Show("Nombre agregado");
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar un nombre");
                textBoxNombres.Text = "";
            }
        }

        private void btnPasarUno_Click(object sender, EventArgs e)
        {
            if (lbNombres.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un nombre");
            }
            else
            {
                listBox2.Items.Add(lbNombres.SelectedItem);
            }
        }

        private void btnPasarTodo_Click(object sender, EventArgs e)
        {
            foreach (String aux in lbNombres.Items)
            {
                listBox2.Items.Add(aux);
            }
            lbNombres.Items.Clear();
        }
    }
}
