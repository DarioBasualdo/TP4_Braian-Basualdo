namespace FrondEnd
{
    partial class Menu
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
            this.btActualizar = new System.Windows.Forms.Button();
            this.btBorrar = new System.Windows.Forms.Button();
            this.btVer = new System.Windows.Forms.Button();
            this.btSalir = new System.Windows.Forms.Button();
            this.btCargar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btActualizar
            // 
            this.btActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(198)))), ((int)(((byte)(234)))));
            this.btActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btActualizar.Font = new System.Drawing.Font("Cooper Black", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btActualizar.Location = new System.Drawing.Point(12, 106);
            this.btActualizar.Name = "btActualizar";
            this.btActualizar.Size = new System.Drawing.Size(445, 53);
            this.btActualizar.TabIndex = 2;
            this.btActualizar.Text = "ACTUALIZAR";
            this.btActualizar.UseVisualStyleBackColor = false;
            this.btActualizar.Click += new System.EventHandler(this.btActualizar_Click);
            // 
            // btBorrar
            // 
            this.btBorrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(198)))), ((int)(((byte)(234)))));
            this.btBorrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btBorrar.Font = new System.Drawing.Font("Cooper Black", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBorrar.Location = new System.Drawing.Point(12, 185);
            this.btBorrar.Name = "btBorrar";
            this.btBorrar.Size = new System.Drawing.Size(445, 53);
            this.btBorrar.TabIndex = 3;
            this.btBorrar.Text = "BORRAR";
            this.btBorrar.UseVisualStyleBackColor = false;
            this.btBorrar.Click += new System.EventHandler(this.btBorrar_Click);
            // 
            // btVer
            // 
            this.btVer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(198)))), ((int)(((byte)(234)))));
            this.btVer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btVer.Font = new System.Drawing.Font("Cooper Black", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVer.Location = new System.Drawing.Point(12, 265);
            this.btVer.Name = "btVer";
            this.btVer.Size = new System.Drawing.Size(445, 53);
            this.btVer.TabIndex = 4;
            this.btVer.Text = "VER";
            this.btVer.UseVisualStyleBackColor = false;
            this.btVer.Click += new System.EventHandler(this.btVer_Click);
            // 
            // btSalir
            // 
            this.btSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSalir.Font = new System.Drawing.Font("Cooper Black", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSalir.Location = new System.Drawing.Point(357, 382);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(100, 46);
            this.btSalir.TabIndex = 5;
            this.btSalir.Text = "SALIR";
            this.btSalir.UseVisualStyleBackColor = false;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // btCargar
            // 
            this.btCargar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(198)))), ((int)(((byte)(234)))));
            this.btCargar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCargar.Font = new System.Drawing.Font("Cooper Black", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCargar.Location = new System.Drawing.Point(12, 25);
            this.btCargar.Name = "btCargar";
            this.btCargar.Size = new System.Drawing.Size(445, 53);
            this.btCargar.TabIndex = 1;
            this.btCargar.Text = "CARGAR";
            this.btCargar.UseVisualStyleBackColor = false;
            this.btCargar.Click += new System.EventHandler(this.btCargar_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(240)))), ((int)(((byte)(234)))));
            this.ClientSize = new System.Drawing.Size(469, 440);
            this.Controls.Add(this.btCargar);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.btVer);
            this.Controls.Add(this.btBorrar);
            this.Controls.Add(this.btActualizar);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btActualizar;
        private System.Windows.Forms.Button btBorrar;
        private System.Windows.Forms.Button btVer;
        private System.Windows.Forms.Button btSalir;
        private System.Windows.Forms.Button btCargar;
    }
}