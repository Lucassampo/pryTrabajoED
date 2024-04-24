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
    }
}
