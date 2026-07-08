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
            this.lblConsumo = new System.Windows.Forms.Label();
            this.txtConsumo = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();

            this.lblConsumo.AutoSize = true;
            this.lblConsumo.Location = new System.Drawing.Point(20, 20);
            this.lblConsumo.Text = "Consumo";

            this.txtConsumo.Location = new System.Drawing.Point(190, 17);
            this.txtConsumo.Name = "txtConsumo";
            this.txtConsumo.Size = new System.Drawing.Size(180, 23);

            this.btnAgregar.Location = new System.Drawing.Point(20, 58);
            this.btnAgregar.Size = new System.Drawing.Size(120, 28);
            this.btnAgregar.Text = "Agregar consumo";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);

            this.lblEstado.Location = new System.Drawing.Point(150, 63);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(230, 20);
            this.lblEstado.Text = "Faltan 130 consumos";

            this.lblResultado.Location = new System.Drawing.Point(20, 100);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(360, 30);
            this.lblResultado.Text = "";

            this.btnLimpiar.Location = new System.Drawing.Point(20, 148);
            this.btnLimpiar.Size = new System.Drawing.Size(100, 28);
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);

            this.btnVolver.Location = new System.Drawing.Point(270, 148);
            this.btnVolver.Size = new System.Drawing.Size(100, 28);
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);

            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 200);
            this.Controls.Add(this.lblConsumo);
            this.Controls.Add(this.txtConsumo);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnVolver);
            this.MaximizeBox = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Name = "FormEjercicio27";
            this.Text = "Ejercicio 27 - Consumos del restaurant";
            this.ResumeLayout(false);
        }
        private System.Windows.Forms.Label lblConsumo;
        private System.Windows.Forms.TextBox txtConsumo;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnVolver;
    }
}
