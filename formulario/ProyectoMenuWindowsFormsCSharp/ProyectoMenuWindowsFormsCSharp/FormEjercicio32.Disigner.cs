namespace ProyectoMenuWindowsFormsCSharp
{
    partial class FormEjercicio32
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
            this.lblPista     = new System.Windows.Forms.Label();
            this.lblClave1    = new System.Windows.Forms.Label();
            this.txtClave1    = new System.Windows.Forms.TextBox();
            this.lblClave2    = new System.Windows.Forms.Label();
            this.txtClave2    = new System.Windows.Forms.TextBox();
            this.lblClave3    = new System.Windows.Forms.Label();
            this.txtClave3    = new System.Windows.Forms.TextBox();
            this.lblClave4    = new System.Windows.Forms.Label();
            this.txtClave4    = new System.Windows.Forms.TextBox();
            this.lblClave5    = new System.Windows.Forms.Label();
            this.txtClave5    = new System.Windows.Forms.TextBox();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.btnLimpiar   = new System.Windows.Forms.Button();
            this.btnVolver    = new System.Windows.Forms.Button();
            this.btnSalir     = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();

            this.lblInfo.AutoSize = false;
            this.lblInfo.Location = new System.Drawing.Point(20, 12);
            this.lblInfo.Size = new System.Drawing.Size(420, 35);
            this.lblInfo.ForeColor = System.Drawing.Color.Gray;
            this.lblInfo.Text = "Para entrar a la fiesta de Braulio debes conocer las 5 claves secretas. Si alguna esta mal, no podras entrar.";

            this.lblPista.AutoSize = false;
            this.lblPista.Location = new System.Drawing.Point(20, 50);
            this.lblPista.Size = new System.Drawing.Size(420, 18);
            this.lblPista.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblPista.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Italic);
            this.lblPista.Text = "Pista: las 5 claves forman la frase  \"tienes que ser invitado para ingresar\"";

            this.lblClave1.AutoSize = true;
            this.lblClave1.Location = new System.Drawing.Point(20, 80);
            this.lblClave1.Text = "Clave 1";

            this.txtClave1.Location = new System.Drawing.Point(190, 77);
            this.txtClave1.Name = "txtClave1";
            this.txtClave1.Size = new System.Drawing.Size(230, 23);

            this.lblClave2.AutoSize = true;
            this.lblClave2.Location = new System.Drawing.Point(20, 115);
            this.lblClave2.Text = "Clave 2";

            this.txtClave2.Location = new System.Drawing.Point(190, 112);
            this.txtClave2.Name = "txtClave2";
            this.txtClave2.Size = new System.Drawing.Size(230, 23);

            this.lblClave3.AutoSize = true;
            this.lblClave3.Location = new System.Drawing.Point(20, 150);
            this.lblClave3.Text = "Clave 3";

            this.txtClave3.Location = new System.Drawing.Point(190, 147);
            this.txtClave3.Name = "txtClave3";
            this.txtClave3.Size = new System.Drawing.Size(230, 23);

            this.lblClave4.AutoSize = true;
            this.lblClave4.Location = new System.Drawing.Point(20, 185);
            this.lblClave4.Text = "Clave 4";

            this.txtClave4.Location = new System.Drawing.Point(190, 182);
            this.txtClave4.Name = "txtClave4";
            this.txtClave4.Size = new System.Drawing.Size(230, 23);

            this.lblClave5.AutoSize = true;
            this.lblClave5.Location = new System.Drawing.Point(20, 220);
            this.lblClave5.Text = "Clave 5";

            this.txtClave5.Location = new System.Drawing.Point(190, 217);
            this.txtClave5.Name = "txtClave5";
            this.txtClave5.Size = new System.Drawing.Size(230, 23);

            this.btnVerificar.Location = new System.Drawing.Point(20, 258);
            this.btnVerificar.Size = new System.Drawing.Size(95, 30);
            this.btnVerificar.Text = "Verificar";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);

            this.btnLimpiar.Location = new System.Drawing.Point(125, 258);
            this.btnLimpiar.Size = new System.Drawing.Size(95, 30);
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);

            this.btnVolver.Location = new System.Drawing.Point(230, 258);
            this.btnVolver.Size = new System.Drawing.Size(95, 30);
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);

            this.btnSalir.Location = new System.Drawing.Point(335, 258);
            this.btnSalir.Size = new System.Drawing.Size(95, 30);
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);

            this.lblResultado.Location = new System.Drawing.Point(20, 300);
            this.lblResultado.Size = new System.Drawing.Size(420, 28);
            this.lblResultado.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblResultado.Text = "";

            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 348);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblPista);
            this.Controls.Add(this.lblClave1);
            this.Controls.Add(this.txtClave1);
            this.Controls.Add(this.lblClave2);
            this.Controls.Add(this.txtClave2);
            this.Controls.Add(this.lblClave3);
            this.Controls.Add(this.txtClave3);
            this.Controls.Add(this.lblClave4);
            this.Controls.Add(this.txtClave4);
            this.Controls.Add(this.lblClave5);
            this.Controls.Add(this.txtClave5);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblResultado);
            this.MaximizeBox = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Name = "FormEjercicio32";
            this.Text = "Ejercicio 32 - Claves para la fiesta";
            this.ResumeLayout(false);
        }
        private System.Windows.Forms.Label   lblInfo;
        private System.Windows.Forms.Label   lblPista;
        private System.Windows.Forms.Label   lblClave1;
        private System.Windows.Forms.TextBox txtClave1;
        private System.Windows.Forms.Label   lblClave2;
        private System.Windows.Forms.TextBox txtClave2;
        private System.Windows.Forms.Label   lblClave3;
        private System.Windows.Forms.TextBox txtClave3;
        private System.Windows.Forms.Label   lblClave4;
        private System.Windows.Forms.TextBox txtClave4;
        private System.Windows.Forms.Label   lblClave5;
        private System.Windows.Forms.TextBox txtClave5;
        private System.Windows.Forms.Button  btnVerificar;
        private System.Windows.Forms.Button  btnLimpiar;
        private System.Windows.Forms.Button  btnVolver;
        private System.Windows.Forms.Button  btnSalir;
        private System.Windows.Forms.Label   lblResultado;
    }
}
