using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TrabajoED
{
    public partial class frmArbolBinario : Form
    {
        public frmArbolBinario()
        {
            InitializeComponent();
        }
        clsArbolBinario FilaDePersonas = new clsArbolBinario();
       
        private void button1_Click(object sender, EventArgs e)
        {
            clsNodo objNodo = new clsNodo();
            objNodo.Codigo = Convert.ToInt32(txtCodigo.Text);
            objNodo.Nombre = txtNombre.Text;
            objNodo.Tramite = txtTramite.Text;
            FilaDePersonas.Agregar(objNodo);
            FilaDePersonas.Recorrer(dgvArbolBinario);
            FilaDePersonas.Recorrer(cmbArbolBinario);
            FilaDePersonas.Recorrer(twArbolBinario);
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";
        }

        private void frmArbolBinario_Load(object sender, EventArgs e)
        {

        }

        private void rdInOrden_CheckedChanged(object sender, EventArgs e)
        {
            FilaDePersonas.Recorrer(dgvArbolBinario);
            FilaDePersonas.Recorrer(cmbArbolBinario);
        }

        private void rdInOrdenDes_CheckedChanged(object sender, EventArgs e)
        {
            FilaDePersonas.recorrerDes(dgvArbolBinario);
            FilaDePersonas.recorrerDes(cmbArbolBinario);
        }

        private void rdPreOrden_CheckedChanged(object sender, EventArgs e)
        {
            FilaDePersonas.Recorrer(dgvArbolBinario);
            FilaDePersonas.Recorrer(twArbolBinario);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FilaDePersonas.Eliminar(Convert.ToInt32(cmbArbolBinario.Text));
            if(FilaDePersonas.Raiz != null)
            {
                FilaDePersonas.Recorrer(dgvArbolBinario);
                FilaDePersonas.Recorrer(twArbolBinario);
                FilaDePersonas.Recorrer(cmbArbolBinario);
                //FilaDePersonas.Recorrer();
            }
            else
            {
                cmbArbolBinario.Items.Clear();
                dgvArbolBinario.Rows.Clear();
                twArbolBinario.Nodes.Clear();
                button2.Enabled = false;
                btnEquilibrar.Enabled = false;
            }
            cmbArbolBinario.SelectedIndex = -1;
        }

        private void btnEquilibrar_Click(object sender, EventArgs e)
        {
            FilaDePersonas.Equilibrar();
            FilaDePersonas.Recorrer(dgvArbolBinario);
        }

        private void rdPostOrden_CheckedChanged(object sender, EventArgs e)
        {
            if (FilaDePersonas.Raiz != null)
            {
                FilaDePersonas.RecorrerPost(dgvArbolBinario);
            } 
        }
    }
}
