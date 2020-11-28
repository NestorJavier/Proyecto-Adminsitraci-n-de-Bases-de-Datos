namespace Cine
{
    partial class FormMembresia
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxPuntos = new System.Windows.Forms.TextBox();
            this.textBoxTelefono = new System.Windows.Forms.TextBox();
            this.EtiquetaPuntos = new System.Windows.Forms.Label();
            this.EtiquetaPromociones = new System.Windows.Forms.Label();
            this.EtiquetaTelefono = new System.Windows.Forms.Label();
            this.EtiquetaNombre = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.Datos = new System.Windows.Forms.DataGridView();
            this.Elimina = new System.Windows.Forms.Button();
            this.Actualiza = new System.Windows.Forms.Button();
            this.Alta = new System.Windows.Forms.Button();
            this.comboBoxPromociones = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.Datos)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxPuntos
            // 
            this.textBoxPuntos.Location = new System.Drawing.Point(266, 12);
            this.textBoxPuntos.Name = "textBoxPuntos";
            this.textBoxPuntos.Size = new System.Drawing.Size(100, 20);
            this.textBoxPuntos.TabIndex = 27;
            // 
            // textBoxTelefono
            // 
            this.textBoxTelefono.Location = new System.Drawing.Point(72, 63);
            this.textBoxTelefono.Name = "textBoxTelefono";
            this.textBoxTelefono.Size = new System.Drawing.Size(100, 20);
            this.textBoxTelefono.TabIndex = 26;
            // 
            // EtiquetaPuntos
            // 
            this.EtiquetaPuntos.Location = new System.Drawing.Point(179, 12);
            this.EtiquetaPuntos.Name = "EtiquetaPuntos";
            this.EtiquetaPuntos.Size = new System.Drawing.Size(45, 13);
            this.EtiquetaPuntos.TabIndex = 25;
            this.EtiquetaPuntos.Text = "Puntos:";
            // 
            // EtiquetaPromociones
            // 
            this.EtiquetaPromociones.AutoSize = true;
            this.EtiquetaPromociones.Location = new System.Drawing.Point(179, 63);
            this.EtiquetaPromociones.Name = "EtiquetaPromociones";
            this.EtiquetaPromociones.Size = new System.Drawing.Size(71, 13);
            this.EtiquetaPromociones.TabIndex = 24;
            this.EtiquetaPromociones.Text = "Promociones:";
            // 
            // EtiquetaTelefono
            // 
            this.EtiquetaTelefono.AutoSize = true;
            this.EtiquetaTelefono.Location = new System.Drawing.Point(16, 63);
            this.EtiquetaTelefono.Name = "EtiquetaTelefono";
            this.EtiquetaTelefono.Size = new System.Drawing.Size(52, 13);
            this.EtiquetaTelefono.TabIndex = 23;
            this.EtiquetaTelefono.Text = "Telefono:";
            // 
            // EtiquetaNombre
            // 
            this.EtiquetaNombre.AutoSize = true;
            this.EtiquetaNombre.Location = new System.Drawing.Point(16, 12);
            this.EtiquetaNombre.Name = "EtiquetaNombre";
            this.EtiquetaNombre.Size = new System.Drawing.Size(47, 13);
            this.EtiquetaNombre.TabIndex = 22;
            this.EtiquetaNombre.Text = "Nombre:";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(72, 12);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(100, 20);
            this.textBoxNombre.TabIndex = 21;
            // 
            // Datos
            // 
            this.Datos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Datos.Location = new System.Drawing.Point(19, 115);
            this.Datos.Name = "Datos";
            this.Datos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Datos.Size = new System.Drawing.Size(713, 267);
            this.Datos.TabIndex = 28;
            this.Datos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Datos_CellClick);
            // 
            // Elimina
            // 
            this.Elimina.Location = new System.Drawing.Point(657, 80);
            this.Elimina.Name = "Elimina";
            this.Elimina.Size = new System.Drawing.Size(75, 23);
            this.Elimina.TabIndex = 32;
            this.Elimina.Text = "Elimina";
            this.Elimina.UseVisualStyleBackColor = true;
            this.Elimina.Click += new System.EventHandler(this.Elimina_Click);
            // 
            // Actualiza
            // 
            this.Actualiza.Location = new System.Drawing.Point(657, 46);
            this.Actualiza.Name = "Actualiza";
            this.Actualiza.Size = new System.Drawing.Size(75, 23);
            this.Actualiza.TabIndex = 31;
            this.Actualiza.Text = "Actualiza";
            this.Actualiza.UseVisualStyleBackColor = true;
            this.Actualiza.Click += new System.EventHandler(this.Actualiza_Click);
            // 
            // Alta
            // 
            this.Alta.Location = new System.Drawing.Point(657, 9);
            this.Alta.Name = "Alta";
            this.Alta.Size = new System.Drawing.Size(75, 23);
            this.Alta.TabIndex = 30;
            this.Alta.Text = "Alta";
            this.Alta.UseVisualStyleBackColor = true;
            this.Alta.Click += new System.EventHandler(this.Alta_Click_1);
            // 
            // comboBoxPromociones
            // 
            this.comboBoxPromociones.FormattingEnabled = true;
            this.comboBoxPromociones.Items.AddRange(new object[] {
            "10",
            "15",
            "20"});
            this.comboBoxPromociones.Location = new System.Drawing.Point(266, 63);
            this.comboBoxPromociones.Name = "comboBoxPromociones";
            this.comboBoxPromociones.Size = new System.Drawing.Size(100, 21);
            this.comboBoxPromociones.TabIndex = 33;
            // 
            // FormMembresia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 394);
            this.Controls.Add(this.comboBoxPromociones);
            this.Controls.Add(this.Elimina);
            this.Controls.Add(this.Actualiza);
            this.Controls.Add(this.Alta);
            this.Controls.Add(this.Datos);
            this.Controls.Add(this.textBoxPuntos);
            this.Controls.Add(this.textBoxTelefono);
            this.Controls.Add(this.EtiquetaPuntos);
            this.Controls.Add(this.EtiquetaPromociones);
            this.Controls.Add(this.EtiquetaTelefono);
            this.Controls.Add(this.EtiquetaNombre);
            this.Controls.Add(this.textBoxNombre);
            this.Name = "FormMembresia";
            this.Text = "FormMembresia";
            ((System.ComponentModel.ISupportInitialize)(this.Datos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPuntos;
        private System.Windows.Forms.TextBox textBoxTelefono;
        private System.Windows.Forms.Label EtiquetaPuntos;
        private System.Windows.Forms.Label EtiquetaPromociones;
        private System.Windows.Forms.Label EtiquetaTelefono;
        private System.Windows.Forms.Label EtiquetaNombre;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.DataGridView Datos;
        private System.Windows.Forms.Button Elimina;
        private System.Windows.Forms.Button Actualiza;
        private System.Windows.Forms.Button Alta;
        private System.Windows.Forms.ComboBox comboBoxPromociones;
    }
}