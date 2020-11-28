namespace Cine
{
    partial class FormAsiento
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
            this.comboBoxEstado = new System.Windows.Forms.ComboBox();
            this.comboBoxIdSala = new System.Windows.Forms.ComboBox();
            this.EtiquetaIdSala = new System.Windows.Forms.Label();
            this.Elimina = new System.Windows.Forms.Button();
            this.Actualiza = new System.Windows.Forms.Button();
            this.Alta = new System.Windows.Forms.Button();
            this.Datos = new System.Windows.Forms.DataGridView();
            this.EtiquetaEstado = new System.Windows.Forms.Label();
            this.labelFila = new System.Windows.Forms.Label();
            this.textBoxFila = new System.Windows.Forms.TextBox();
            this.textBoxNumero = new System.Windows.Forms.TextBox();
            this.labelNumero = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Datos)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxEstado
            // 
            this.comboBoxEstado.FormattingEnabled = true;
            this.comboBoxEstado.Items.AddRange(new object[] {
            "True",
            "False"});
            this.comboBoxEstado.Location = new System.Drawing.Point(119, 48);
            this.comboBoxEstado.Name = "comboBoxEstado";
            this.comboBoxEstado.Size = new System.Drawing.Size(56, 21);
            this.comboBoxEstado.TabIndex = 74;
            // 
            // comboBoxIdSala
            // 
            this.comboBoxIdSala.FormattingEnabled = true;
            this.comboBoxIdSala.Items.AddRange(new object[] {
            "10",
            "15",
            "20"});
            this.comboBoxIdSala.Location = new System.Drawing.Point(75, 11);
            this.comboBoxIdSala.Name = "comboBoxIdSala";
            this.comboBoxIdSala.Size = new System.Drawing.Size(100, 21);
            this.comboBoxIdSala.TabIndex = 73;
            // 
            // EtiquetaIdSala
            // 
            this.EtiquetaIdSala.AutoSize = true;
            this.EtiquetaIdSala.Location = new System.Drawing.Point(29, 13);
            this.EtiquetaIdSala.Name = "EtiquetaIdSala";
            this.EtiquetaIdSala.Size = new System.Drawing.Size(40, 13);
            this.EtiquetaIdSala.TabIndex = 72;
            this.EtiquetaIdSala.Text = "IdSala:";
            // 
            // Elimina
            // 
            this.Elimina.Location = new System.Drawing.Point(670, 82);
            this.Elimina.Name = "Elimina";
            this.Elimina.Size = new System.Drawing.Size(75, 23);
            this.Elimina.TabIndex = 71;
            this.Elimina.Text = "Elimina";
            this.Elimina.UseVisualStyleBackColor = true;
            this.Elimina.Click += new System.EventHandler(this.Elimina_Click);
            // 
            // Actualiza
            // 
            this.Actualiza.Location = new System.Drawing.Point(670, 48);
            this.Actualiza.Name = "Actualiza";
            this.Actualiza.Size = new System.Drawing.Size(75, 23);
            this.Actualiza.TabIndex = 70;
            this.Actualiza.Text = "Actualiza";
            this.Actualiza.UseVisualStyleBackColor = true;
            this.Actualiza.Click += new System.EventHandler(this.Actualiza_Click);
            // 
            // Alta
            // 
            this.Alta.Location = new System.Drawing.Point(670, 11);
            this.Alta.Name = "Alta";
            this.Alta.Size = new System.Drawing.Size(75, 23);
            this.Alta.TabIndex = 69;
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
            this.Datos.TabIndex = 68;
            this.Datos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Datos_CellClick);
            // 
            // EtiquetaEstado
            // 
            this.EtiquetaEstado.Location = new System.Drawing.Point(29, 51);
            this.EtiquetaEstado.Name = "EtiquetaEstado";
            this.EtiquetaEstado.Size = new System.Drawing.Size(49, 13);
            this.EtiquetaEstado.TabIndex = 67;
            this.EtiquetaEstado.Text = "Estado:";
            // 
            // labelFila
            // 
            this.labelFila.Location = new System.Drawing.Point(29, 92);
            this.labelFila.Name = "labelFila";
            this.labelFila.Size = new System.Drawing.Size(40, 13);
            this.labelFila.TabIndex = 75;
            this.labelFila.Text = "Fila:";
            // 
            // textBoxFila
            // 
            this.textBoxFila.Location = new System.Drawing.Point(75, 89);
            this.textBoxFila.Name = "textBoxFila";
            this.textBoxFila.Size = new System.Drawing.Size(100, 20);
            this.textBoxFila.TabIndex = 76;
            // 
            // textBoxNumero
            // 
            this.textBoxNumero.Location = new System.Drawing.Point(243, 12);
            this.textBoxNumero.Name = "textBoxNumero";
            this.textBoxNumero.Size = new System.Drawing.Size(40, 20);
            this.textBoxNumero.TabIndex = 78;
            // 
            // labelNumero
            // 
            this.labelNumero.Location = new System.Drawing.Point(190, 13);
            this.labelNumero.Name = "labelNumero";
            this.labelNumero.Size = new System.Drawing.Size(47, 13);
            this.labelNumero.TabIndex = 77;
            this.labelNumero.Text = "Numero:";
            // 
            // FormAsiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 394);
            this.Controls.Add(this.textBoxNumero);
            this.Controls.Add(this.labelNumero);
            this.Controls.Add(this.textBoxFila);
            this.Controls.Add(this.labelFila);
            this.Controls.Add(this.comboBoxEstado);
            this.Controls.Add(this.comboBoxIdSala);
            this.Controls.Add(this.EtiquetaIdSala);
            this.Controls.Add(this.Elimina);
            this.Controls.Add(this.Actualiza);
            this.Controls.Add(this.Alta);
            this.Controls.Add(this.Datos);
            this.Controls.Add(this.EtiquetaEstado);
            this.Name = "FormAsiento";
            this.Text = "FormAsiento";
            ((System.ComponentModel.ISupportInitialize)(this.Datos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxEstado;
        private System.Windows.Forms.ComboBox comboBoxIdSala;
        private System.Windows.Forms.Label EtiquetaIdSala;
        private System.Windows.Forms.Button Elimina;
        private System.Windows.Forms.Button Actualiza;
        private System.Windows.Forms.Button Alta;
        private System.Windows.Forms.DataGridView Datos;
        private System.Windows.Forms.Label EtiquetaEstado;
        private System.Windows.Forms.Label labelFila;
        private System.Windows.Forms.TextBox textBoxFila;
        private System.Windows.Forms.TextBox textBoxNumero;
        private System.Windows.Forms.Label labelNumero;
    }
}