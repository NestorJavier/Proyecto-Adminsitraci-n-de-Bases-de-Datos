namespace Cine
{
    partial class FormVenta
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
            this.comboBoxIdFuncion = new System.Windows.Forms.ComboBox();
            this.Elimina = new System.Windows.Forms.Button();
            this.Actualiza = new System.Windows.Forms.Button();
            this.Alta = new System.Windows.Forms.Button();
            this.Datos = new System.Windows.Forms.DataGridView();
            this.textBoxHora = new System.Windows.Forms.TextBox();
            this.EtiquetaHora = new System.Windows.Forms.Label();
            this.EtiquetaIdFuncion = new System.Windows.Forms.Label();
            this.EtiquetaTotal = new System.Windows.Forms.Label();
            this.textBoxTotal = new System.Windows.Forms.TextBox();
            this.comboBoxIdMiembro = new System.Windows.Forms.ComboBox();
            this.EtiquetaIdMiembro = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Datos)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxIdFuncion
            // 
            this.comboBoxIdFuncion.FormattingEnabled = true;
            this.comboBoxIdFuncion.Items.AddRange(new object[] {
            "10",
            "15",
            "20"});
            this.comboBoxIdFuncion.Location = new System.Drawing.Point(95, 16);
            this.comboBoxIdFuncion.Name = "comboBoxIdFuncion";
            this.comboBoxIdFuncion.Size = new System.Drawing.Size(100, 21);
            this.comboBoxIdFuncion.TabIndex = 53;
            // 
            // Elimina
            // 
            this.Elimina.Location = new System.Drawing.Point(670, 82);
            this.Elimina.Name = "Elimina";
            this.Elimina.Size = new System.Drawing.Size(75, 23);
            this.Elimina.TabIndex = 52;
            this.Elimina.Text = "Elimina";
            this.Elimina.UseVisualStyleBackColor = true;
            this.Elimina.Click += new System.EventHandler(this.Elimina_Click);
            // 
            // Actualiza
            // 
            this.Actualiza.Location = new System.Drawing.Point(670, 48);
            this.Actualiza.Name = "Actualiza";
            this.Actualiza.Size = new System.Drawing.Size(75, 23);
            this.Actualiza.TabIndex = 51;
            this.Actualiza.Text = "Actualiza";
            this.Actualiza.UseVisualStyleBackColor = true;
            this.Actualiza.Click += new System.EventHandler(this.Actualiza_Click);
            // 
            // Alta
            // 
            this.Alta.Location = new System.Drawing.Point(670, 11);
            this.Alta.Name = "Alta";
            this.Alta.Size = new System.Drawing.Size(75, 23);
            this.Alta.TabIndex = 50;
            this.Alta.Text = "Alta";
            this.Alta.UseVisualStyleBackColor = true;
            this.Alta.Click += new System.EventHandler(this.Alta_Click);
            // 
            // Datos
            // 
            this.Datos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Datos.Location = new System.Drawing.Point(32, 117);
            this.Datos.Name = "Datos";
            this.Datos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Datos.Size = new System.Drawing.Size(713, 267);
            this.Datos.TabIndex = 49;
            this.Datos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Datos_CellClick);
            // 
            // textBoxHora
            // 
            this.textBoxHora.Location = new System.Drawing.Point(284, 17);
            this.textBoxHora.Name = "textBoxHora";
            this.textBoxHora.Size = new System.Drawing.Size(100, 20);
            this.textBoxHora.TabIndex = 48;
            // 
            // EtiquetaHora
            // 
            this.EtiquetaHora.Location = new System.Drawing.Point(215, 17);
            this.EtiquetaHora.Name = "EtiquetaHora";
            this.EtiquetaHora.Size = new System.Drawing.Size(63, 13);
            this.EtiquetaHora.TabIndex = 47;
            this.EtiquetaHora.Text = "Hora:";
            // 
            // EtiquetaIdFuncion
            // 
            this.EtiquetaIdFuncion.AutoSize = true;
            this.EtiquetaIdFuncion.Location = new System.Drawing.Point(18, 16);
            this.EtiquetaIdFuncion.Name = "EtiquetaIdFuncion";
            this.EtiquetaIdFuncion.Size = new System.Drawing.Size(57, 13);
            this.EtiquetaIdFuncion.TabIndex = 46;
            this.EtiquetaIdFuncion.Text = "IdFunción:";
            // 
            // EtiquetaTotal
            // 
            this.EtiquetaTotal.AutoSize = true;
            this.EtiquetaTotal.Location = new System.Drawing.Point(215, 62);
            this.EtiquetaTotal.Name = "EtiquetaTotal";
            this.EtiquetaTotal.Size = new System.Drawing.Size(34, 13);
            this.EtiquetaTotal.TabIndex = 45;
            this.EtiquetaTotal.Text = "Total:";
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.Location = new System.Drawing.Point(284, 62);
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.Size = new System.Drawing.Size(100, 20);
            this.textBoxTotal.TabIndex = 44;
            // 
            // comboBoxIdMiembro
            // 
            this.comboBoxIdMiembro.FormattingEnabled = true;
            this.comboBoxIdMiembro.Items.AddRange(new object[] {
            "10",
            "15",
            "20"});
            this.comboBoxIdMiembro.Location = new System.Drawing.Point(95, 61);
            this.comboBoxIdMiembro.Name = "comboBoxIdMiembro";
            this.comboBoxIdMiembro.Size = new System.Drawing.Size(100, 21);
            this.comboBoxIdMiembro.TabIndex = 55;
            // 
            // EtiquetaIdMiembro
            // 
            this.EtiquetaIdMiembro.AutoSize = true;
            this.EtiquetaIdMiembro.Location = new System.Drawing.Point(18, 61);
            this.EtiquetaIdMiembro.Name = "EtiquetaIdMiembro";
            this.EtiquetaIdMiembro.Size = new System.Drawing.Size(59, 13);
            this.EtiquetaIdMiembro.TabIndex = 54;
            this.EtiquetaIdMiembro.Text = "IdMiembro:";
            // 
            // FormVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 394);
            this.Controls.Add(this.comboBoxIdMiembro);
            this.Controls.Add(this.EtiquetaIdMiembro);
            this.Controls.Add(this.comboBoxIdFuncion);
            this.Controls.Add(this.Elimina);
            this.Controls.Add(this.Actualiza);
            this.Controls.Add(this.Alta);
            this.Controls.Add(this.Datos);
            this.Controls.Add(this.textBoxHora);
            this.Controls.Add(this.EtiquetaHora);
            this.Controls.Add(this.EtiquetaIdFuncion);
            this.Controls.Add(this.EtiquetaTotal);
            this.Controls.Add(this.textBoxTotal);
            this.Name = "FormVenta";
            this.Text = "FormVenta";
            ((System.ComponentModel.ISupportInitialize)(this.Datos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxIdFuncion;
        private System.Windows.Forms.Button Elimina;
        private System.Windows.Forms.Button Actualiza;
        private System.Windows.Forms.Button Alta;
        private System.Windows.Forms.DataGridView Datos;
        private System.Windows.Forms.TextBox textBoxHora;
        private System.Windows.Forms.Label EtiquetaHora;
        private System.Windows.Forms.Label EtiquetaIdFuncion;
        private System.Windows.Forms.Label EtiquetaTotal;
        private System.Windows.Forms.TextBox textBoxTotal;
        private System.Windows.Forms.ComboBox comboBoxIdMiembro;
        private System.Windows.Forms.Label EtiquetaIdMiembro;
    }
}