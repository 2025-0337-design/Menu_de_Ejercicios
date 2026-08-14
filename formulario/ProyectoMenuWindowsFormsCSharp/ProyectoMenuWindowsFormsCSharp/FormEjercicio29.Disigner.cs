namespace ProyectoMenuWindowsFormsCSharp
{
    partial class FormEjercicio29
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }
        private void InitializeComponent()
        {
            this.lblInfo       = new System.Windows.Forms.Label();
            this.lblEgreso     = new System.Windows.Forms.Label();
            this.txtEgreso     = new System.Windows.Forms.TextBox();
            this.lblSaldo      = new System.Windows.Forms.Label();
            this.btnAgregar    = new System.Windows.Forms.Button();
            this.btnLimpiar    = new System.Windows.Forms.Button();
            this.btnVolver     = new System.Windows.Forms.Button();
            this.lstResultados = new System.Windows.Forms.ListBox();
            this.SuspendLayout();

            this.lblInfo.AutoSize = false;
            this.lblInfo.Location = new System.Drawing.Point(20, 12);
            this.lblInfo.Size = new System.Drawing.Size(420, 20);
            this.lblInfo.ForeColor = System.Drawing.Color.Gray;
            this.lblInfo.Text = "Caja inicial: 371. Registra cada egreso del dia. Ingresa -1 para terminar.";

            this.lblEgreso.AutoSize = true;
            this.lblEgreso.Location = new System.Drawing.Point(20, 42);
            this.lblEgreso.Text = "Egreso  (-1 para terminar)";

            this.txtEgreso.Location = new System.Drawing.Point(230, 39);
            this.txtEgreso.Name = "txtEgreso";
            this.txtEgreso.Size = new System.Drawing.Size(180, 23);

            this.lblSaldo.Location = new System.Drawing.Point(20, 70);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(420, 22);
            this.lblSaldo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblSaldo.ForeColor = System.Drawing.Color.FromArgb(39, 174, 96);
            this.lblSaldo.Text = "Saldo en caja: 371";

            this.btnAgregar.Location = new System.Drawing.Point(20, 100);
            this.btnAgregar.Size = new System.Drawing.Size(115, 28);
            this.btnAgregar.Text = "Registrar egreso";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);

            this.btnLimpiar.Location = new System.Drawing.Point(145, 100);
            this.btnLimpiar.Size = new System.Drawing.Size(85, 28);
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);

            this.btnVolver.Location = new System.Drawing.Point(240, 100);
            this.btnVolver.Size = new System.Drawing.Size(85, 28);
            this.btnVolver.Text = "Salir";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            this.lstResultados.FormattingEnabled = true;
            this.lstResultados.Location = new System.Drawing.Point(20, 140);
            this.lstResultados.Name = "lstResultados";
            this.lstResultados.Size = new System.Drawing.Size(420, 160);

            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 325);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblEgreso);
            this.Controls.Add(this.txtEgreso);
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.lstResultados);
            this.MaximizeBox = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Name = "FormEjercicio29";
            this.Text = "Ejercicio 29 - Caja de la compania Barner";
            this.ResumeLayout(false);
        }
        private System.Windows.Forms.Label   lblInfo;
        private System.Windows.Forms.Label   lblEgreso;
        private System.Windows.Forms.TextBox txtEgreso;
        private System.Windows.Forms.Label   lblSaldo;
        private System.Windows.Forms.Button  btnAgregar;
        private System.Windows.Forms.Button  btnLimpiar;
        private System.Windows.Forms.Button  btnVolver;
        private System.Windows.Forms.ListBox lstResultados;
    }
}
