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
            this.lblEgreso = new System.Windows.Forms.Label();
            this.txtEgreso = new System.Windows.Forms.TextBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.lstResultados = new System.Windows.Forms.ListBox();
            this.SuspendLayout();

            this.lblEgreso.AutoSize = true;
            this.lblEgreso.Location = new System.Drawing.Point(20, 20);
            this.lblEgreso.Text = "Egreso (-1 para terminar)";

            this.txtEgreso.Location = new System.Drawing.Point(210, 17);
            this.txtEgreso.Name = "txtEgreso";
            this.txtEgreso.Size = new System.Drawing.Size(150, 23);

            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(20, 46);
            this.lblInfo.Text = "Caja inicial: 371";

            this.btnAgregar.Location = new System.Drawing.Point(20, 68);
            this.btnAgregar.Size = new System.Drawing.Size(130, 28);
            this.btnAgregar.Text = "Registrar egreso";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);

            this.lstResultados.FormattingEnabled = true;
            this.lstResultados.Location = new System.Drawing.Point(20, 108);
            this.lstResultados.Name = "lstResultados";
            this.lstResultados.Size = new System.Drawing.Size(340, 160);

            this.btnLimpiar.Location = new System.Drawing.Point(20, 283);
            this.btnLimpiar.Size = new System.Drawing.Size(100, 28);
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);

            this.btnVolver.Location = new System.Drawing.Point(260, 283);
            this.btnVolver.Size = new System.Drawing.Size(100, 28);
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);

            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 330);
            this.Controls.Add(this.lblEgreso);
            this.Controls.Add(this.txtEgreso);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lstResultados);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnVolver);
            this.MaximizeBox = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Name = "FormEjercicio29";
            this.Text = "Ejercicio 29 - Caja de la compania Barner";
            this.ResumeLayout(false);
        }
        private System.Windows.Forms.Label lblEgreso;
        private System.Windows.Forms.TextBox txtEgreso;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ListBox lstResultados;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnVolver;
    }
}
