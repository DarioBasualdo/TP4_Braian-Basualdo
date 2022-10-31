namespace FrondEnd
{
    partial class Cargar
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
            this.bt_cargar = new System.Windows.Forms.Button();
            this.btVolver = new System.Windows.Forms.Button();
            this.txtproducto = new System.Windows.Forms.TextBox();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.lbproducto = new System.Windows.Forms.Label();
            this.lbprecio = new System.Windows.Forms.Label();
            this.lb_titulo = new System.Windows.Forms.Label();
            this.dtgv_cargar = new System.Windows.Forms.DataGridView();
            this.lbCodigo = new System.Windows.Forms.Label();
            this.txtCodigoCargar = new System.Windows.Forms.TextBox();
            this.lbaviso = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_cargar)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_cargar
            // 
            this.bt_cargar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(244)))), ((int)(((byte)(183)))));
            this.bt_cargar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_cargar.Font = new System.Drawing.Font("Cooper Black", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_cargar.Location = new System.Drawing.Point(30, 543);
            this.bt_cargar.Name = "bt_cargar";
            this.bt_cargar.Size = new System.Drawing.Size(427, 30);
            this.bt_cargar.TabIndex = 1;
            this.bt_cargar.Text = "Cargar";
            this.bt_cargar.UseVisualStyleBackColor = false;
            this.bt_cargar.Click += new System.EventHandler(this.bt_cargar_Click);
            // 
            // btVolver
            // 
            this.btVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btVolver.Font = new System.Drawing.Font("Cooper Black", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVolver.Location = new System.Drawing.Point(335, 607);
            this.btVolver.Name = "btVolver";
            this.btVolver.Size = new System.Drawing.Size(122, 30);
            this.btVolver.TabIndex = 2;
            this.btVolver.Text = "Volver";
            this.btVolver.UseVisualStyleBackColor = false;
            this.btVolver.Click += new System.EventHandler(this.btVolver_Click);
            // 
            // txtproducto
            // 
            this.txtproducto.Font = new System.Drawing.Font("Cooper Black", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtproducto.Location = new System.Drawing.Point(154, 475);
            this.txtproducto.Name = "txtproducto";
            this.txtproducto.Size = new System.Drawing.Size(173, 30);
            this.txtproducto.TabIndex = 4;
            // 
            // txtprecio
            // 
            this.txtprecio.Font = new System.Drawing.Font("Cooper Black", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprecio.Location = new System.Drawing.Point(363, 475);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(94, 30);
            this.txtprecio.TabIndex = 6;
            // 
            // lbproducto
            // 
            this.lbproducto.AutoSize = true;
            this.lbproducto.Font = new System.Drawing.Font("Cooper Black", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbproducto.Location = new System.Drawing.Point(150, 449);
            this.lbproducto.Name = "lbproducto";
            this.lbproducto.Size = new System.Drawing.Size(112, 23);
            this.lbproducto.TabIndex = 7;
            this.lbproducto.Text = "Producto:";
            // 
            // lbprecio
            // 
            this.lbprecio.AutoSize = true;
            this.lbprecio.Font = new System.Drawing.Font("Cooper Black", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbprecio.Location = new System.Drawing.Point(359, 448);
            this.lbprecio.Name = "lbprecio";
            this.lbprecio.Size = new System.Drawing.Size(82, 23);
            this.lbprecio.TabIndex = 8;
            this.lbprecio.Text = "Precio:";
            // 
            // lb_titulo
            // 
            this.lb_titulo.AutoSize = true;
            this.lb_titulo.Font = new System.Drawing.Font("Cooper Black", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_titulo.Location = new System.Drawing.Point(76, 19);
            this.lb_titulo.Name = "lb_titulo";
            this.lb_titulo.Size = new System.Drawing.Size(191, 23);
            this.lb_titulo.TabIndex = 9;
            this.lb_titulo.Text = "Cargar Productos";
            // 
            // dtgv_cargar
            // 
            this.dtgv_cargar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_cargar.Location = new System.Drawing.Point(80, 66);
            this.dtgv_cargar.Name = "dtgv_cargar";
            this.dtgv_cargar.ReadOnly = true;
            this.dtgv_cargar.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtgv_cargar.Size = new System.Drawing.Size(344, 358);
            this.dtgv_cargar.TabIndex = 12;
            // 
            // lbCodigo
            // 
            this.lbCodigo.AutoSize = true;
            this.lbCodigo.Font = new System.Drawing.Font("Cooper Black", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCodigo.Location = new System.Drawing.Point(26, 448);
            this.lbCodigo.Name = "lbCodigo";
            this.lbCodigo.Size = new System.Drawing.Size(86, 23);
            this.lbCodigo.TabIndex = 14;
            this.lbCodigo.Text = "Codigo:";
            // 
            // txtCodigoCargar
            // 
            this.txtCodigoCargar.Font = new System.Drawing.Font("Cooper Black", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoCargar.Location = new System.Drawing.Point(30, 474);
            this.txtCodigoCargar.Name = "txtCodigoCargar";
            this.txtCodigoCargar.Size = new System.Drawing.Size(73, 30);
            this.txtCodigoCargar.TabIndex = 13;
            // 
            // lbaviso
            // 
            this.lbaviso.AutoSize = true;
            this.lbaviso.Location = new System.Drawing.Point(27, 590);
            this.lbaviso.Name = "lbaviso";
            this.lbaviso.Size = new System.Drawing.Size(0, 13);
            this.lbaviso.TabIndex = 15;
            // 
            // Cargar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(240)))), ((int)(((byte)(234)))));
            this.ClientSize = new System.Drawing.Size(469, 649);
            this.Controls.Add(this.lbaviso);
            this.Controls.Add(this.lbCodigo);
            this.Controls.Add(this.txtCodigoCargar);
            this.Controls.Add(this.dtgv_cargar);
            this.Controls.Add(this.lb_titulo);
            this.Controls.Add(this.lbprecio);
            this.Controls.Add(this.lbproducto);
            this.Controls.Add(this.txtprecio);
            this.Controls.Add(this.txtproducto);
            this.Controls.Add(this.btVolver);
            this.Controls.Add(this.bt_cargar);
            this.Name = "Cargar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cargar";
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_cargar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bt_cargar;
        private System.Windows.Forms.Button btVolver;
        private System.Windows.Forms.TextBox txtproducto;
        private System.Windows.Forms.TextBox txtprecio;
        private System.Windows.Forms.Label lbproducto;
        private System.Windows.Forms.Label lbprecio;
        private System.Windows.Forms.Label lb_titulo;
        private System.Windows.Forms.DataGridView dtgv_cargar;
        private System.Windows.Forms.Label lbCodigo;
        private System.Windows.Forms.TextBox txtCodigoCargar;
        private System.Windows.Forms.Label lbaviso;
    }
}