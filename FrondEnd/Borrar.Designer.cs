namespace FrondEnd
{
    partial class Borrar
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
            this.lbCodigo = new System.Windows.Forms.Label();
            this.lb_titulo = new System.Windows.Forms.Label();
            this.txtCodigoB = new System.Windows.Forms.TextBox();
            this.btVolver = new System.Windows.Forms.Button();
            this.btBorrar = new System.Windows.Forms.Button();
            this.dtgv_borrar = new System.Windows.Forms.DataGridView();
            this.lbaviso = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_borrar)).BeginInit();
            this.SuspendLayout();
            // 
            // lbCodigo
            // 
            this.lbCodigo.AutoSize = true;
            this.lbCodigo.Font = new System.Drawing.Font("Cooper Black", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCodigo.Location = new System.Drawing.Point(43, 458);
            this.lbCodigo.Name = "lbCodigo";
            this.lbCodigo.Size = new System.Drawing.Size(86, 23);
            this.lbCodigo.TabIndex = 18;
            this.lbCodigo.Text = "Codigo:";
            // 
            // lb_titulo
            // 
            this.lb_titulo.AutoSize = true;
            this.lb_titulo.Font = new System.Drawing.Font("Cooper Black", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_titulo.Location = new System.Drawing.Point(43, 36);
            this.lb_titulo.Name = "lb_titulo";
            this.lb_titulo.Size = new System.Drawing.Size(196, 23);
            this.lb_titulo.TabIndex = 17;
            this.lb_titulo.Text = "Borrar Productos ";
            // 
            // txtCodigoB
            // 
            this.txtCodigoB.Font = new System.Drawing.Font("Cooper Black", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoB.Location = new System.Drawing.Point(47, 484);
            this.txtCodigoB.Name = "txtCodigoB";
            this.txtCodigoB.Size = new System.Drawing.Size(344, 30);
            this.txtCodigoB.TabIndex = 13;
            this.txtCodigoB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btVolver
            // 
            this.btVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btVolver.Font = new System.Drawing.Font("Cooper Black", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVolver.Location = new System.Drawing.Point(356, 607);
            this.btVolver.Name = "btVolver";
            this.btVolver.Size = new System.Drawing.Size(101, 30);
            this.btVolver.TabIndex = 12;
            this.btVolver.Text = "Volver";
            this.btVolver.UseVisualStyleBackColor = false;
            this.btVolver.Click += new System.EventHandler(this.btVolver_Click);
            // 
            // btBorrar
            // 
            this.btBorrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(244)))), ((int)(((byte)(183)))));
            this.btBorrar.Font = new System.Drawing.Font("Cooper Black", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBorrar.Location = new System.Drawing.Point(47, 537);
            this.btBorrar.Name = "btBorrar";
            this.btBorrar.Size = new System.Drawing.Size(344, 33);
            this.btBorrar.TabIndex = 11;
            this.btBorrar.Text = "Borrar";
            this.btBorrar.UseVisualStyleBackColor = false;
            this.btBorrar.Click += new System.EventHandler(this.btBorrar_Click);
            // 
            // dtgv_borrar
            // 
            this.dtgv_borrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_borrar.Location = new System.Drawing.Point(47, 72);
            this.dtgv_borrar.Name = "dtgv_borrar";
            this.dtgv_borrar.ReadOnly = true;
            this.dtgv_borrar.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtgv_borrar.Size = new System.Drawing.Size(344, 358);
            this.dtgv_borrar.TabIndex = 19;
            // 
            // lbaviso
            // 
            this.lbaviso.AutoSize = true;
            this.lbaviso.Location = new System.Drawing.Point(44, 588);
            this.lbaviso.Name = "lbaviso";
            this.lbaviso.Size = new System.Drawing.Size(0, 13);
            this.lbaviso.TabIndex = 20;
            // 
            // Borrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(240)))), ((int)(((byte)(234)))));
            this.ClientSize = new System.Drawing.Size(469, 649);
            this.Controls.Add(this.lbaviso);
            this.Controls.Add(this.dtgv_borrar);
            this.Controls.Add(this.lbCodigo);
            this.Controls.Add(this.lb_titulo);
            this.Controls.Add(this.txtCodigoB);
            this.Controls.Add(this.btVolver);
            this.Controls.Add(this.btBorrar);
            this.Name = "Borrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Borrar";
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_borrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCodigo;
        private System.Windows.Forms.Label lb_titulo;
        private System.Windows.Forms.TextBox txtCodigoB;
        private System.Windows.Forms.Button btVolver;
        private System.Windows.Forms.Button btBorrar;
        private System.Windows.Forms.DataGridView dtgv_borrar;
        private System.Windows.Forms.Label lbaviso;
    }
}