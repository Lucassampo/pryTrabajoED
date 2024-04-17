using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection.Emit;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoED
{
    public partial class frmListSimple : Form
    {
        clsListaSimple FilaDePersonas = new clsListaSimple();
        public frmListSimple()
        {
            InitializeComponent();
        }
        private void frmListSimple_Load(object sender, EventArgs e)
        {
            FilaDePersonas.Recorrer(cmbListaSimple);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clsNodo objNodo = new clsNodo();
            objNodo.Codigo = Convert.ToInt32(txtCodigo.Text);
            objNodo.Nombre = txtNombre.Text;
            objNodo.Tramite = txtTramite.Text;
            FilaDePersonas.Agregar(objNodo);
            FilaDePersonas.Recorrer(dgvListaSimple);
            FilaDePersonas.Recorrer(lstListaSimple);
            FilaDePersonas.Recorrer(cmbListaSimple);
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (FilaDePersonas.Primero != null)
            {
                FilaDePersonas.Eliminar(Convert.ToInt32(cmbListaSimple.Text));
                FilaDePersonas.Recorrer(dgvListaSimple);
                FilaDePersonas.Recorrer(lstListaSimple);
                FilaDePersonas.Recorrer(cmbListaSimple);
                cmbListaSimple.SelectedIndex = -1;
            }
        }
    }
}
