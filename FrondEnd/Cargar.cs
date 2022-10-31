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
    public partial class Cargar : Form
    {
        public  static Lista_de_Productos Producto { get; set; } = new Lista_de_Productos();

        Productos CargarDatosProductos  = new Productos();

        public Cargar()
        {
            InitializeComponent();
            
            dtgv_cargar.DataSource = Producto.DTp;

        }

        private void btVolver_Click(object sender, EventArgs e)
        {
            Menu llamar_menu = new Menu();
            llamar_menu.Show();
            this.Close();
        }

        private void bt_cargar_Click(object sender, EventArgs e)
        {
            CargarDatosProductos.Codigo = txtCodigoCargar.Text;
            CargarDatosProductos.Producto = txtproducto.Text;
            if (txtprecio.Text == "")
            {
                CargarDatosProductos.Precio = 0;
            }
            else
            {

                CargarDatosProductos.Precio = Convert.ToInt32(txtprecio.Text);
            }


            Producto.VerificarCodigo(CargarDatosProductos);

            if (Producto.Confirmacion == true)
            {
                Producto.CargarTabla(CargarDatosProductos);

                txtCodigoCargar.Text = "";
                txtprecio.Text = "";
                txtproducto.Text = "";
                lbaviso.Text = "";
                txtCodigoCargar.Focus();
            }
            else
            {
                lbaviso.Text = "Codigo repetido, prueve con otro";
            }
           

        }

    }
}
