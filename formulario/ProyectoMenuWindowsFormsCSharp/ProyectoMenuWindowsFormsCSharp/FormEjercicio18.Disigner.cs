namespace ProyectoMenuWindowsFormsCSharp
{
    partial class FormEjercicio18
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
            this.lblCaracter  = new System.Windows.Forms.Label();
            this.txtCaracter  = new System.Windows.Forms.TextBox();
            this.lblIntentos  = new System.Windows.Forms.Label();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.btnLimpiar   = new System.Windows.Forms.Button();
            this.btnVolver    = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();

            this.lblInfo.AutoSize = false;
            this.lblInfo.Location = new System.Drawing.Point(20, 15);
            this.lblInfo.Size = new System.Drawing.Size(420, 35);
            this.lblInfo.ForeColor = System.Drawing.Color.Gray;
            this.lblInfo.Text = "Escribe un caracter a la vez y presiona Verificar. El programa busca la primera vocal minuscula que ingreses (a, e, i, o, u).";

            this.lblCaracter.AutoSize = true;
            this.lblCaracter.Location = new System.Drawing.Point(20, 60);
            this.lblCaracter.Text = "Caracter";

            this.txtCaracter.Location = new System.Drawing.Point(200, 57);
            this.txtCaracter.MaxLength = 1;
            this.txtCaracter.Name = "txtCaracter";
            this.txtCaracter.Size = new System.Drawing.Size(200, 23);

            this.lblIntentos.AutoSize = true;
            this.lblIntentos.Location = new System.Drawing.Point(20, 90);
            this.lblIntentos.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblIntentos.Name = "lblIntentos";
            this.lblIntentos.Text = "Intentos: 0";

            this.btnVerificar.Location = new System.Drawing.Point(20, 120);
            this.btnVerificar.Size = new System.Drawing.Size(95, 30);
            this.btnVerificar.Text = "Verificar";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);

            this.btnLimpiar.Location = new System.Drawing.Point(125, 120);
            this.btnLimpiar.Size = new System.Drawing.Size(95, 30);
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);

            this.btnVolver.Location = new System.Drawing.Point(230, 120);
            this.btnVolver.Size = new System.Drawing.Size(95, 30);
            this.btnVolver.Text = "Salir";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            this.lblResultado.Location = new System.Drawing.Point(20, 170);
            this.lblResultado.Size = new System.Drawing.Size(420, 35);
            this.lblResultado.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblResultado.Text = "";

            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 230);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblCaracter);
            this.Controls.Add(this.txtCaracter);
            this.Controls.Add(this.lblIntentos);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.lblResultado);
            this.MaximizeBox = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Name = "FormEjercicio18";
            this.Text = "Ejercicio 18 - Primera vocal ingresada";
            this.ResumeLayout(false);
        }
        private System.Windows.Forms.Label   lblInfo;
        private System.Windows.Forms.Label   lblCaracter;
        private System.Windows.Forms.TextBox txtCaracter;
        private System.Windows.Forms.Label   lblIntentos;
        private System.Windows.Forms.Button  btnVerificar;
        private System.Windows.Forms.Button  btnLimpiar;
        private System.Windows.Forms.Button  btnVolver;
        private System.Windows.Forms.Label   lblResultado;
    }
}
