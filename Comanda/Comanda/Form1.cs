using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comanda
{
    public partial class Form1 : Form
    {
        readonly BaseDatos menus;
        public Form1()
        {
            InitializeComponent();
            this.Text = "San Jorge Restaurant";
            this.BackColor = Color.BurlyWood;
            menus = new BaseDatos();
            menuActivo();
        }

        private void menuActivo()
        {
            CBoxMenu.DataSource = menus.Listamenu;
            CBoxMenu.DisplayMember = "Nombre";
            CBoxMenu.ValueMember = "Id";
        }

        private void comboBoxMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (CBoxMenu.SelectedIndex)
            {
                case 1:LBoxSelection.DataSource = menus.ListAperitivos;
                    LBoxSelection.DisplayMember = "Nombre";
                    LBoxSelection.ValueMember = "Id";
                    break;
                case 2: LBoxSelection.DataSource = menus.ListEnsalada;
                    LBoxSelection.DisplayMember = "Nombre";
                    LBoxSelection.ValueMember = "Id";
                    break;
                case 3: LBoxSelection.DataSource = menus.ListCarnes;
                    LBoxSelection.DisplayMember = "Nombre";
                    LBoxSelection.ValueMember = "Id";
                    break;
                case 4: LBoxSelection.DataSource = menus.ListPescado;
                    LBoxSelection.DisplayMember = "Nombre";
                    LBoxSelection.ValueMember = "Id";
                    break;
                case 5: LBoxSelection.DataSource = menus.ListPollo;
                    LBoxSelection.DisplayMember = "Nombre";
                    LBoxSelection.ValueMember = "Id";
                    break;
                case 6: LBoxSelection.DataSource = menus.ListPasta;
                    LBoxSelection.DisplayMember = "Nombre";
                    LBoxSelection.ValueMember = "Id";
                    break;
                case 7: LBoxSelection.DataSource = menus.ListSandwich;
                    LBoxSelection.DisplayMember = "Nombre";
                    LBoxSelection.ValueMember = "Id";
                    break;
                case 8: LBoxSelection.DataSource = menus.ListPaninis;
                    LBoxSelection.DisplayMember = "Nombre";
                    LBoxSelection.ValueMember = "Id";
                    break;
                case 9: LBoxSelection.DataSource = menus.ListPostre;
                    LBoxSelection.DisplayMember = "Nombre";
                    LBoxSelection.ValueMember = "Id";
                    break;
                case 10: LBoxSelection.DataSource = menus.ListBebida;
                    LBoxSelection.DisplayMember = "Nombre";
                    LBoxSelection.ValueMember = "Id";
                    break;

                default:
                    break;
            }
            
           
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AgregarMenu();   
        }
        private void AgregarMenu()
        {
            var valor = LBoxSelection.SelectedIndex;
            if (valor!=0)
            {
                var datos = Convert.ToDecimal(CboxQuantity.Text) * Convert.ToDecimal(TxtPrecio.Text);
                var total = Convert.ToString(datos);
                DtGridRecibo.Rows.Add(LBoxSelection.Text, CboxQuantity.Text, TxtPrecio.Text,total);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LimpiarAgregar();
            Limpiar();
        }

        private void Limpiar()
        {
            TxtPrecio.Text = "";
            CboxQuantity.Text = "0";
            CBoxMenu.Text = "None";
            TxtTotal.Text = "";
            DtGridRecibo.Rows.Clear();
            LBoxSelection.DataSource = null;
            LBoxSelection.Items.Clear();
        }

        private void LimpiarAgregar()
        {
            TxtPrecio.Text = "";
            CboxQuantity.Text = "0";
            CBoxMenu.Text = "None";
            TxtTotal.Text = "";
        }

        private void buttonCobrar_Click(object sender, EventArgs e)
        {
            cobrar();
        }

        private void cobrar()
        {
            decimal suma = 0;
            foreach (DataGridViewRow Celda in DtGridRecibo.Rows)
            { 
                 suma+=Convert.ToDecimal(Celda.Cells["Total"].Value);
            }

            TxtTotal.Text = Convert.ToString(suma);
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
          Limpiar();
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarMenu();
        }

        private void limpiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LimpiarAgregar();
        }

        private void cobrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cobrar();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Proyecto POO Mayo 2019","Acerca de..");
        }

       

       
          


        
    }
}
