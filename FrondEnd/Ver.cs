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
    public partial class Ver : Form
    {
        

        
       
        public Ver()
        {
            InitializeComponent();

            dtgv_ver.DataSource = Cargar.Producto.DTp;
            
        }

        private void btVolver_Click(object sender, EventArgs e)
        {
            Menu llamar_menu = new Menu();
            llamar_menu.Show();
            this.Close();
        }

        
    }
}
