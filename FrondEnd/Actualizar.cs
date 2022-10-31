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
    public partial class Actualizar : Form
    {
        Productos ActualizarDatosProducto = new Productos();

        public Actualizar()
        {
            InitializeComponent();
           
            dtgv_actualizar.DataSource = Cargar.Producto.DTp;

            
        }

        private void btVolver_Click(object sender, EventArgs e)
        {
            Menu llamar_menu = new Menu();
            llamar_menu.Show();
            this.Close();
        }


        private void btActualizar_Click(object sender, EventArgs e)
        {
            ActualizarDatosProducto.Codigo = txtCodigoActualizar.Text;
            ActualizarDatosProducto.Producto = txtProductoA.Text;

                 if (txtPrecioA.Text == "")
                 {
                     ActualizarDatosProducto.Precio = 0;
                  }
                 else
                 {
                     ActualizarDatosProducto.Precio = Convert.ToInt32(txtPrecioA.Text);
                 }
           

            Cargar.Producto.VerificarCodigo(ActualizarDatosProducto);

            if (Cargar.Producto.Confirmacion == false)
            {
                Cargar.Producto.ActualizarTabla(ActualizarDatosProducto);

                txtCodigoActualizar.Text = "";
                txtPrecioA.Text = "";
                txtProductoA.Text = "";
                lbaviso.Text = "";

                txtCodigoActualizar.Focus();
            }
            else {
                lbaviso.Text = "No existe el codigo";
            }

        }
    }
}
