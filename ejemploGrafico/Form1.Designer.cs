namespace ejemploGrafico
{
    partial class Form1
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
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.monthCalFecha = new System.Windows.Forms.MonthCalendar();
            this.btnPrueba1 = new System.Windows.Forms.Button();
            this.btnPrueba2 = new System.Windows.Forms.Button();
            this.lblEvento = new System.Windows.Forms.Label();
            this.txtbPrueba = new System.Windows.Forms.TextBox();
            this.txtb2Prueba = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(90, 33);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 20);
            this.dtpFecha.TabIndex = 0;
            // 
            // monthCalFecha
            // 
            this.monthCalFecha.Location = new System.Drawing.Point(90, 84);
            this.monthCalFecha.Name = "monthCalFecha";
            this.monthCalFecha.TabIndex = 1;
            // 
            // btnPrueba1
            // 
            this.btnPrueba1.Location = new System.Drawing.Point(406, 84);
            this.btnPrueba1.Name = "btnPrueba1";
            this.btnPrueba1.Size = new System.Drawing.Size(75, 23);
            this.btnPrueba1.TabIndex = 2;
            this.btnPrueba1.Text = "Prueba 1";
            this.btnPrueba1.UseVisualStyleBackColor = true;
            this.btnPrueba1.Click += new System.EventHandler(this.btnPrueba1_Click);
            // 
            // btnPrueba2
            // 
            this.btnPrueba2.Location = new System.Drawing.Point(406, 136);
            this.btnPrueba2.Name = "btnPrueba2";
            this.btnPrueba2.Size = new System.Drawing.Size(75, 23);
            this.btnPrueba2.TabIndex = 3;
            this.btnPrueba2.Text = "Prueba 2";
            this.btnPrueba2.UseVisualStyleBackColor = true;
            this.btnPrueba2.Click += new System.EventHandler(this.btnPrueba2_Click);
            // 
            // lblEvento
            // 
            this.lblEvento.AutoSize = true;
            this.lblEvento.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEvento.Font = new System.Drawing.Font("Broadway", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEvento.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblEvento.Location = new System.Drawing.Point(403, 53);
            this.lblEvento.Name = "lblEvento";
            this.lblEvento.Size = new System.Drawing.Size(111, 18);
            this.lblEvento.TabIndex = 4;
            this.lblEvento.Text = "Label prueba";
            this.lblEvento.MouseLeave += new System.EventHandler(this.lblEvento_MouseLeave);
            this.lblEvento.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblEvento_MouseMove);
            // 
            // txtbPrueba
            // 
            this.txtbPrueba.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtbPrueba.Location = new System.Drawing.Point(406, 179);
            this.txtbPrueba.MaxLength = 30;
            this.txtbPrueba.Name = "txtbPrueba";
            this.txtbPrueba.Size = new System.Drawing.Size(100, 20);
            this.txtbPrueba.TabIndex = 5;
            this.txtbPrueba.TextChanged += new System.EventHandler(this.txtbPrueba_TextChanged);
            this.txtbPrueba.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbPrueba_KeyPress);
            // 
            // txtb2Prueba
            // 
            this.txtb2Prueba.Location = new System.Drawing.Point(406, 215);
            this.txtb2Prueba.Multiline = true;
            this.txtb2Prueba.Name = "txtb2Prueba";
            this.txtb2Prueba.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtb2Prueba.Size = new System.Drawing.Size(100, 31);
            this.txtb2Prueba.TabIndex = 6;
            this.txtb2Prueba.Leave += new System.EventHandler(this.txtb2Prueba_Leave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 328);
            this.Controls.Add(this.txtb2Prueba);
            this.Controls.Add(this.txtbPrueba);
            this.Controls.Add(this.lblEvento);
            this.Controls.Add(this.btnPrueba2);
            this.Controls.Add(this.btnPrueba1);
            this.Controls.Add(this.monthCalFecha);
            this.Controls.Add(this.dtpFecha);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.MonthCalendar monthCalFecha;
        private System.Windows.Forms.Button btnPrueba1;
        private System.Windows.Forms.Button btnPrueba2;
        private System.Windows.Forms.Label lblEvento;
        private System.Windows.Forms.TextBox txtbPrueba;
        private System.Windows.Forms.TextBox txtb2Prueba;
    }
}

