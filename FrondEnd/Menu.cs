using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrondEnd
{
    public partial class Menu : Form
    {
     
        public Menu()
        {
            InitializeComponent();
        }


        private void btSalir_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void btCargar_Click(object sender, EventArgs e)
        {
            Cargar opcion_crear = new Cargar();
            opcion_crear.Show();
            this.Close();
        }

        private void btActualizar_Click(object sender, EventArgs e)
        {
            Actualizar llamar_actualizar = new Actualizar();
            llamar_actualizar.Show();
            this.Close();
        }

        private void btVer_Click(object sender, EventArgs e)
        {
            Ver llamar_ver = new Ver();
            llamar_ver.Show();
            this.Close();
        }

        private void btBorrar_Click(object sender, EventArgs e)
        {
            Borrar llamar_borrar = new Borrar();
            llamar_borrar.Show();
            this.Close();
        }

   
    }
}
