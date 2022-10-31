using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BackEnd;

namespace FrondEnd
{
    public partial class Borrar : Form
    {
        Productos BorrarDatosProductos = new Productos();


        public Borrar()
        {
            InitializeComponent();
            
            dtgv_borrar.DataSource = Cargar.Producto.DTp;
        }

        private void btVolver_Click(object sender, EventArgs e)
        {
            Menu llamar_menu = new Menu();
            llamar_menu.Show();
            this.Close();
        }

        private void btBorrar_Click(object sender, EventArgs e)
        {
            BorrarDatosProductos.Codigo = txtCodigoB.Text;
            Cargar.Producto.VerificarCodigo(BorrarDatosProductos);

            if (Cargar.Producto.Confirmacion == false)
            {
                Cargar.Producto.BorrarTabla(BorrarDatosProductos);
                txtCodigoB.Text = "";
                lbaviso.Text = "";
                txtCodigoB.Focus();

            }
            else
            {
                lbaviso.Text = "No existe el codigo";
            }

        }
    }
}
