namespace Cine
{
    partial class FormFuncion
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
            this.comboBoxIdSala = new System.Windows.Forms.ComboBox();
            this.EtiquetaIdSala = new System.Windows.Forms.Label();
            this.comboBoxIdPelicula = new System.Windows.Forms.ComboBox();
            this.Elimina = new System.Windows.Forms.Button();
            this.Actualiza = new System.Windows.Forms.Button();
            this.Alta = new System.Windows.Forms.Button();
            this.Datos = new System.Windows.Forms.DataGridView();
            this.EtiquetaDisponibilidad = new System.Windows.Forms.Label();
            this.EtiquetaIdPelicula = new System.Windows.Forms.Label();
            this.comboBoxDisponibilidad = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.Datos)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxIdSala
            // 
            this.comboBoxIdSala.FormattingEnabled = true;
            this.comboBoxIdSala.Items.AddRange(new object[] {
            "10",
            "15",
            "20"});
            this.comboBoxIdSala.Location = new System.Drawing.Point(95, 61);
            this.comboBoxIdSala.Name = "comboBoxIdSala";
            this.comboBoxIdSala.Size = new System.Drawing.Size(100, 21);
            this.comboBoxIdSala.TabIndex = 65;
            // 
            // EtiquetaIdSala
            // 
            this.EtiquetaIdSala.AutoSize = true;
            this.EtiquetaIdSala.Location = new System.Drawing.Point(18, 61);
            this.EtiquetaIdSala.Name = "EtiquetaIdSala";
            this.EtiquetaIdSala.Size = new System.Drawing.Size(40, 13);
            this.EtiquetaIdSala.TabIndex = 64;
            this.EtiquetaIdSala.Text = "IdSala:";
            // 
            // comboBoxIdPelicula
            // 
            this.comboBoxIdPelicula.FormattingEnabled = true;
            this.comboBoxIdPelicula.Items.AddRange(new object[] {
            "10",
            "15",
            "20"});
            this.comboBoxIdPelicula.Location = new System.Drawing.Point(95, 16);
            this.comboBoxIdPelicula.Name = "comboBoxIdPelicula";
            this.comboBoxIdPelicula.Size = new System.Drawing.Size(100, 21);
            this.comboBoxIdPelicula.TabIndex = 63;
            // 
            // Elimina
            // 
            this.Elimina.Location = new System.Drawing.Point(670, 82);
            this.Elimina.Name = "Elimina";
            this.Elimina.Size = new System.Drawing.Size(75, 23);
            this.Elimina.TabIndex = 62;
            this.Elimina.Text = "Elimina";
            this.Elimina.UseVisualStyleBackColor = true;
            this.Elimina.Click += new System.EventHandler(this.Elimina_Click);
            // 
            // Actualiza
            // 
            this.Actualiza.Location = new System.Drawing.Point(670, 48);
            this.Actualiza.Name = "Actualiza";
            this.Actualiza.Size = new System.Drawing.Size(75, 23);
            this.Actualiza.TabIndex = 61;
            this.Actualiza.Text = "Actualiza";
            this.Actualiza.UseVisualStyleBackColor = true;
            this.Actualiza.Click += new System.EventHandler(this.Actualiza_Click);
            // 
            // Alta
            // 
            this.Alta.Location = new System.Drawing.Point(670, 11);
            this.Alta.Name = "Alta";
            this.Alta.Size = new System.Drawing.Size(75, 23);
            this.Alta.TabIndex = 60;
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
            this.Datos.TabIndex = 59;
            this.Datos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Datos_CellClick);
            // 
            // EtiquetaDisponibilidad
            // 
            this.EtiquetaDisponibilidad.Location = new System.Drawing.Point(215, 17);
            this.EtiquetaDisponibilidad.Name = "EtiquetaDisponibilidad";
            this.EtiquetaDisponibilidad.Size = new System.Drawing.Size(82, 13);
            this.EtiquetaDisponibilidad.TabIndex = 57;
            this.EtiquetaDisponibilidad.Text = "Disponibilidad:";
            // 
            // EtiquetaIdPelicula
            // 
            this.EtiquetaIdPelicula.AutoSize = true;
            this.EtiquetaIdPelicula.Location = new System.Drawing.Point(18, 16);
            this.EtiquetaIdPelicula.Name = "EtiquetaIdPelicula";
            this.EtiquetaIdPelicula.Size = new System.Drawing.Size(56, 13);
            this.EtiquetaIdPelicula.TabIndex = 56;
            this.EtiquetaIdPelicula.Text = "IdPelicula:";
            // 
            // comboBoxDisponibilidad
            // 
            this.comboBoxDisponibilidad.FormattingEnabled = true;
            this.comboBoxDisponibilidad.Items.AddRange(new object[] {
            "True",
            "False"});
            this.comboBoxDisponibilidad.Location = new System.Drawing.Point(295, 13);
            this.comboBoxDisponibilidad.Name = "comboBoxDisponibilidad";
            this.comboBoxDisponibilidad.Size = new System.Drawing.Size(56, 21);
            this.comboBoxDisponibilidad.TabIndex = 66;
            // 
            // FormFuncion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 394);
            this.Controls.Add(this.comboBoxDisponibilidad);
            this.Controls.Add(this.comboBoxIdSala);
            this.Controls.Add(this.EtiquetaIdSala);
            this.Controls.Add(this.comboBoxIdPelicula);
            this.Controls.Add(this.Elimina);
            this.Controls.Add(this.Actualiza);
            this.Controls.Add(this.Alta);
            this.Controls.Add(this.Datos);
            this.Controls.Add(this.EtiquetaDisponibilidad);
            this.Controls.Add(this.EtiquetaIdPelicula);
            this.Name = "FormFuncion";
            this.Text = "FormFuncion";
            ((System.ComponentModel.ISupportInitialize)(this.Datos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxIdSala;
        private System.Windows.Forms.Label EtiquetaIdSala;
        private System.Windows.Forms.ComboBox comboBoxIdPelicula;
        private System.Windows.Forms.Button Elimina;
        private System.Windows.Forms.Button Actualiza;
        private System.Windows.Forms.Button Alta;
        private System.Windows.Forms.DataGridView Datos;
        private System.Windows.Forms.Label EtiquetaDisponibilidad;
        private System.Windows.Forms.Label EtiquetaIdPelicula;
        private System.Windows.Forms.ComboBox comboBoxDisponibilidad;
    }
}