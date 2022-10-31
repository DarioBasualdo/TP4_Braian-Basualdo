using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BackEnd
{
    public class Lista_de_Productos
    {
        

        public DataTable DTp { get; set; } = new DataTable();
        public bool Confirmacion { get; set; } = new bool();

        public Lista_de_Productos() {
            DTp.TableName = "Productos";
           
            DTp.Columns.Add("Codigo" , typeof(string));
            DTp.Columns.Add("Producto", typeof(string));
            DTp.Columns.Add ("Precio" , typeof(int));

            LeerDTfile();
        }

        public void LeerDTfile() {
            if (System.IO.File.Exists("ListaProducto.xml"))
            {
                DTp.ReadXml("ListaProducto.xml");
                DTp.WriteXml("ListaProducto.xml");
              
            }
        
        }

        public void CargarTabla(Productos productos){

                DTp.Rows.Add();
                int UltimoProducto = DTp.Rows.Count - 1;

                DTp.Rows[UltimoProducto]["Codigo"] = productos.Codigo;
                DTp.Rows[UltimoProducto]["Producto"] = productos.Producto;
                DTp.Rows[UltimoProducto]["Precio"] = productos.Precio;

                DTp.WriteXml("ListaProducto.xml");

        }
        public void BorrarTabla(Productos productos)
        {
            for (int i = 0; i < DTp.Rows.Count; i++)
            {
                if (Convert.ToString(DTp.Rows[i]["Codigo"]) == productos.Codigo)
                {
                    DTp.Rows[i].Delete();

                    break;
                }
                
            }
           
            DTp.WriteXml("ListaProducto.xml");
            
        }


        public void ActualizarTabla(Productos productos) {


            for (int i = 0; i < DTp.Rows.Count; i++)
            {
                if (Convert.ToString(DTp.Rows[i]["Codigo"]) == productos.Codigo)
                {
                    DTp.Rows[i]["Producto"] = productos.Producto;
                    DTp.Rows[i]["Precio"] = productos.Precio;

                   
                }
            }

            DTp.WriteXml("ListaProducto.xml");

        }

        public void VerificarCodigo(Productos productos) {

            Confirmacion = true;

            for (int i = 0; i < DTp.Rows.Count; i++)
            {
                if (Convert.ToString(DTp.Rows[i]["Codigo"]) == productos.Codigo )
                {
                    Confirmacion = false;
                }
                
            }
        
        }

    }
}
