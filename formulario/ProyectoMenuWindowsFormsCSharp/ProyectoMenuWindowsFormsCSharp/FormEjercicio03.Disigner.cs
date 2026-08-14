namespace ProyectoMenuWindowsFormsCSharp
{
    partial class FormEjercicio03
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
            this.lblMonto     = new System.Windows.Forms.Label();
            this.txtMonto     = new System.Windows.Forms.TextBox();
            this.btnCalcular  = new System.Windows.Forms.Button();
            this.btnLimpiar   = new System.Windows.Forms.Button();
            this.btnVolver    = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();

            this.lblInfo.AutoSize = false;
            this.lblInfo.Location = new System.Drawing.Point(20, 15);
            this.lblInfo.Size = new System.Drawing.Size(420, 30);
            this.lblInfo.ForeColor = System.Drawing.Color.Gray;
            this.lblInfo.Text = "Monto mayor a 100: descuento del 10%.   Monto de 1 a 100: descuento del 20%.";

            this.lblMonto.AutoSize = true;
            this.lblMonto.Location = new System.Drawing.Point(20, 55);
            this.lblMonto.Text = "Monto";

            this.txtMonto.Location = new System.Drawing.Point(200, 52);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(200, 23);

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
            this.btnVolver.Text = "Salir";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            this.lblResultado.Location = new System.Drawing.Point(20, 145);
            this.lblResultado.Size = new System.Drawing.Size(420, 60);
            this.lblResultado.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblResultado.Text = "";

            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 230);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblMonto);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.lblResultado);
            this.MaximizeBox = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Name = "FormEjercicio03";
            this.Text = "Ejercicio 03 - Descuento por monto";
            this.ResumeLayout(false);
        }
        private System.Windows.Forms.Label   lblInfo;
        private System.Windows.Forms.Label   lblMonto;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Button  btnCalcular;
        private System.Windows.Forms.Button  btnLimpiar;
        private System.Windows.Forms.Button  btnVolver;
        private System.Windows.Forms.Label   lblResultado;
    }
}
