namespace ProyectoMenuWindowsFormsCSharp
{
    partial class FormEjercicio09
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }
        private void InitializeComponent()
        {
            this.lblNota = new System.Windows.Forms.Label();
            this.txtNota = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnTerminar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.lstResultados = new System.Windows.Forms.ListBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.SuspendLayout();

            this.lblNota.AutoSize = true;
            this.lblNota.Location = new System.Drawing.Point(20, 20);
            this.lblNota.Text = "Nota del estudiante";

            this.txtNota.Location = new System.Drawing.Point(200, 17);
            this.txtNota.Name = "txtNota";
            this.txtNota.Size = new System.Drawing.Size(140, 23);

            this.btnAgregar.Location = new System.Drawing.Point(20, 55);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(120, 28);
            this.btnAgregar.Text = "Agregar nota";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);

            this.btnTerminar.Location = new System.Drawing.Point(150, 55);
            this.btnTerminar.Name = "btnTerminar";
            this.btnTerminar.Size = new System.Drawing.Size(120, 28);
            this.btnTerminar.Text = "Ver resultados";
            this.btnTerminar.Enabled = false;
            this.btnTerminar.UseVisualStyleBackColor = true;
            this.btnTerminar.Click += new System.EventHandler(this.btnTerminar_Click);

            this.lblEstado.Location = new System.Drawing.Point(20, 90);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(320, 20);
            this.lblEstado.Text = "Ingresa al menos una nota";

            this.lstResultados.FormattingEnabled = true;
            this.lstResultados.Location = new System.Drawing.Point(20, 115);
            this.lstResultados.Name = "lstResultados";
            this.lstResultados.Size = new System.Drawing.Size(330, 160);

            this.btnLimpiar.Location = new System.Drawing.Point(20, 290);
            this.btnLimpiar.Size = new System.Drawing.Size(100, 28);
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);

            this.btnVolver.Location = new System.Drawing.Point(250, 290);
            this.btnVolver.Size = new System.Drawing.Size(100, 28);
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);

            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 340);
            this.Controls.Add(this.lblNota);
            this.Controls.Add(this.txtNota);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnTerminar);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lstResultados);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnVolver);
            this.MaximizeBox = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Name = "FormEjercicio09";
            this.Text = "Ejercicio 09 - Notas de un estudiante";
            this.ResumeLayout(false);
        }
        private System.Windows.Forms.Label lblNota;
        private System.Windows.Forms.TextBox txtNota;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnTerminar;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.ListBox lstResultados;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnVolver;
    }
}
