namespace FrondEnd
{
    partial class Inicio
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
            this.btInicio = new System.Windows.Forms.Button();
            this.lbInicio3 = new System.Windows.Forms.Label();
            this.lbInicio = new System.Windows.Forms.Label();
            this.lbInicio2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btInicio
            // 
            this.btInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btInicio.Font = new System.Drawing.Font("Cooper Black", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btInicio.Location = new System.Drawing.Point(12, 242);
            this.btInicio.Name = "btInicio";
            this.btInicio.Size = new System.Drawing.Size(377, 58);
            this.btInicio.TabIndex = 0;
            this.btInicio.Text = "INICIAR";
            this.btInicio.UseVisualStyleBackColor = false;
            this.btInicio.Click += new System.EventHandler(this.btInicio_Click);
            // 
            // lbInicio3
            // 
            this.lbInicio3.AutoSize = true;
            this.lbInicio3.Font = new System.Drawing.Font("Cooper Black", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInicio3.Location = new System.Drawing.Point(71, 99);
            this.lbInicio3.Name = "lbInicio3";
            this.lbInicio3.Size = new System.Drawing.Size(245, 23);
            this.lbInicio3.TabIndex = 1;
            this.lbInicio3.Text = "LA LISTA DE PRECIOS";
            // 
            // lbInicio
            // 
            this.lbInicio.AutoSize = true;
            this.lbInicio.Font = new System.Drawing.Font("Cooper Black", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInicio.Location = new System.Drawing.Point(126, 28);
            this.lbInicio.Name = "lbInicio";
            this.lbInicio.Size = new System.Drawing.Size(150, 23);
            this.lbInicio.TabIndex = 2;
            this.lbInicio.Text = "BIENVENIDO";
            // 
            // lbInicio2
            // 
            this.lbInicio2.AutoSize = true;
            this.lbInicio2.Font = new System.Drawing.Font("Cooper Black", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInicio2.Location = new System.Drawing.Point(168, 64);
            this.lbInicio2.Name = "lbInicio2";
            this.lbInicio2.Size = new System.Drawing.Size(27, 23);
            this.lbInicio2.TabIndex = 3;
            this.lbInicio2.Text = "A";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(126, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "DEL SUPER";
            // 
            // Inicio
            // 
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(240)))), ((int)(((byte)(234)))));
            this.ClientSize = new System.Drawing.Size(394, 312);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbInicio2);
            this.Controls.Add(this.lbInicio);
            this.Controls.Add(this.lbInicio3);
            this.Controls.Add(this.btInicio);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LaListaDelSuper";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btInicio;
        private System.Windows.Forms.Label lbInicio3;
        private System.Windows.Forms.Label lbInicio;
        private System.Windows.Forms.Label lbInicio2;
        private System.Windows.Forms.Label label1;
    }
}

