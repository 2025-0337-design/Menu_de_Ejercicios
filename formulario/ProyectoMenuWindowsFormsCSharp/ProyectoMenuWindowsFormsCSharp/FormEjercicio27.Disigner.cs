namespace ProyectoMenuWindowsFormsCSharp
{
    partial class FormEjercicio27
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }
        private void InitializeComponent()
        {
            this.lblInfo      = new System.Windows.Forms.Label();
            this.lblConsumo   = new System.Windows.Forms.Label();
            this.txtConsumo   = new System.Windows.Forms.TextBox();
            this.btnAgregar   = new System.Windows.Forms.Button();
            this.btnLimpiar   = new System.Windows.Forms.Button();
            this.btnVolver    = new System.Windows.Forms.Button();
            this.lblEstado    = new System.Windows.Forms.Label();
            this.lblAcumulado = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();

            this.lblInfo.AutoSize = false;
            this.lblInfo.Location = new System.Drawing.Point(20, 12);
            this.lblInfo.Size = new System.Drawing.Size(420, 20);
            this.lblInfo.ForeColor = System.Drawing.Color.Gray;
            this.lblInfo.Text = "Consumo mayor a 130 recibe descuento del 15%. Se registran 10 consumos.";

            this.lblConsumo.AutoSize = true;
            this.lblConsumo.Location = new System.Drawing.Point(20, 45);
            this.lblConsumo.Text = "Consumo";

            this.txtConsumo.Location = new System.Drawing.Point(200, 42);
            this.txtConsumo.Name = "txtConsumo";
            this.txtConsumo.Size = new System.Drawing.Size(200, 23);

            this.lblEstado.Location = new System.Drawing.Point(20, 75);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(420, 20);
            this.lblEstado.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblEstado.Text = "Consumo 1 de 10";

            this.lblAcumulado.Location = new System.Drawing.Point(20, 98);
            this.lblAcumulado.Name = "lblAcumulado";
            this.lblAcumulado.Size = new System.Drawing.Size(420, 20);
            this.lblAcumulado.Text = "Total acumulado: 0";

            this.btnAgregar.Location = new System.Drawing.Point(20, 128);
            this.btnAgregar.Size = new System.Drawing.Size(115, 30);
            this.btnAgregar.Text = "Agregar consumo";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);

            this.btnLimpiar.Location = new System.Drawing.Point(145, 128);
            this.btnLimpiar.Size = new System.Drawing.Size(85, 30);
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);

            this.btnVolver.Location = new System.Drawing.Point(240, 128);
            this.btnVolver.Size = new System.Drawing.Size(85, 30);
            this.btnVolver.Text = "Salir";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            this.lblResultado.Location = new System.Drawing.Point(20, 175);
            this.lblResultado.Size = new System.Drawing.Size(420, 30);
            this.lblResultado.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblResultado.Text = "";

            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 230);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblConsumo);
            this.Controls.Add(this.txtConsumo);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblAcumulado);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.lblResultado);
            this.MaximizeBox = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Name = "FormEjercicio27";
            this.Text = "Ejercicio 27 - Consumos del restaurant";
            this.ResumeLayout(false);
        }
        private System.Windows.Forms.Label   lblInfo;
        private System.Windows.Forms.Label   lblConsumo;
        private System.Windows.Forms.TextBox txtConsumo;
        private System.Windows.Forms.Label   lblEstado;
        private System.Windows.Forms.Label   lblAcumulado;
        private System.Windows.Forms.Button  btnAgregar;
        private System.Windows.Forms.Button  btnLimpiar;
        private System.Windows.Forms.Button  btnVolver;
        private System.Windows.Forms.Label   lblResultado;
    }
}
