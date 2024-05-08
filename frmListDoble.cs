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
        clsListaDoble FilaDePersonas = new clsListaDoble();
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

        private void rdAscendente_CheckedChanged(object sender, EventArgs e)
        {
            FilaDePersonas.Recorrer(dgvListaDoble);
            FilaDePersonas.Recorrer(lstListadoble);
            FilaDePersonas.Recorrer(cmbListaDoble);
            FilaDePersonas.Recorrer();
        }

        private void rdDescendente_CheckedChanged(object sender, EventArgs e)
        {
            FilaDePersonas.RecorrerDes(dgvListaDoble);
            FilaDePersonas.RecorrerDes(lstListadoble);
            FilaDePersonas.RecorrerDes(cmbListaDoble);
            FilaDePersonas.RecorrerDes();
        }
    }
}
