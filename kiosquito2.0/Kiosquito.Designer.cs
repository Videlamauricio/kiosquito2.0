namespace kiosquito2._0
{
    partial class Kiosquito
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtProductos = new System.Windows.Forms.DataGridView();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.btCargar = new System.Windows.Forms.Button();
            this.btPerdidas = new System.Windows.Forms.Button();
            this.btBorrar = new System.Windows.Forms.Button();
            this.btbuscar = new System.Windows.Forms.Button();
            this.btModificar = new System.Windows.Forms.Button();
            this.btConfirmar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // dtProductos
            // 
            this.dtProductos.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dtProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtProductos.Location = new System.Drawing.Point(159, 74);
            this.dtProductos.Name = "dtProductos";
            this.dtProductos.Size = new System.Drawing.Size(396, 228);
            this.dtProductos.TabIndex = 1;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCodigo.Location = new System.Drawing.Point(9, 14);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(45, 15);
            this.lblCodigo.TabIndex = 2;
            this.lblCodigo.Text = "Codigo:";
            this.lblCodigo.UseMnemonic = false;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNombre.Location = new System.Drawing.Point(12, 74);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(49, 15);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPrecio.Location = new System.Drawing.Point(12, 141);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(42, 15);
            this.lblPrecio.TabIndex = 4;
            this.lblPrecio.Text = "Precio:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(12, 30);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 5;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(12, 94);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 6;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(12, 157);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 20);
            this.txtPrecio.TabIndex = 7;
            // 
            // btCargar
            // 
            this.btCargar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btCargar.Location = new System.Drawing.Point(12, 210);
            this.btCargar.Name = "btCargar";
            this.btCargar.Size = new System.Drawing.Size(100, 35);
            this.btCargar.TabIndex = 8;
            this.btCargar.Text = "Cargar";
            this.btCargar.UseVisualStyleBackColor = false;
            this.btCargar.Click += new System.EventHandler(this.btCargar_Click);
            // 
            // btPerdidas
            // 
            this.btPerdidas.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btPerdidas.Location = new System.Drawing.Point(15, 257);
            this.btPerdidas.Name = "btPerdidas";
            this.btPerdidas.Size = new System.Drawing.Size(97, 35);
            this.btPerdidas.TabIndex = 9;
            this.btPerdidas.Text = "Perdidas  ";
            this.btPerdidas.UseVisualStyleBackColor = false;
            this.btPerdidas.Click += new System.EventHandler(this.btPerdidas_Click);
            // 
            // btBorrar
            // 
            this.btBorrar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btBorrar.Location = new System.Drawing.Point(432, 33);
            this.btBorrar.Name = "btBorrar";
            this.btBorrar.Size = new System.Drawing.Size(100, 35);
            this.btBorrar.TabIndex = 10;
            this.btBorrar.Text = "Borrar";
            this.btBorrar.UseVisualStyleBackColor = false;
            this.btBorrar.Click += new System.EventHandler(this.btBorrar_Click);
            // 
            // btbuscar
            // 
            this.btbuscar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btbuscar.Location = new System.Drawing.Point(169, 30);
            this.btbuscar.Name = "btbuscar";
            this.btbuscar.Size = new System.Drawing.Size(100, 35);
            this.btbuscar.TabIndex = 11;
            this.btbuscar.Text = "Buscar";
            this.btbuscar.UseVisualStyleBackColor = false;
            this.btbuscar.Click += new System.EventHandler(this.btbuscar_Click);
            // 
            // btModificar
            // 
            this.btModificar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btModificar.Location = new System.Drawing.Point(305, 30);
            this.btModificar.Name = "btModificar";
            this.btModificar.Size = new System.Drawing.Size(100, 35);
            this.btModificar.TabIndex = 12;
            this.btModificar.Text = "Modficar";
            this.btModificar.UseVisualStyleBackColor = false;
            this.btModificar.Click += new System.EventHandler(this.btModificar_Click);
            // 
            // btConfirmar
            // 
            this.btConfirmar.Location = new System.Drawing.Point(318, 6);
            this.btConfirmar.Name = "btConfirmar";
            this.btConfirmar.Size = new System.Drawing.Size(75, 23);
            this.btConfirmar.TabIndex = 13;
            this.btConfirmar.Text = "Confirmar";
            this.btConfirmar.UseVisualStyleBackColor = true;
            this.btConfirmar.Click += new System.EventHandler(this.btConfirmar_Click);
            // 
            // Kiosquito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(557, 304);
            this.Controls.Add(this.btConfirmar);
            this.Controls.Add(this.btModificar);
            this.Controls.Add(this.btbuscar);
            this.Controls.Add(this.btBorrar);
            this.Controls.Add(this.btPerdidas);
            this.Controls.Add(this.btCargar);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.dtProductos);
            this.Name = "Kiosquito";
            this.Text = "Kiosquito";
            ((System.ComponentModel.ISupportInitialize)(this.dtProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtProductos;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Button btCargar;
        private System.Windows.Forms.Button btPerdidas;
        private System.Windows.Forms.Button btBorrar;
        private System.Windows.Forms.Button btbuscar;
        private System.Windows.Forms.Button btModificar;
        private System.Windows.Forms.Button btConfirmar;
    }
}

