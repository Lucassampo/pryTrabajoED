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
    public partial class frmEstructuraDeDatos : Form
    {
        public frmEstructuraDeDatos()
        {
            InitializeComponent();
        }

        private void sitemaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSistema sistema = new frmSistema();
            sistema.Show();
        }

        private void colaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCola cola = new frmCola();
            cola.Show();
        }

        private void frmEstructuraDeDatos_Load(object sender, EventArgs e)
        {

        }

        private void pilaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPila pila = new frmPila();
            pila.Show();
        }

        private void listaSimpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListSimple simple = new frmListSimple();
            simple.Show();
        }

        private void listaDobleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListDoble doble = new frmListDoble();
            doble.Show();
        }

        private void arbolBinarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmArbolBinario Arbol = new frmArbolBinario();
            Arbol.Show();
        }

        private void baseDeDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void consultasEnLaBaseDeDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaDeBaseDeDatos Base = new ConsultaDeBaseDeDatos();
            Base.Show();
        }

        private void repasoDeOperacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRepasoDeOperaciones repaso = new frmRepasoDeOperaciones();
            repaso.Show();
        }

        private void operacionesConTablasDeBasesDeDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOperaciones operaciones = new frmOperaciones();
            operaciones.Show();
        }
    }
}
