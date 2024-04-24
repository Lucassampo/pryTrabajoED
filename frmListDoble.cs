using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoED
{
    public partial class frmListDoble : Form
    {
        public frmListDoble()
        {
            InitializeComponent();
        }
        clsListaSimple FilaDePersonas = new clsListaSimple();
        private void frmListDoble_Load(object sender, EventArgs e)
        {
            FilaDePersonas.Recorrer(cmbListaDoble);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clsNodo objNodo = new clsNodo();
            objNodo.Codigo = Convert.ToInt32(txtCodigo.Text);
            objNodo.Nombre = txtNombre.Text;
            objNodo.Tramite = txtTramite.Text;
            FilaDePersonas.Agregar(objNodo);
            FilaDePersonas.Recorrer(dgvListaDoble);
            FilaDePersonas.Recorrer(lstListadoble);
            FilaDePersonas.Recorrer(cmbListaDoble);
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (FilaDePersonas.Primero != null)
            {
                FilaDePersonas.Eliminar(Convert.ToInt32(cmbListaDoble.Text));
                FilaDePersonas.Recorrer(dgvListaDoble);
                FilaDePersonas.Recorrer(lstListadoble);
                FilaDePersonas.Recorrer(cmbListaDoble);
                cmbListaDoble.SelectedIndex = -1;
            }
        }
    }
}
