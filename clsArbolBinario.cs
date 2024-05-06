using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoED
{
    internal class clsArbolBinario
    {
        private clsNodo PrimerNodo;

        public clsNodo Raiz
        {
            get { return PrimerNodo; }
            set { PrimerNodo = value; }
        }

        public void Agregar(clsNodo Nuevo)
        {
            Nuevo.Izquierdo = null;
            Nuevo.Derecho = null;
            if(Raiz == null)
            {
                Raiz = Nuevo;
            }
            else
            {
                clsNodo NodoPadre = Raiz; //ant
                clsNodo Aux = Raiz;
                while(Aux != null)
                {
                    NodoPadre = Aux;
                    if(Nuevo.Codigo < Aux.Codigo)
                    {
                        Aux = Aux.Izquierdo;
                    }
                    else
                    {
                        Aux = Aux.Derecho;
                    }
                }
                if(Nuevo.Codigo < NodoPadre.Codigo)
                {
                    NodoPadre.Izquierdo = Nuevo;
                }
                else
                {
                    NodoPadre.Derecho = Nuevo;
                }
            }
        }
        
        public void Recorrer(ComboBox Lista)
        {
            Lista.Items.Clear();
            InOrdenAsc(Lista, Raiz);
        }

        private void InOrdenAsc(ComboBox Lst, clsNodo R)
        {
            if(R.Izquierdo!= null)
            {
                InOrdenAsc(Lst, R.Izquierdo);
            }
            Lst.Items.Clear();
            if(R.Derecho != null)
            {
                InOrdenAsc(Lst, R.Derecho);
            }
        }

        public void Recorrer(DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            InOrdenAsc(Grilla, Raiz);
        }
        private void InOrdenAsc(DataGridView Dgv, clsNodo R)
        {
            if (R.Izquierdo != null) InOrdenAsc(Dgv, R.Izquierdo);
            Dgv.Rows.Add(R.Codigo, R.Nombre, R.Tramite);
            if (R.Derecho != null) InOrdenAsc(Dgv, R.Derecho);
        }

        public void Recorrer(TreeView tree)
        {
            tree.Nodes.Clear();
            TreeNode NodoPadre = new TreeNode("Arbol");
            tree.Nodes.Add(NodoPadre);
            PreOrden(Raiz, NodoPadre);
            tree.ExpandAll();
        }

        private void PreOrden(clsNodo R, TreeNode nodoTreeView)
        {
            TreeNode NodoPadre = new TreeNode(R.Codigo.ToString());
            nodoTreeView.Nodes.Add(NodoPadre);
            if(R.Izquierdo != null)
            {
                PreOrden(R.Izquierdo, NodoPadre);
            }
            if(R.Derecho != null)
            {
                PreOrden(R.Derecho, NodoPadre);
            }
        }

        public void recorrerDes(DataGridView grilla)
        {
            grilla.Rows.Clear();
            InOrdenDes(grilla, Raiz);
        }
        public void recorrerDes(ComboBox combobox)
        {
            combobox.Items.Clear();
            InOrdenDes(combobox, Raiz);
        }
        private void InOrdenDes(ComboBox Lst, clsNodo R)
        {
            if (R.Derecho != null)
            {
                InOrdenDes(Lst, R.Derecho);
            }
            Lst.Items.Clear();
            if (R.Izquierdo != null)
            {
                InOrdenDes(Lst, R.Izquierdo);
            }
        }

        private void InOrdenDes(DataGridView Dgv, clsNodo R)
        {
            if (R.Derecho != null) InOrdenDes(Dgv, R.Derecho);
            Dgv.Rows.Add(R.Codigo, R.Nombre, R.Tramite);
           if (R.Izquierdo != null) InOrdenDes(Dgv, R.Izquierdo);
        }

        private void GrabarVcetorInOrden(clsNodo NodoPadre)
        {
            if(NodoPadre.Izquierdo != null)
            {
                GrabarVcetorInOrden(NodoPadre.Izquierdo);
            }
            Vector[i] = NodoPadre;
            i = i + 1;
            if(NodoPadre.Derecho != null)
            {
                GrabarVcetorInOrden(NodoPadre.Derecho);
            }
        }

        private void GrabarVcetorInOrden(clsNodo NodoPadre, Int32 Codigo)
        {
            if (NodoPadre.Izquierdo != null)
            {
                GrabarVcetorInOrden(NodoPadre.Izquierdo, Codigo);
            }
        }

        private void EquilibrarArbol(Int32 ini, Int32 fin)
        {
            Int32 m = (ini + fin) / 2;
            if(ini <= fin)
            {
                Agregar(Vector[m]);
                EquilibrarArbol(ini, m - 1);
                EquilibrarArbol(m + 1, fin);
            }
        }

        public clsNodo BuscarCodigo(Int32 cod)
        {
            clsNodo Aux = Raiz;
            while(Aux != null)
            {
                if (cod == Aux.Codigo) break;
                if (cod < Aux.Codigo) Aux = Aux.Izquierdo;
                else Aux = Aux.Derecho;
            }
            return Aux;
        }
        private clsNodo[] Vector = new clsNodo[100];
        private Int32 i = 0;

        public void Equilibrar()
        {
            i = 0;
            GrabarVcetorInOrden(Raiz);
            Raiz = null;
            EquilibrarArbol(0, i - 1);
        }
    }
}
