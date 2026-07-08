namespace ProyectoMenuWindowsFormsCSharp
{
    partial class FormEjercicio12
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }
        private void InitializeComponent()
        {
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lstResultados = new System.Windows.Forms.ListBox();
            this.SuspendLayout();

            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(20, 20);
            this.lblNumero.Text = "Numero";

            this.txtNumero.Location = new System.Drawing.Point(190, 17);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(160, 23);

            this.btnAgregar.Location = new System.Drawing.Point(20, 55);
            this.btnAgregar.Size = new System.Drawing.Size(130, 28);
            this.btnAgregar.Text = "Agregar numero";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);

            this.lblEstado.Location = new System.Drawing.Point(160, 60);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(200, 20);
            this.lblEstado.Text = "Faltan 50 numeros";

            this.lstResultados.FormattingEnabled = true;
            this.lstResultados.Location = new System.Drawing.Point(20, 95);
            this.lstResultados.Name = "lstResultados";
            this.lstResultados.Size = new System.Drawing.Size(340, 195);

            this.btnLimpiar.Location = new System.Drawing.Point(20, 305);
            this.btnLimpiar.Size = new System.Drawing.Size(100, 28);
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);

            this.btnVolver.Location = new System.Drawing.Point(260, 305);
            this.btnVolver.Size = new System.Drawing.Size(100, 28);
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);

            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 355);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lstResultados);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnVolver);
            this.MaximizeBox = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Name = "FormEjercicio12";
            this.Text = "Ejercicio 12 - Clasificar 50 numeros";
            this.ResumeLayout(false);
        }
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.ListBox lstResultados;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnVolver;
    }
}
