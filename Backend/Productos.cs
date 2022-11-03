﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend
{
    public class Productos
    {
        public DataTable Datatable { get; set; } = new DataTable();

        public Productos()
        {
            Datatable.TableName = "Productos";
            Datatable.Columns.Add("Codigo",typeof (string));
            Datatable.Columns.Add("Nombre",typeof (string));
            Datatable.Columns.Add("Precio",typeof(string));

            Leer_Datatable();
               
        }
        public int BuscarFilaProductos(string cosas)
        {
            int fila = -1;
            for (int i = 0; i < Datatable.Rows.Count; i++)
            {
                if (Datatable.Rows[i]["Codigo"].ToString() == cosas) { 
                    
                    fila = i;
                    break;  
                }    
                
            }
        return fila;
        }



        public bool CargarProductos(producto productos)
        {
            bool res = false;
            if (!Validar(productos))
            {

                Datatable.Rows.Add();
                int i = Datatable.Rows.Count - 1;

               Datatable.Rows[i]["Codigo"] = productos.Codigo;
                Datatable.Rows[i]["Nombre"] = productos.Nombre;
                Datatable.Rows[i]["Precio"] = productos.Precio;

                Datatable.WriteXml("Productos.xml");

                res = true;
            }
            return res;
        }

        private bool Validar(producto producto)
        {
            bool res = false;
            int fila = BuscarFilaProductos(producto.Codigo);
            if(fila != -1)
            {
                res = true;
         
            }
            return res;    
        }

        public bool BorrarProd(string cosas)
        {
            bool res = false;
            int fila = BuscarFilaProductos(cosas);

            if (fila != -1)
            {
                Datatable.Rows[fila].Delete();
                Datatable.WriteXml("Productos.xml");
                res = true;
            }
            return res;

        }







        private void Leer_Datatable()
        {
            if (System.IO.File.Exists("Productos.xml"))
            { 
            Datatable.ReadXml("Productos.xml");
            }
        }

        public bool Modificar(producto productos)
        {
            bool res = false;
            Datatable.Rows.Add();
            int i = Datatable.Rows.Count -1;
            Datatable.Rows[i]["Codigo"] = productos.Codigo;
            Datatable.Rows[i]["Nombre"] = productos.Nombre;
            Datatable.Rows[i]["Precio"] = productos.Precio;
            Datatable.WriteXml("Productos.xml");
            res=true;
            return res;



        }

        public producto Buscarprod(string cosas)
        {
          producto producto = new producto();

            for(int i = 0; i < Datatable.Rows.Count; i++)
            {
                if(Datatable.Rows[i]["Codigo"].ToString() == cosas)
                {
                    producto.Codigo = Datatable.Rows[i]["Codigo"].ToString();
                    producto.Nombre = Datatable.Rows[i]["Nombre"].ToString();
                    producto.Precio = System.Convert.ToInt32(Datatable.Rows[i]["Precio"]);
                    break;

                }

            }
            return producto;
        }



    }
}
