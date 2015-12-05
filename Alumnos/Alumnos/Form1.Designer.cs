namespace Alumnos
{
    partial class frmprincipal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnateneo = new System.Windows.Forms.Button();
            this.btnliceo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnateneo
            // 
            this.btnateneo.BackColor = System.Drawing.Color.White;
            this.btnateneo.Image = global::Alumnos.Properties.Resources.ateneo;
            this.btnateneo.Location = new System.Drawing.Point(295, 23);
            this.btnateneo.Name = "btnateneo";
            this.btnateneo.Size = new System.Drawing.Size(250, 179);
            this.btnateneo.TabIndex = 1;
            this.btnateneo.UseVisualStyleBackColor = false;
            this.btnateneo.Click += new System.EventHandler(this.btnateneo_Click);
            // 
            // btnliceo
            // 
            this.btnliceo.BackColor = System.Drawing.Color.White;
            this.btnliceo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnliceo.Image = global::Alumnos.Properties.Resources.liceodeltanuevo___copia;
            this.btnliceo.Location = new System.Drawing.Point(12, 23);
            this.btnliceo.Name = "btnliceo";
            this.btnliceo.Size = new System.Drawing.Size(265, 179);
            this.btnliceo.TabIndex = 0;
            this.btnliceo.UseVisualStyleBackColor = false;
            this.btnliceo.Click += new System.EventHandler(this.btnliceo_Click);
            // 
            // frmprincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(557, 227);
            this.Controls.Add(this.btnateneo);
            this.Controls.Add(this.btnliceo);
            this.Name = "frmprincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnliceo;
        private System.Windows.Forms.Button btnateneo;
    }
}

