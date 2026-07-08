namespace ProyectoMenuWindowsFormsCSharp
{
    partial class FormEjercicio20
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }
        private void InitializeComponent()
        {
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblA = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.lblB = new System.Windows.Forms.Label();
            this.txtB = new System.Windows.Forms.TextBox();
            this.lblC = new System.Windows.Forms.Label();
            this.txtC = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();

            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(20, 15);
            this.lblInfo.Text = "Ecuacion: aX2 + bX + c = 0";

            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(20, 50);
            this.lblA.Text = "Coeficiente a";

            this.txtA.Location = new System.Drawing.Point(190, 47);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(180, 23);

            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(20, 85);
            this.lblB.Text = "Coeficiente b";

            this.txtB.Location = new System.Drawing.Point(190, 82);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(180, 23);

            this.lblC.AutoSize = true;
            this.lblC.Location = new System.Drawing.Point(20, 120);
            this.lblC.Text = "Coeficiente c";

            this.txtC.Location = new System.Drawing.Point(190, 117);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(180, 23);

            this.btnCalcular.Location = new System.Drawing.Point(20, 158);
            this.btnCalcular.Size = new System.Drawing.Size(100, 28);
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);

            this.btnLimpiar.Location = new System.Drawing.Point(130, 158);
            this.btnLimpiar.Size = new System.Drawing.Size(100, 28);
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);

            this.btnVolver.Location = new System.Drawing.Point(240, 158);
            this.btnVolver.Size = new System.Drawing.Size(100, 28);
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);

            this.lblResultado.Location = new System.Drawing.Point(20, 200);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(360, 50);
            this.lblResultado.Text = "";

            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 275);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.lblC);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.lblResultado);
            this.MaximizeBox = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Name = "FormEjercicio20";
            this.Text = "Ejercicio 20 - Ecuacion cuadratica";
            this.ResumeLayout(false);
        }
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label lblResultado;
    }
}
