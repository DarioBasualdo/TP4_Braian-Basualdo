namespace FrondEnd
{
    partial class Actualizar
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
            this.btVolver = new System.Windows.Forms.Button();
            this.txtCodigoActualizar = new System.Windows.Forms.TextBox();
            this.txtProductoA = new System.Windows.Forms.TextBox();
            this.txtPrecioA = new System.Windows.Forms.TextBox();
            this.lb_titulo = new System.Windows.Forms.Label();
            this.lbCodigo = new System.Windows.Forms.Label();
            this.lbproductoA = new System.Windows.Forms.Label();
            this.lbprecioA = new System.Windows.Forms.Label();
            this.dtgv_actualizar = new System.Windows.Forms.DataGridView();
            this.lbaviso = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_actualizar)).BeginInit();
            this.SuspendLayout();
            // 
            // btActualizar
            // 
            this.btActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(244)))), ((int)(((byte)(183)))));
            this.btActualizar.Font = new System.Drawing.Font("Cooper Black", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btActualizar.Location = new System.Drawing.Point(21, 542);
            this.btActualizar.Name = "btActualizar";
            this.btActualizar.Size = new System.Drawing.Size(432, 30);
            this.btActualizar.TabIndex = 0;
            this.btActualizar.Text = "Actualizar";
            this.btActualizar.UseVisualStyleBackColor = false;
            this.btActualizar.Click += new System.EventHandler(this.btActualizar_Click);
            // 
            // btVolver
            // 
            this.btVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btVolver.Font = new System.Drawing.Font("Cooper Black", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVolver.Location = new System.Drawing.Point(353, 607);
            this.btVolver.Name = "btVolver";
            this.btVolver.Size = new System.Drawing.Size(100, 30);
            this.btVolver.TabIndex = 1;
            this.btVolver.Text = "Volver";
            this.btVolver.UseVisualStyleBackColor = false;
            this.btVolver.Click += new System.EventHandler(this.btVolver_Click);
            // 
            // txtCodigoActualizar
            // 
            this.txtCodigoActualizar.Font = new System.Drawing.Font("Cooper Black", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoActualizar.Location = new System.Drawing.Point(21, 478);
            this.txtCodigoActualizar.Name = "txtCodigoActualizar";
            this.txtCodigoActualizar.Size = new System.Drawing.Size(73, 30);
            this.txtCodigoActualizar.TabIndex = 2;
            // 
            // txtProductoA
            // 
            this.txtProductoA.Font = new System.Drawing.Font("Cooper Black", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductoA.Location = new System.Drawing.Point(126, 478);
            this.txtProductoA.Name = "txtProductoA";
            this.txtProductoA.Size = new System.Drawing.Size(217, 30);
            this.txtProductoA.TabIndex = 3;
            // 
            // txtPrecioA
            // 
            this.txtPrecioA.Font = new System.Drawing.Font("Cooper Black", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioA.Location = new System.Drawing.Point(353, 478);
            this.txtPrecioA.Name = "txtPrecioA";
            this.txtPrecioA.Size = new System.Drawing.Size(100, 30);
            this.txtPrecioA.TabIndex = 6;
            // 
            // lb_titulo
            // 
            this.lb_titulo.AutoSize = true;
            this.lb_titulo.Font = new System.Drawing.Font("Cooper Black", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_titulo.Location = new System.Drawing.Point(51, 37);
            this.lb_titulo.Name = "lb_titulo";
            this.lb_titulo.Size = new System.Drawing.Size(229, 23);
            this.lb_titulo.TabIndex = 7;
            this.lb_titulo.Text = "Actualizar Productos";
            // 
            // lbCodigo
            // 
            this.lbCodigo.AutoSize = true;
            this.lbCodigo.Font = new System.Drawing.Font("Cooper Black", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCodigo.Location = new System.Drawing.Point(17, 452);
            this.lbCodigo.Name = "lbCodigo";
            this.lbCodigo.Size = new System.Drawing.Size(86, 23);
            this.lbCodigo.TabIndex = 8;
            this.lbCodigo.Text = "Codigo:";
            // 
            // lbproductoA
            // 
            this.lbproductoA.AutoSize = true;
            this.lbproductoA.Font = new System.Drawing.Font("Cooper Black", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbproductoA.Location = new System.Drawing.Point(126, 454);
            this.lbproductoA.Name = "lbproductoA";
            this.lbproductoA.Size = new System.Drawing.Size(112, 23);
            this.lbproductoA.TabIndex = 9;
            this.lbproductoA.Text = "Producto:";
            // 
            // lbprecioA
            // 
            this.lbprecioA.AutoSize = true;
            this.lbprecioA.Font = new System.Drawing.Font("Cooper Black", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbprecioA.Location = new System.Drawing.Point(349, 454);
            this.lbprecioA.Name = "lbprecioA";
            this.lbprecioA.Size = new System.Drawing.Size(82, 23);
            this.lbprecioA.TabIndex = 10;
            this.lbprecioA.Text = "Precio:";
            // 
            // dtgv_actualizar
            // 
            this.dtgv_actualizar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_actualizar.Location = new System.Drawing.Point(55, 80);
            this.dtgv_actualizar.Name = "dtgv_actualizar";
            this.dtgv_actualizar.ReadOnly = true;
            this.dtgv_actualizar.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtgv_actualizar.Size = new System.Drawing.Size(344, 358);
            this.dtgv_actualizar.TabIndex = 11;
            // 
            // lbaviso
            // 
            this.lbaviso.AutoSize = true;
            this.lbaviso.Location = new System.Drawing.Point(18, 590);
            this.lbaviso.Name = "lbaviso";
            this.lbaviso.Size = new System.Drawing.Size(0, 13);
            this.lbaviso.TabIndex = 12;
            // 
            // Actualizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(240)))), ((int)(((byte)(234)))));
            this.ClientSize = new System.Drawing.Size(469, 649);
            this.Controls.Add(this.lbaviso);
            this.Controls.Add(this.dtgv_actualizar);
            this.Controls.Add(this.lbprecioA);
            this.Controls.Add(this.lbproductoA);
            this.Controls.Add(this.lbCodigo);
            this.Controls.Add(this.lb_titulo);
            this.Controls.Add(this.txtPrecioA);
            this.Controls.Add(this.txtProductoA);
            this.Controls.Add(this.txtCodigoActualizar);
            this.Controls.Add(this.btVolver);
            this.Controls.Add(this.btActualizar);
            this.Name = "Actualizar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Actualizar";
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_actualizar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btActualizar;
        private System.Windows.Forms.Button btVolver;
        private System.Windows.Forms.TextBox txtCodigoActualizar;
        private System.Windows.Forms.TextBox txtProductoA;
        private System.Windows.Forms.TextBox txtPrecioA;
        private System.Windows.Forms.Label lb_titulo;
        private System.Windows.Forms.Label lbCodigo;
        private System.Windows.Forms.Label lbproductoA;
        private System.Windows.Forms.Label lbprecioA;
        private System.Windows.Forms.DataGridView dtgv_actualizar;
        private System.Windows.Forms.Label lbaviso;
    }
}