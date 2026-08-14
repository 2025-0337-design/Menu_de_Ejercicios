namespace ProyectoMenuWindowsFormsCSharp
{
    partial class FormEjercicio25
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }
        private void InitializeComponent()
        {
            this.lblCatetoA = new System.Windows.Forms.Label();
            this.txtCatetoA = new System.Windows.Forms.TextBox();
            this.lblCatetoB = new System.Windows.Forms.Label();
            this.txtCatetoB = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();

            this.lblCatetoA.AutoSize = true;
            this.lblCatetoA.Location = new System.Drawing.Point(20, 20);
            this.lblCatetoA.Text = "Primer cateto";

            this.txtCatetoA.Location = new System.Drawing.Point(190, 17);
            this.txtCatetoA.Name = "txtCatetoA";
            this.txtCatetoA.Size = new System.Drawing.Size(180, 23);

            this.lblCatetoB.AutoSize = true;
            this.lblCatetoB.Location = new System.Drawing.Point(20, 55);
            this.lblCatetoB.Text = "Segundo cateto";

            this.txtCatetoB.Location = new System.Drawing.Point(190, 52);
            this.txtCatetoB.Name = "txtCatetoB";
            this.txtCatetoB.Size = new System.Drawing.Size(180, 23);

            this.btnCalcular.Location = new System.Drawing.Point(20, 95);
            this.btnCalcular.Size = new System.Drawing.Size(100, 28);
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);

            this.btnLimpiar.Location = new System.Drawing.Point(130, 95);
            this.btnLimpiar.Size = new System.Drawing.Size(100, 28);
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);

            this.btnVolver.Location = new System.Drawing.Point(240, 95);
            this.btnVolver.Size = new System.Drawing.Size(100, 28);
            this.btnVolver.Text = "Salir";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);

            this.lblResultado.Location = new System.Drawing.Point(20, 140);
            this.lblResultado.Size = new System.Drawing.Size(360, 30);
            this.lblResultado.Text = "";

            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 205);
            this.Controls.Add(this.lblCatetoA);
            this.Controls.Add(this.txtCatetoA);
            this.Controls.Add(this.lblCatetoB);
            this.Controls.Add(this.txtCatetoB);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.lblResultado);
            this.MaximizeBox = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Name = "FormEjercicio25";
            this.Text = "Ejercicio 25 - Hipotenusa";
            this.ResumeLayout(false);
        }
        private System.Windows.Forms.Label lblCatetoA;
        private System.Windows.Forms.TextBox txtCatetoA;
        private System.Windows.Forms.Label lblCatetoB;
        private System.Windows.Forms.TextBox txtCatetoB;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label lblResultado;
    }
}
