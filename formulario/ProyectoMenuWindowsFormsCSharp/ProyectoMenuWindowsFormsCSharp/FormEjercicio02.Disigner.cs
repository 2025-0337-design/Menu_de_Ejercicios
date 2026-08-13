namespace ProyectoMenuWindowsFormsCSharp
{
    partial class FormEjercicio02
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }
        private void InitializeComponent()
        {
            this.lblSueldo    = new System.Windows.Forms.Label();
            this.txtSueldo    = new System.Windows.Forms.TextBox();
            this.lblInfo      = new System.Windows.Forms.Label();
            this.btnCalcular  = new System.Windows.Forms.Button();
            this.btnLimpiar   = new System.Windows.Forms.Button();
            this.btnVolver    = new System.Windows.Forms.Button();
            this.btnSalir     = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();

            this.lblInfo.AutoSize = false;
            this.lblInfo.Location = new System.Drawing.Point(20, 15);
            this.lblInfo.Size = new System.Drawing.Size(420, 30);
            this.lblInfo.ForeColor = System.Drawing.Color.Gray;
            this.lblInfo.Text = "Hasta 1000: descuento 10%.  1001-2000: 5% del excedente.  +2000: 3% del excedente.";

            this.lblSueldo.AutoSize = true;
            this.lblSueldo.Location = new System.Drawing.Point(20, 55);
            this.lblSueldo.Text = "Sueldo";

            this.txtSueldo.Location = new System.Drawing.Point(200, 52);
            this.txtSueldo.Name = "txtSueldo";
            this.txtSueldo.Size = new System.Drawing.Size(200, 23);

            this.btnCalcular.Location = new System.Drawing.Point(20, 95);
            this.btnCalcular.Size = new System.Drawing.Size(95, 30);
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);

            this.btnLimpiar.Location = new System.Drawing.Point(125, 95);
            this.btnLimpiar.Size = new System.Drawing.Size(95, 30);
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);

            this.btnVolver.Location = new System.Drawing.Point(230, 95);
            this.btnVolver.Size = new System.Drawing.Size(95, 30);
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);

            this.btnSalir.Location = new System.Drawing.Point(335, 95);
            this.btnSalir.Size = new System.Drawing.Size(95, 30);
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);

            this.lblResultado.Location = new System.Drawing.Point(20, 145);
            this.lblResultado.Size = new System.Drawing.Size(420, 55);
            this.lblResultado.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblResultado.Text = "";

            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 225);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblSueldo);
            this.Controls.Add(this.txtSueldo);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblResultado);
            this.MaximizeBox = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Name = "FormEjercicio02";
            this.Text = "Ejercicio 02 - Descuento de sueldo";
            this.ResumeLayout(false);
        }
        private System.Windows.Forms.Label   lblInfo;
        private System.Windows.Forms.Label   lblSueldo;
        private System.Windows.Forms.TextBox txtSueldo;
        private System.Windows.Forms.Button  btnCalcular;
        private System.Windows.Forms.Button  btnLimpiar;
        private System.Windows.Forms.Button  btnVolver;
        private System.Windows.Forms.Button  btnSalir;
        private System.Windows.Forms.Label   lblResultado;
    }
}
