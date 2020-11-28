namespace Cine
{
    partial class FormPelicula
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
            this.Datos = new System.Windows.Forms.DataGridView();
            this.Alta = new System.Windows.Forms.Button();
            this.Actualiza = new System.Windows.Forms.Button();
            this.Elimina = new System.Windows.Forms.Button();
            this.textBoxTitulo = new System.Windows.Forms.TextBox();
            this.EtiquetaTitulo = new System.Windows.Forms.Label();
            this.EtiquetaDuracion = new System.Windows.Forms.Label();
            this.EtiquetaFechaLlegada = new System.Windows.Forms.Label();
            this.EtiquetaGenero = new System.Windows.Forms.Label();
            this.textBoxDuracion = new System.Windows.Forms.TextBox();
            this.EtiquetaSipnopsis = new System.Windows.Forms.Label();
            this.richTextBoxSipnopsis = new System.Windows.Forms.RichTextBox();
            this.dateTimePickerFechaLlegada = new System.Windows.Forms.DateTimePicker();
            this.comboBoxGenero = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.Datos)).BeginInit();
            this.SuspendLayout();
            // 
            // Datos
            // 
            this.Datos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Datos.Location = new System.Drawing.Point(22, 115);
            this.Datos.Name = "Datos";
            this.Datos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Datos.Size = new System.Drawing.Size(713, 267);
            this.Datos.TabIndex = 10;
            this.Datos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Datos_CellClick);
            // 
            // Alta
            // 
            this.Alta.Location = new System.Drawing.Point(660, 15);
            this.Alta.Name = "Alta";
            this.Alta.Size = new System.Drawing.Size(75, 23);
            this.Alta.TabIndex = 11;
            this.Alta.Text = "Alta";
            this.Alta.UseVisualStyleBackColor = true;
            this.Alta.Click += new System.EventHandler(this.Alta_Click);
            // 
            // Actualiza
            // 
            this.Actualiza.Location = new System.Drawing.Point(660, 52);
            this.Actualiza.Name = "Actualiza";
            this.Actualiza.Size = new System.Drawing.Size(75, 23);
            this.Actualiza.TabIndex = 12;
            this.Actualiza.Text = "Actualiza";
            this.Actualiza.UseVisualStyleBackColor = true;
            this.Actualiza.Click += new System.EventHandler(this.Actualiza_Click);
            // 
            // Elimina
            // 
            this.Elimina.Location = new System.Drawing.Point(660, 86);
            this.Elimina.Name = "Elimina";
            this.Elimina.Size = new System.Drawing.Size(75, 23);
            this.Elimina.TabIndex = 13;
            this.Elimina.Text = "Elimina";
            this.Elimina.UseVisualStyleBackColor = true;
            this.Elimina.Click += new System.EventHandler(this.Elimina_Click);
            // 
            // textBoxTitulo
            // 
            this.textBoxTitulo.Location = new System.Drawing.Point(75, 23);
            this.textBoxTitulo.Name = "textBoxTitulo";
            this.textBoxTitulo.Size = new System.Drawing.Size(100, 20);
            this.textBoxTitulo.TabIndex = 14;
            // 
            // EtiquetaTitulo
            // 
            this.EtiquetaTitulo.AutoSize = true;
            this.EtiquetaTitulo.Location = new System.Drawing.Point(19, 23);
            this.EtiquetaTitulo.Name = "EtiquetaTitulo";
            this.EtiquetaTitulo.Size = new System.Drawing.Size(36, 13);
            this.EtiquetaTitulo.TabIndex = 15;
            this.EtiquetaTitulo.Text = "Titulo:";
            // 
            // EtiquetaDuracion
            // 
            this.EtiquetaDuracion.AutoSize = true;
            this.EtiquetaDuracion.Location = new System.Drawing.Point(19, 74);
            this.EtiquetaDuracion.Name = "EtiquetaDuracion";
            this.EtiquetaDuracion.Size = new System.Drawing.Size(53, 13);
            this.EtiquetaDuracion.TabIndex = 16;
            this.EtiquetaDuracion.Text = "Duración:";
            // 
            // EtiquetaFechaLlegada
            // 
            this.EtiquetaFechaLlegada.AutoSize = true;
            this.EtiquetaFechaLlegada.Location = new System.Drawing.Point(182, 74);
            this.EtiquetaFechaLlegada.Name = "EtiquetaFechaLlegada";
            this.EtiquetaFechaLlegada.Size = new System.Drawing.Size(81, 13);
            this.EtiquetaFechaLlegada.TabIndex = 17;
            this.EtiquetaFechaLlegada.Text = "Fecha Llegada:";
            // 
            // EtiquetaGenero
            // 
            this.EtiquetaGenero.AutoSize = true;
            this.EtiquetaGenero.Location = new System.Drawing.Point(184, 23);
            this.EtiquetaGenero.Name = "EtiquetaGenero";
            this.EtiquetaGenero.Size = new System.Drawing.Size(45, 13);
            this.EtiquetaGenero.TabIndex = 18;
            this.EtiquetaGenero.Text = "Genero:";
            // 
            // textBoxDuracion
            // 
            this.textBoxDuracion.Location = new System.Drawing.Point(75, 74);
            this.textBoxDuracion.Name = "textBoxDuracion";
            this.textBoxDuracion.Size = new System.Drawing.Size(100, 20);
            this.textBoxDuracion.TabIndex = 19;
            // 
            // EtiquetaSipnopsis
            // 
            this.EtiquetaSipnopsis.AutoSize = true;
            this.EtiquetaSipnopsis.Location = new System.Drawing.Point(385, 23);
            this.EtiquetaSipnopsis.Name = "EtiquetaSipnopsis";
            this.EtiquetaSipnopsis.Size = new System.Drawing.Size(55, 13);
            this.EtiquetaSipnopsis.TabIndex = 22;
            this.EtiquetaSipnopsis.Text = "Sipnopsis:";
            // 
            // richTextBoxSipnopsis
            // 
            this.richTextBoxSipnopsis.Location = new System.Drawing.Point(458, 23);
            this.richTextBoxSipnopsis.MaxLength = 500;
            this.richTextBoxSipnopsis.Name = "richTextBoxSipnopsis";
            this.richTextBoxSipnopsis.Size = new System.Drawing.Size(180, 77);
            this.richTextBoxSipnopsis.TabIndex = 23;
            this.richTextBoxSipnopsis.Text = "";
            // 
            // dateTimePickerFechaLlegada
            // 
            this.dateTimePickerFechaLlegada.CustomFormat = "yyyy-MM-dd";
            this.dateTimePickerFechaLlegada.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerFechaLlegada.Location = new System.Drawing.Point(269, 74);
            this.dateTimePickerFechaLlegada.Name = "dateTimePickerFechaLlegada";
            this.dateTimePickerFechaLlegada.Size = new System.Drawing.Size(100, 20);
            this.dateTimePickerFechaLlegada.TabIndex = 24;
            // 
            // comboBoxGenero
            // 
            this.comboBoxGenero.FormattingEnabled = true;
            this.comboBoxGenero.Items.AddRange(new object[] {
            "Romance",
            "Terror",
            "Aventura",
            "Accion",
            "Comedia",
            "Suspenso",
            "Mexicana",
            "Documental",
            "Animada",
            "Familiar"});
            this.comboBoxGenero.Location = new System.Drawing.Point(269, 23);
            this.comboBoxGenero.Name = "comboBoxGenero";
            this.comboBoxGenero.Size = new System.Drawing.Size(100, 21);
            this.comboBoxGenero.TabIndex = 25;
            // 
            // FormPelicula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 394);
            this.Controls.Add(this.comboBoxGenero);
            this.Controls.Add(this.dateTimePickerFechaLlegada);
            this.Controls.Add(this.richTextBoxSipnopsis);
            this.Controls.Add(this.EtiquetaSipnopsis);
            this.Controls.Add(this.textBoxDuracion);
            this.Controls.Add(this.EtiquetaGenero);
            this.Controls.Add(this.EtiquetaFechaLlegada);
            this.Controls.Add(this.EtiquetaDuracion);
            this.Controls.Add(this.EtiquetaTitulo);
            this.Controls.Add(this.textBoxTitulo);
            this.Controls.Add(this.Elimina);
            this.Controls.Add(this.Actualiza);
            this.Controls.Add(this.Alta);
            this.Controls.Add(this.Datos);
            this.Name = "FormPelicula";
            this.Text = "Pelicula";
            ((System.ComponentModel.ISupportInitialize)(this.Datos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Alta;
        private System.Windows.Forms.Button Actualiza;
        private System.Windows.Forms.Button Elimina;
        private System.Windows.Forms.TextBox textBoxTitulo;
        private System.Windows.Forms.Label EtiquetaTitulo;
        private System.Windows.Forms.Label EtiquetaDuracion;
        private System.Windows.Forms.Label EtiquetaFechaLlegada;
        private System.Windows.Forms.Label EtiquetaGenero;
        private System.Windows.Forms.TextBox textBoxDuracion;
        private System.Windows.Forms.Label EtiquetaSipnopsis;
        private System.Windows.Forms.RichTextBox richTextBoxSipnopsis;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaLlegada;
        private System.Windows.Forms.DataGridView Datos;
        private System.Windows.Forms.ComboBox comboBoxGenero;
    }
}