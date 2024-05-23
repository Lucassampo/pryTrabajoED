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
    public partial class frmBaseDeDatos : Form
    {
        public frmBaseDeDatos()
        {
            InitializeComponent();
        }
        clsBaseDeDatos clsBaseDeDatos = new clsBaseDeDatos();
        private void btnProyeccionSimple_Click(object sender, EventArgs e)
        {
            string varSQL = "SELECT TITULO FROM LIBRO ORDER BY 1 DESC";
            //objBaseDatos.Listar(dgvMostrar, varSQL);
        }
    }
}
