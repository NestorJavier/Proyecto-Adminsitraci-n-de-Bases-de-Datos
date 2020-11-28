namespace Cine
{
    partial class FormSala
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
            this.comboBoxIdSucursal = new System.Windows.Forms.ComboBox();
            this.Elimina = new System.Windows.Forms.Button();
            this.Actualiza = new System.Windows.Forms.Button();
            this.Alta = new System.Windows.Forms.Button();
            this.Datos = new System.Windows.Forms.DataGridView();
            this.textBoxCupoTotal = new System.Windows.Forms.TextBox();
            this.EtiquetaCupoTotal = new System.Windows.Forms.Label();
            this.EtiquetaIdSucursal = new System.Windows.Forms.Label();
            this.EtiquetaNumero = new System.Windows.Forms.Label();
            this.textBoxNumero = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Datos)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxIdSucursal
            // 
            this.comboBoxIdSucursal.FormattingEnabled = true;
            this.comboBoxIdSucursal.Items.AddRange(new object[] {
            "10",
            "15",
            "20"});
            this.comboBoxIdSucursal.Location = new System.Drawing.Point(89, 16);
            this.comboBoxIdSucursal.Name = "comboBoxIdSucursal";
            this.comboBoxIdSucursal.Size = new System.Drawing.Size(100, 21);
            this.comboBoxIdSucursal.TabIndex = 43;
            // 
            // Elimina
            // 
            this.Elimina.Location = new System.Drawing.Point(664, 82);
            this.Elimina.Name = "Elimina";
            this.Elimina.Size = new System.Drawing.Size(75, 23);
            this.Elimina.TabIndex = 42;
            this.Elimina.Text = "Elimina";
            this.Elimina.UseVisualStyleBackColor = true;
            this.Elimina.Click += new System.EventHandler(this.Elimina_Click);
            // 
            // Actualiza
            // 
            this.Actualiza.Location = new System.Drawing.Point(664, 48);
            this.Actualiza.Name = "Actualiza";
            this.Actualiza.Size = new System.Drawing.Size(75, 23);
            this.Actualiza.TabIndex = 41;
            this.Actualiza.Text = "Actualiza";
            this.Actualiza.UseVisualStyleBackColor = true;
            this.Actualiza.Click += new System.EventHandler(this.Actualiza_Click);
            // 
            // Alta
            // 
            this.Alta.Location = new System.Drawing.Point(664, 11);
            this.Alta.Name = "Alta";
            this.Alta.Size = new System.Drawing.Size(75, 23);
            this.Alta.TabIndex = 40;
            this.Alta.Text = "Alta";
            this.Alta.UseVisualStyleBackColor = true;
            this.Alta.Click += new System.EventHandler(this.Alta_Click);
            // 
            // Datos
            // 
            this.Datos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Datos.Location = new System.Drawing.Point(26, 117);
            this.Datos.Name = "Datos";
            this.Datos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Datos.Size = new System.Drawing.Size(713, 267);
            this.Datos.TabIndex = 39;
            this.Datos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Datos_CellClick);
            // 
            // textBoxCupoTotal
            // 
            this.textBoxCupoTotal.Location = new System.Drawing.Point(278, 17);
            this.textBoxCupoTotal.Name = "textBoxCupoTotal";
            this.textBoxCupoTotal.Size = new System.Drawing.Size(100, 20);
            this.textBoxCupoTotal.TabIndex = 38;
            // 
            // EtiquetaCupoTotal
            // 
            this.EtiquetaCupoTotal.Location = new System.Drawing.Point(209, 17);
            this.EtiquetaCupoTotal.Name = "EtiquetaCupoTotal";
            this.EtiquetaCupoTotal.Size = new System.Drawing.Size(63, 13);
            this.EtiquetaCupoTotal.TabIndex = 37;
            this.EtiquetaCupoTotal.Text = "CupoTotal:";
            // 
            // EtiquetaIdSucursal
            // 
            this.EtiquetaIdSucursal.AutoSize = true;
            this.EtiquetaIdSucursal.Location = new System.Drawing.Point(12, 16);
            this.EtiquetaIdSucursal.Name = "EtiquetaIdSucursal";
            this.EtiquetaIdSucursal.Size = new System.Drawing.Size(60, 13);
            this.EtiquetaIdSucursal.TabIndex = 36;
            this.EtiquetaIdSucursal.Text = "IdSucursal:";
            // 
            // EtiquetaNumero
            // 
            this.EtiquetaNumero.AutoSize = true;
            this.EtiquetaNumero.Location = new System.Drawing.Point(12, 58);
            this.EtiquetaNumero.Name = "EtiquetaNumero";
            this.EtiquetaNumero.Size = new System.Drawing.Size(47, 13);
            this.EtiquetaNumero.TabIndex = 35;
            this.EtiquetaNumero.Text = "Numero:";
            // 
            // textBoxNumero
            // 
            this.textBoxNumero.Location = new System.Drawing.Point(89, 58);
            this.textBoxNumero.Name = "textBoxNumero";
            this.textBoxNumero.Size = new System.Drawing.Size(100, 20);
            this.textBoxNumero.TabIndex = 34;
            // 
            // FormSala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 394);
            this.Controls.Add(this.comboBoxIdSucursal);
            this.Controls.Add(this.Elimina);
            this.Controls.Add(this.Actualiza);
            this.Controls.Add(this.Alta);
            this.Controls.Add(this.Datos);
            this.Controls.Add(this.textBoxCupoTotal);
            this.Controls.Add(this.EtiquetaCupoTotal);
            this.Controls.Add(this.EtiquetaIdSucursal);
            this.Controls.Add(this.EtiquetaNumero);
            this.Controls.Add(this.textBoxNumero);
            this.Name = "FormSala";
            this.Text = "Sala";
            ((System.ComponentModel.ISupportInitialize)(this.Datos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxIdSucursal;
        private System.Windows.Forms.Button Elimina;
        private System.Windows.Forms.Button Actualiza;
        private System.Windows.Forms.Button Alta;
        private System.Windows.Forms.DataGridView Datos;
        private System.Windows.Forms.TextBox textBoxCupoTotal;
        private System.Windows.Forms.Label EtiquetaCupoTotal;
        private System.Windows.Forms.Label EtiquetaIdSucursal;
        private System.Windows.Forms.Label EtiquetaNumero;
        private System.Windows.Forms.TextBox textBoxNumero;
    }
}