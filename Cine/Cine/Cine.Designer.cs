namespace Cine
{
    partial class Cine
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
            this.modificaTablaPelicula = new System.Windows.Forms.Button();
            this.Sucursal = new System.Windows.Forms.Button();
            this.Membresia = new System.Windows.Forms.Button();
            this.Sala = new System.Windows.Forms.Button();
            this.Venta = new System.Windows.Forms.Button();
            this.Funcion = new System.Windows.Forms.Button();
            this.Asiento = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // modificaTablaPelicula
            // 
            this.modificaTablaPelicula.Location = new System.Drawing.Point(69, 34);
            this.modificaTablaPelicula.Name = "modificaTablaPelicula";
            this.modificaTablaPelicula.Size = new System.Drawing.Size(75, 23);
            this.modificaTablaPelicula.TabIndex = 0;
            this.modificaTablaPelicula.Text = "Pelicula";
            this.modificaTablaPelicula.UseVisualStyleBackColor = true;
            this.modificaTablaPelicula.Click += new System.EventHandler(this.modificaTablaPelicula_Click);
            // 
            // Sucursal
            // 
            this.Sucursal.Location = new System.Drawing.Point(69, 77);
            this.Sucursal.Name = "Sucursal";
            this.Sucursal.Size = new System.Drawing.Size(75, 23);
            this.Sucursal.TabIndex = 1;
            this.Sucursal.Text = "Sucursal";
            this.Sucursal.UseVisualStyleBackColor = true;
            this.Sucursal.Click += new System.EventHandler(this.Sucursal_Click);
            // 
            // Membresia
            // 
            this.Membresia.Location = new System.Drawing.Point(69, 120);
            this.Membresia.Name = "Membresia";
            this.Membresia.Size = new System.Drawing.Size(75, 23);
            this.Membresia.TabIndex = 2;
            this.Membresia.Text = "Membresia";
            this.Membresia.UseVisualStyleBackColor = true;
            this.Membresia.Click += new System.EventHandler(this.Membresia_Click);
            // 
            // Sala
            // 
            this.Sala.Location = new System.Drawing.Point(69, 163);
            this.Sala.Name = "Sala";
            this.Sala.Size = new System.Drawing.Size(75, 23);
            this.Sala.TabIndex = 3;
            this.Sala.Text = "Sala";
            this.Sala.UseVisualStyleBackColor = true;
            this.Sala.Click += new System.EventHandler(this.Sala_Click);
            // 
            // Venta
            // 
            this.Venta.Location = new System.Drawing.Point(69, 206);
            this.Venta.Name = "Venta";
            this.Venta.Size = new System.Drawing.Size(75, 23);
            this.Venta.TabIndex = 4;
            this.Venta.Text = "Venta";
            this.Venta.UseVisualStyleBackColor = true;
            this.Venta.Click += new System.EventHandler(this.Venta_Click);
            // 
            // Funcion
            // 
            this.Funcion.Location = new System.Drawing.Point(69, 249);
            this.Funcion.Name = "Funcion";
            this.Funcion.Size = new System.Drawing.Size(75, 23);
            this.Funcion.TabIndex = 5;
            this.Funcion.Text = "Función";
            this.Funcion.UseVisualStyleBackColor = true;
            this.Funcion.Click += new System.EventHandler(this.Funcion_Click);
            // 
            // Asiento
            // 
            this.Asiento.Location = new System.Drawing.Point(69, 293);
            this.Asiento.Name = "Asiento";
            this.Asiento.Size = new System.Drawing.Size(75, 23);
            this.Asiento.TabIndex = 6;
            this.Asiento.Text = "Asiento";
            this.Asiento.UseVisualStyleBackColor = true;
            this.Asiento.Click += new System.EventHandler(this.Asiento_Click);
            // 
            // Cine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 349);
            this.Controls.Add(this.Asiento);
            this.Controls.Add(this.Funcion);
            this.Controls.Add(this.Venta);
            this.Controls.Add(this.Sala);
            this.Controls.Add(this.Membresia);
            this.Controls.Add(this.Sucursal);
            this.Controls.Add(this.modificaTablaPelicula);
            this.Name = "Cine";
            this.Text = "Cine";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button modificaTablaPelicula;
        private System.Windows.Forms.Button Sucursal;
        private System.Windows.Forms.Button Membresia;
        private System.Windows.Forms.Button Sala;
        private System.Windows.Forms.Button Venta;
        private System.Windows.Forms.Button Funcion;
        private System.Windows.Forms.Button Asiento;
    }
}

