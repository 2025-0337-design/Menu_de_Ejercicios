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
            this.lblClave1 = new System.Windows.Forms.Label();
            this.txtClave1 = new System.Windows.Forms.TextBox();
            this.lblClave2 = new System.Windows.Forms.Label();
            this.txtClave2 = new System.Windows.Forms.TextBox();
            this.lblClave3 = new System.Windows.Forms.Label();
            this.txtClave3 = new System.Windows.Forms.TextBox();
            this.lblClave4 = new System.Windows.Forms.Label();
            this.txtClave4 = new System.Windows.Forms.TextBox();
            this.lblClave5 = new System.Windows.Forms.Label();
            this.txtClave5 = new System.Windows.Forms.TextBox();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();

            this.lblClave1.AutoSize = true;
            this.lblClave1.Location = new System.Drawing.Point(20, 20);
            this.lblClave1.Text = "Primera clave";

            this.txtClave1.Location = new System.Drawing.Point(180, 17);
            this.txtClave1.Name = "txtClave1";
            this.txtClave1.Size = new System.Drawing.Size(190, 23);

            this.lblClave2.AutoSize = true;
            this.lblClave2.Location = new System.Drawing.Point(20, 55);
            this.lblClave2.Text = "Segunda clave";

            this.txtClave2.Location = new System.Drawing.Point(180, 52);
            this.txtClave2.Name = "txtClave2";
            this.txtClave2.Size = new System.Drawing.Size(190, 23);

            this.lblClave3.AutoSize = true;
            this.lblClave3.Location = new System.Drawing.Point(20, 90);
            this.lblClave3.Text = "Tercera clave";

            this.txtClave3.Location = new System.Drawing.Point(180, 87);
            this.txtClave3.Name = "txtClave3";
            this.txtClave3.Size = new System.Drawing.Size(190, 23);

            this.lblClave4.AutoSize = true;
            this.lblClave4.Location = new System.Drawing.Point(20, 125);
            this.lblClave4.Text = "Cuarta clave";

            this.txtClave4.Location = new System.Drawing.Point(180, 122);
            this.txtClave4.Name = "txtClave4";
            this.txtClave4.Size = new System.Drawing.Size(190, 23);

            this.lblClave5.AutoSize = true;
            this.lblClave5.Location = new System.Drawing.Point(20, 160);
            this.lblClave5.Text = "Quinta clave";

            this.txtClave5.Location = new System.Drawing.Point(180, 157);
            this.txtClave5.Name = "txtClave5";
            this.txtClave5.Size = new System.Drawing.Size(190, 23);

            this.btnVerificar.Location = new System.Drawing.Point(20, 200);
            this.btnVerificar.Size = new System.Drawing.Size(100, 28);
            this.btnVerificar.Text = "Verificar";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);

            this.btnLimpiar.Location = new System.Drawing.Point(130, 200);
            this.btnLimpiar.Size = new System.Drawing.Size(100, 28);
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);

            this.btnVolver.Location = new System.Drawing.Point(240, 200);
            this.btnVolver.Size = new System.Drawing.Size(100, 28);
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);

            this.lblResultado.Location = new System.Drawing.Point(20, 245);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(360, 30);
            this.lblResultado.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblResultado.Text = "";

            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 295);
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
            this.Controls.Add(this.lblResultado);
            this.MaximizeBox = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Name = "FormEjercicio32";
            this.Text = "Ejercicio 32 - Claves para la fiesta";
            this.ResumeLayout(false);
        }
        private System.Windows.Forms.Label lblClave1;
        private System.Windows.Forms.TextBox txtClave1;
        private System.Windows.Forms.Label lblClave2;
        private System.Windows.Forms.TextBox txtClave2;
        private System.Windows.Forms.Label lblClave3;
        private System.Windows.Forms.TextBox txtClave3;
        private System.Windows.Forms.Label lblClave4;
        private System.Windows.Forms.TextBox txtClave4;
        private System.Windows.Forms.Label lblClave5;
        private System.Windows.Forms.TextBox txtClave5;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label lblResultado;
    }
}
