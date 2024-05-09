using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryEstructuraDatos
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
            if (Raiz == null)
            {
                Raiz = Nuevo;
            }
            else
            {
                clsNodo NodoPadre = Raiz; //ant
                clsNodo Aux = Raiz;

                while (Aux != null)
                {
                    NodoPadre = Aux;

                    if (Nuevo.Codigo < Aux.Codigo)
                    {
                        Aux = Aux.Izquierdo;
                    }
                    else
                    {
                        Aux = Aux.Derecho;
                    }
                }

                if (Nuevo.Codigo < NodoPadre.Codigo)
                {
                    NodoPadre.Izquierdo = Nuevo;
                }
                else
                {
                    NodoPadre.Derecho = Nuevo;
                }
            }
        }

        public void Recorrer(DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            InOrdenAsc(Grilla, Raiz);
        }

        public void InOrdenAsc(DataGridView Dgv, clsNodo R)
        {
            if(R == null)
            {
                return;
            }
            
            if (R.Izquierdo != null)
            {
                InOrdenAsc(Dgv, R.Izquierdo);
            }

            Dgv.Rows.Add(R.Codigo, R.Nombre, R.Tramite);

            if (R.Derecho != null)
            {
                InOrdenAsc(Dgv, R.Derecho);
            }
        }

        public void RecorrerDesc(DataGridView dgv)
        {
            dgv.Rows.Clear();
            InOrdenDesc(dgv, Raiz);
        }

        public void InOrdenDesc(DataGridView Dgv, clsNodo R) 
        {
            if(R == null)
            {
                return;
            }

            if (R.Derecho != null)
            {
                InOrdenDesc(Dgv, R.Derecho);
            }

            Dgv.Rows.Add(R.Codigo, R.Nombre, R.Tramite);

            if (R.Izquierdo != null)
            {
                InOrdenDesc(Dgv, R.Izquierdo);
            }
        }

        public void RecorrerPreOrden(DataGridView dgv)
        {
            dgv.Rows.Clear();
            PreOrden(dgv, Raiz);
        }

        public void PreOrden(DataGridView dgv, clsNodo R) 
        {
            if (R == null)
            {
                return;
            }
            
            dgv.Rows.Add(R.Codigo, R.Nombre, R.Tramite);

            if (R.Izquierdo != null)
            {
                PreOrden(dgv, R.Izquierdo);
            }

            if (R.Derecho != null)
            {
                PreOrden(dgv, R.Derecho);
            }
        }

        public void RecorrerPostOrden(DataGridView dgv)
        {
            dgv.Rows.Clear();
            PostOrden(dgv, Raiz);
        }

        public void PostOrden(DataGridView dgv, clsNodo R)
        {
            if(R == null)
            {
                return;
            }
            
            if (R.Izquierdo != null)
            {
                PostOrden(dgv, R.Izquierdo);
            }

            if (R.Derecho != null)
            {
                PostOrden(dgv, R.Derecho);
            }
            
            dgv.Rows.Add(R.Codigo, R.Nombre, R.Tramite);
        }

        public void Recorrer(ListBox Lista)
        {
            Lista.Items.Clear();
            InOrdenAsc(Lista, Raiz);
        }

        public void InOrdenAsc(ListBox Lst, clsNodo R)
        {
            if(R == null)
            {
                return;
            }
            
            if (R.Izquierdo != null)
            {
                InOrdenAsc(Lst, R.Izquierdo);
            }

            Lst.Items.Add(R.Codigo);
            
            if (R.Derecho != null)
            {
                InOrdenAsc(Lst, R.Derecho);
            }
        }

        public void RecorrerDesc(ListBox Lst)
        {
            Lst.Items.Clear();
            InOrdenDesc(Lst, Raiz);
        }

        public void InOrdenDesc(ListBox Lst, clsNodo R)
        {
            if(R == null)
            {
                return;
            }

            if (R.Derecho != null)
            {
                InOrdenDesc(Lst, R.Derecho);
            }

            Lst.Items.Add(R.Codigo);
            
            if (R.Izquierdo != null)
            {
                InOrdenDesc(Lst, R.Izquierdo);
            }
        }

        public void RecorrerPreOrden(ListBox lst)
        {
            lst.Items.Clear();
            PreOrden(lst, Raiz);
        }

        public void PreOrden(ListBox lst, clsNodo R) 
        {
            if (R == null)
            {
                return;
            }
            
            lst.Items.Add(R.Codigo);
            
            if (R.Izquierdo != null)
            {
                PreOrden(lst, R.Izquierdo);
            }
            
            if (R.Derecho != null)
            {
                PreOrden(lst, R.Derecho);
            }
        }

        public void RecorrerPostOrden(ListBox lst)
        {
            lst.Items.Clear();
            PostOrden(lst, Raiz);
        }

        public void PostOrden(ListBox lst, clsNodo R)
        {
            if(R == null)
            {
                return;
            }

            if (R.Izquierdo != null)
            {
                PostOrden(lst, R.Izquierdo);
            }
            
            if (R.Derecho != null)
            {
                PostOrden(lst, R.Derecho);
            }
            
            lst.Items.Add(R.Codigo);
        }

        public void Recorrer(TreeView tree)
        {
            tree.Nodes.Clear();
            TreeNode NodoPadre = new TreeNode("Árbol");
            tree.Nodes.Add(NodoPadre);
            PreOrden(Raiz, NodoPadre);
            tree.ExpandAll();
        }

        private void PreOrden(clsNodo R, TreeNode nodoTreeView) 
        {
            if(R == null)
            {
                return;
            }

            TreeNode NodoPadre = new TreeNode(R.Codigo.ToString());

            nodoTreeView.Nodes.Add(NodoPadre);
            
            if (R.Izquierdo != null)
            {
                PreOrden(R.Izquierdo, NodoPadre);
            }
            
            if (R.Derecho != null)
            {
                PreOrden(R.Derecho, NodoPadre);
            }
        }

        public void Recorrer(ComboBox Combo)
        {
            Combo.Items.Clear();
            InOrdenAsc(Combo, Raiz);
        }

        public void InOrdenAsc(ComboBox cmb, clsNodo R)
        {
            if(R == null) 
            {
                return; 
            }
            
            if (R.Izquierdo != null)
            {
                InOrdenAsc(cmb, R.Izquierdo);
            }

            cmb.Items.Add(R.Codigo);

            if (R.Derecho != null)
            {
                InOrdenAsc(cmb, R.Derecho);
            }
        }

        public void RecorrerArbolDesc(ComboBox cmb)
        {
            cmb.Items.Clear();
            InOrdenDesc(cmb, Raiz);
        }

        public void InOrdenDesc(ComboBox cmb, clsNodo R)
        {
            if (R == null)
            {
                return;
            }

            if (R.Derecho != null)
            {
                InOrdenDesc(cmb, R.Derecho);
            }

            cmb.Items.Add(R.Codigo);


            if (R.Izquierdo != null)
            {
                InOrdenDesc(cmb, R.Izquierdo);
            }
        }

        public void RecorrerPreOrden(ComboBox cmb)
        {
            cmb.Items.Clear();
            PreOrden(cmb, Raiz);
        }

        public void PreOrden(ComboBox cmb, clsNodo R) 
        {
            cmb.Items.Add(R.Codigo); 

            if (R.Izquierdo != null)
            {
                PreOrden(cmb, R.Izquierdo);
            }

            if (R.Derecho != null)
            {
                PreOrden(cmb, R.Derecho);
            }
        }

        public void RecorrerPostOrden(ComboBox cmb)
        {
            cmb.Items.Clear();
            PostOrden(cmb, Raiz);
        }

        public void PostOrden(ComboBox cmb, clsNodo R)
        {        
            if (R.Izquierdo != null)
            {
                PostOrden(cmb, R.Izquierdo);
            }

            if (R.Derecho != null)
            {
                PostOrden(cmb, R.Derecho);
            }

            cmb.Items.Add(R.Codigo);
        }

        public clsNodo BuscarCodigo(Int32 cod)
        {
            clsNodo Aux = Raiz;
            while (Aux != null)
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
            GrabarVectorInOrden(Raiz);
            Raiz = null;
            Equilibrar(0, i - 1);
        }

        private void Equilibrar(Int32 ini, Int32 fin)
        {
            Int32 m = (ini + fin) / 2;
            if (ini <= fin)
            {
                Agregar(Vector[m]);
                Equilibrar(ini, m - 1);
                Equilibrar(m + 1, fin);
            }
        }

        private void GrabarVectorInOrden(clsNodo NodoPadre, Int32 Codigo)
        {
            if (NodoPadre.Izquierdo != null)
            {
                GrabarVectorInOrden(NodoPadre.Izquierdo, Codigo);
            }
            if (NodoPadre.Codigo != Codigo)
            {
                Vector[i] = NodoPadre;
                i = i + 1;
            }
            if (NodoPadre.Derecho != null)
            {
                GrabarVectorInOrden(NodoPadre.Derecho, Codigo);
            }
        }

        private void GrabarVectorInOrden(clsNodo NodoPadre)
        {
            if(NodoPadre == null)
            {
                return;
            }

            if (NodoPadre.Izquierdo != null)
            {
                GrabarVectorInOrden(NodoPadre.Izquierdo);
            }

            Vector[i] = NodoPadre;
            i = i + 1;

            if (NodoPadre.Derecho != null)
            {
                GrabarVectorInOrden(NodoPadre.Derecho);
            }
        }

        public void Eliminar(Int32 codigo)
        {
            i = 0;
            GrabarVectorInOrden(Raiz, codigo);
            Raiz = null;
            Equilibrar(0, i - 1);
        }
    }
}
