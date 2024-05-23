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
    public partial class ConsultaDeBaseDeDatos : Form
    {
        public ConsultaDeBaseDeDatos()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            clsBaseDeDatos objBaseDatos = new clsBaseDeDatos();
            objBaseDatos.Listar(dgvConsulta, txtOpRealizar.Text);
        }
    }
}
