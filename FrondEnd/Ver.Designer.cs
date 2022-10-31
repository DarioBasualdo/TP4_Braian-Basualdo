namespace FrondEnd
{
    partial class Ver
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
            this.btVolver = new System.Windows.Forms.Button();
            this.dtgv_ver = new System.Windows.Forms.DataGridView();
            this.lb_titulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_ver)).BeginInit();
            this.SuspendLayout();
            // 
            // btVolver
            // 
            this.btVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btVolver.Font = new System.Drawing.Font("Cooper Black", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVolver.Location = new System.Drawing.Point(51, 605);
            this.btVolver.Name = "btVolver";
            this.btVolver.Size = new System.Drawing.Size(344, 32);
            this.btVolver.TabIndex = 0;
            this.btVolver.Text = "Volver";
            this.btVolver.UseVisualStyleBackColor = false;
            this.btVolver.Click += new System.EventHandler(this.btVolver_Click);
            // 
            // dtgv_ver
            // 
            this.dtgv_ver.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_ver.Location = new System.Drawing.Point(51, 54);
            this.dtgv_ver.Name = "dtgv_ver";
            this.dtgv_ver.ReadOnly = true;
            this.dtgv_ver.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtgv_ver.Size = new System.Drawing.Size(344, 531);
            this.dtgv_ver.TabIndex = 12;
            // 
            // lb_titulo
            // 
            this.lb_titulo.AutoSize = true;
            this.lb_titulo.Font = new System.Drawing.Font("Cooper Black", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_titulo.Location = new System.Drawing.Point(47, 9);
            this.lb_titulo.Name = "lb_titulo";
            this.lb_titulo.Size = new System.Drawing.Size(299, 23);
            this.lb_titulo.TabIndex = 13;
            this.lb_titulo.Text = "Lista de Productos Cargados";
            // 
            // Ver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(240)))), ((int)(((byte)(234)))));
            this.ClientSize = new System.Drawing.Size(469, 649);
            this.Controls.Add(this.lb_titulo);
            this.Controls.Add(this.dtgv_ver);
            this.Controls.Add(this.btVolver);
            this.Name = "Ver";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ver";
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_ver)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btVolver;
        private System.Windows.Forms.DataGridView dtgv_ver;
        private System.Windows.Forms.Label lb_titulo;
    }
}