﻿using Backend;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kiosquito2._0
{
    public partial class Kiosquito : Form   
    {
        private Productos productos = new Productos();
        public Kiosquito()
        {
            InitializeComponent();
            dtProductos.DataSource = productos.Datatable;
            BorrarPantalla();

        }

        private void BorrarPantalla()
        {
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtPrecio.Text = "";
           
        }

        private void btCargar_Click(object sender, EventArgs e)
        {
            producto producto = new producto();
            if (txtCodigo.Text != "" || txtNombre.Text != "" || txtPrecio.Text !="") ;
            {
                try
                {
                 producto.Codigo = txtCodigo.Text.ToUpper();
                    producto.Nombre = txtNombre.Text.ToUpper();
                    producto.Precio = Convert.ToInt32(txtPrecio.Text);
                }
                catch (Exception)
                {

                }


            }
            
        }
        bool a = false;

        private void btBorrar_Click(object sender, EventArgs e)
        {
            bool res = productos.BorrarProd(txtCodigo.Text.ToUpper());

            if (res)
            {
                BorrarPantalla();

            }
            else
            {
                txtCodigo.Focus();
             
            }

        }

        private void btModificar_Click(object sender, EventArgs e)
        {
                  producto cosas = new producto();
            cosas = productos.Buscarprod(txtCodigo.Text);

            if(cosas.Codigo != null)
            { 
                txtCodigo.Text = cosas.Codigo.ToUpper();
                txtNombre.Text = cosas.Nombre;
                txtPrecio.Text = cosas.Precio.ToString();
                a = true;
                productos.BorrarProd(txtCodigo.Text);
            }

        
        }         
          private void btbuscar_Click(object sender, EventArgs e)
          {
            producto cosas = new producto();
                cosas = productos.Buscarprod(txtCodigo.Text);
            if(cosas.Codigo !=null)
            {
                txtCodigo.Text= cosas.Codigo.ToUpper();
                txtNombre.Text = cosas.Codigo;
                txtPrecio.Text = cosas.Precio.ToString();
            }
                         
          }

        public void btPerdidas_Click(object sender, EventArgs e)
        {
            Eliminados_perdidas formularionuevo = new Eliminados_perdidas();
            formularionuevo.ShowDialog();
        }
    }
}
