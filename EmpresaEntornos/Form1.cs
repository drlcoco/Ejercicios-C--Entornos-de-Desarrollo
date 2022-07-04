using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Empresa
{
    
    public partial class Form1 : Form
    {
        NuevoEmpleado ne;
        public Form1()
        {
            InitializeComponent();
           
        }
        //creo nuevo form, y paso la ListView al Listview del Form y lo llamo de forma modal
        
        private void btn_añadir_Click(object sender, EventArgs e)
        {
            ne = new NuevoEmpleado();
            ne.SetLista(lstv_nombre);
            ne.ShowDialog();
        }
        
        private void lstv_nombre_SelectedIndexChanged(object sender, EventArgs e)
        {
            //recorro la lista y asigno los subitems a los diferentes TextBox
            foreach (ListViewItem item in lstv_nombre.SelectedItems)
            {
                txt_dni.Text = item.SubItems[3].Text;
                txt_sueldo.Text = item.SubItems[4].Text;
                txt_info.Text = item.SubItems[5].Text;
            }

        }
        //recorro la lista y quito los items seleccionados. Borro el texto de los TextBox.
        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem list in lstv_nombre.SelectedItems)
            {
                list.Remove();
                txt_dni.Text = "";
                txt_sueldo.Text = "";
                txt_info.Text = "";
            }
            
        }
    }
}
