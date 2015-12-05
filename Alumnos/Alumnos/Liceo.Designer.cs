namespace Alumnos
{
    partial class Liceo
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
            this.lblnombrebach = new System.Windows.Forms.Label();
            this.btninscripciones = new System.Windows.Forms.Button();
            this.btnboletas = new System.Windows.Forms.Button();
            this.btncredenciales = new System.Windows.Forms.Button();
            this.btnlistas = new System.Windows.Forms.Button();
            this.btnrecibos = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblnombrebach
            // 
            this.lblnombrebach.AutoSize = true;
            this.lblnombrebach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombrebach.Location = new System.Drawing.Point(97, 10);
            this.lblnombrebach.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblnombrebach.Name = "lblnombrebach";
            this.lblnombrebach.Size = new System.Drawing.Size(176, 20);
            this.lblnombrebach.TabIndex = 2;
            this.lblnombrebach.Text = "Bachillerato Liceo Delta";
            // 
            // btninscripciones
            // 
            this.btninscripciones.AutoSize = true;
            this.btninscripciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninscripciones.Location = new System.Drawing.Point(12, 167);
            this.btninscripciones.Name = "btninscripciones";
            this.btninscripciones.Size = new System.Drawing.Size(148, 35);
            this.btninscripciones.TabIndex = 3;
            this.btninscripciones.Text = "Inscripciones";
            this.btninscripciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btninscripciones.UseVisualStyleBackColor = true;
            this.btninscripciones.Click += new System.EventHandler(this.btninscripciones_Click);
            // 
            // btnboletas
            // 
            this.btnboletas.AutoSize = true;
            this.btnboletas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnboletas.Location = new System.Drawing.Point(12, 208);
            this.btnboletas.Name = "btnboletas";
            this.btnboletas.Size = new System.Drawing.Size(94, 35);
            this.btnboletas.TabIndex = 4;
            this.btnboletas.Text = "Boletas";
            this.btnboletas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnboletas.UseVisualStyleBackColor = true;
            this.btnboletas.Click += new System.EventHandler(this.btnboletas_Click);
            // 
            // btncredenciales
            // 
            this.btncredenciales.AutoSize = true;
            this.btncredenciales.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncredenciales.Location = new System.Drawing.Point(12, 290);
            this.btncredenciales.Name = "btncredenciales";
            this.btncredenciales.Size = new System.Drawing.Size(148, 35);
            this.btncredenciales.TabIndex = 5;
            this.btncredenciales.Text = "Credenciales";
            this.btncredenciales.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncredenciales.UseVisualStyleBackColor = true;
            this.btncredenciales.Click += new System.EventHandler(this.btncredenciales_Click);
            // 
            // btnlistas
            // 
            this.btnlistas.AutoSize = true;
            this.btnlistas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlistas.Location = new System.Drawing.Point(12, 331);
            this.btnlistas.Name = "btnlistas";
            this.btnlistas.Size = new System.Drawing.Size(214, 35);
            this.btnlistas.TabIndex = 6;
            this.btnlistas.Text = "Listas de Asistencia";
            this.btnlistas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnlistas.UseVisualStyleBackColor = true;
            this.btnlistas.Click += new System.EventHandler(this.btnlistas_Click);
            // 
            // btnrecibos
            // 
            this.btnrecibos.AutoSize = true;
            this.btnrecibos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrecibos.Location = new System.Drawing.Point(12, 249);
            this.btnrecibos.Name = "btnrecibos";
            this.btnrecibos.Size = new System.Drawing.Size(100, 35);
            this.btnrecibos.TabIndex = 7;
            this.btnrecibos.Text = "Recibos";
            this.btnrecibos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnrecibos.UseVisualStyleBackColor = true;
            this.btnrecibos.Click += new System.EventHandler(this.btnrecibos_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Alumnos.Properties.Resources.liceodeltanuevo;
            this.pictureBox1.Location = new System.Drawing.Point(27, 36);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(315, 122);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(11, 372);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(215, 35);
            this.button1.TabIndex = 8;
            this.button1.Text = "Numeros de cuenta";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Liceo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 426);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnrecibos);
            this.Controls.Add(this.btnlistas);
            this.Controls.Add(this.btncredenciales);
            this.Controls.Add(this.btnboletas);
            this.Controls.Add(this.btninscripciones);
            this.Controls.Add(this.lblnombrebach);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Liceo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bachillerato Liceo Delta";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblnombrebach;
        private System.Windows.Forms.Button btninscripciones;
        private System.Windows.Forms.Button btnboletas;
        private System.Windows.Forms.Button btncredenciales;
        private System.Windows.Forms.Button btnlistas;
        private System.Windows.Forms.Button btnrecibos;
        private System.Windows.Forms.Button button1;
    }
}