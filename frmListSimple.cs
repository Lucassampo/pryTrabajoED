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
    public partial class frmListSimple : Form
    {
        clsListaSimple FilaDePersonas = new clsListaSimple();
        public frmListSimple()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clsNodo ObjNodo = new clsNodo();
            ObjNodo.Codigo = Convert.ToInt32(txtCodigo.Text);
            ObjNodo.Nombre = txtNombre.Text;
            ObjNodo.Tramite = txtTramite.Text;
            FilaDePersonas.Agregar(ObjNodo);
            FilaDePersonas.Recorrer(dgvListaSimple);
            FilaDePersonas.Recorrer(lstListaSimple);
            FilaDePersonas.Recorrer(cmbListaSimple);
            FilaDePersonas.Recorrer();
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(FilaDePersonas.Primero != null)
            {
                Int32 x = Convert.ToInt32(cmbListaSimple.Text);
                FilaDePersonas.Eliminar(x);
                FilaDePersonas.Recorrer(dgvListaSimple);
                FilaDePersonas.Recorrer(lstListaSimple);
                FilaDePersonas.Recorrer(cmbListaSimple);
                FilaDePersonas.Recorrer();
            }
        }
    }
}
