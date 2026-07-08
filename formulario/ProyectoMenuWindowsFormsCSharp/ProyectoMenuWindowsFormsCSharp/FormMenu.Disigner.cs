namespace ProyectoMenuWindowsFormsCSharp
{
    partial class FormMenu
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lstEjercicios = new System.Windows.Forms.ListBox();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();

            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(20, 15);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(220, 21);
            this.lblTitulo.Text = "Ejercicios de programacion";

            this.lstEjercicios.FormattingEnabled = true;
            this.lstEjercicios.ItemHeight = 15;
            this.lstEjercicios.Location = new System.Drawing.Point(20, 50);
            this.lstEjercicios.Name = "lstEjercicios";
            this.lstEjercicios.Size = new System.Drawing.Size(330, 304);
            this.lstEjercicios.DoubleClick += new System.EventHandler(this.lstEjercicios_DoubleClick);

            this.btnAbrir.Location = new System.Drawing.Point(20, 365);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(160, 32);
            this.btnAbrir.Text = "Abrir ejercicio";
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);

            this.btnSalir.Location = new System.Drawing.Point(190, 365);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(160, 32);
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);

            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 420);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lstEjercicios);
            this.Controls.Add(this.btnAbrir);
            this.Controls.Add(this.btnSalir);
            this.MaximizeBox = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Name = "FormMenu";
            this.Text = "Portafolio de ejercicios - C#";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.ListBox lstEjercicios;
        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.Button btnSalir;
    }
}
