namespace ProyectoMenuWindowsFormsCSharp
{
    partial class FormMenu
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlTop         = new System.Windows.Forms.Panel();
            this.lblTitulo      = new System.Windows.Forms.Label();
            this.lblSubtitulo   = new System.Windows.Forms.Label();
            this.pnlCategorias  = new System.Windows.Forms.Panel();
            this.lblCatHeader   = new System.Windows.Forms.Label();
            this.btnCat1        = new System.Windows.Forms.Button();
            this.btnCat2        = new System.Windows.Forms.Button();
            this.btnCat3        = new System.Windows.Forms.Button();
            this.btnCat4        = new System.Windows.Forms.Button();
            this.pnlDerecho     = new System.Windows.Forms.Panel();
            this.lblCatActual   = new System.Windows.Forms.Label();
            this.lblInstruccion = new System.Windows.Forms.Label();
            this.lstEjercicios  = new System.Windows.Forms.ListBox();
            this.pnlBottom      = new System.Windows.Forms.Panel();
            this.btnAbrir       = new System.Windows.Forms.Button();
            this.lblTotal       = new System.Windows.Forms.Label();
            this.btnSalir       = new System.Windows.Forms.Button();
            this.pnlTop.SuspendLayout();
            this.pnlCategorias.SuspendLayout();
            this.pnlDerecho.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            this.SuspendLayout();

            // pnlTop
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(28, 40, 51);
            this.pnlTop.Controls.Add(this.lblTitulo);
            this.pnlTop.Controls.Add(this.lblSubtitulo);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Height = 68;
            this.pnlTop.Name = "pnlTop";

            // lblTitulo
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(16, 10);
            this.lblTitulo.Text = "Portafolio de Ejercicios";

            // lblSubtitulo
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(149, 165, 166);
            this.lblSubtitulo.Location = new System.Drawing.Point(18, 40);
            this.lblSubtitulo.Text = "Programacion en C#  -  Windows Forms";

            // pnlCategorias
            this.pnlCategorias.BackColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.pnlCategorias.Controls.Add(this.lblCatHeader);
            this.pnlCategorias.Controls.Add(this.btnCat1);
            this.pnlCategorias.Controls.Add(this.btnCat2);
            this.pnlCategorias.Controls.Add(this.btnCat3);
            this.pnlCategorias.Controls.Add(this.btnCat4);
            this.pnlCategorias.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlCategorias.Width = 175;
            this.pnlCategorias.Name = "pnlCategorias";

            // lblCatHeader
            this.lblCatHeader.AutoSize = false;
            this.lblCatHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCatHeader.Height = 35;
            this.lblCatHeader.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblCatHeader.ForeColor = System.Drawing.Color.FromArgb(149, 165, 166);
            this.lblCatHeader.Text = "  CATEGORIAS";
            this.lblCatHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // btnCat1 - Condicionales
            this.btnCat1.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCat1.Height = 65;
            this.btnCat1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCat1.FlatAppearance.BorderSize = 0;
            this.btnCat1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(52, 73, 94);
            this.btnCat1.BackColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.btnCat1.ForeColor = System.Drawing.Color.White;
            this.btnCat1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCat1.Text = "  if / else\r\n  Condicionales";
            this.btnCat1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCat1.Name = "btnCat1";
            this.btnCat1.Tag = "0";
            this.btnCat1.Click += new System.EventHandler(this.btnCategoria_Click);

            // btnCat2 - Bucles for
            this.btnCat2.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCat2.Height = 65;
            this.btnCat2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCat2.FlatAppearance.BorderSize = 0;
            this.btnCat2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(52, 73, 94);
            this.btnCat2.BackColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.btnCat2.ForeColor = System.Drawing.Color.White;
            this.btnCat2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCat2.Text = "  for\r\n  Bucles con for";
            this.btnCat2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCat2.Name = "btnCat2";
            this.btnCat2.Tag = "1";
            this.btnCat2.Click += new System.EventHandler(this.btnCategoria_Click);

            // btnCat3 - Bucles while
            this.btnCat3.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCat3.Height = 65;
            this.btnCat3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCat3.FlatAppearance.BorderSize = 0;
            this.btnCat3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(52, 73, 94);
            this.btnCat3.BackColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.btnCat3.ForeColor = System.Drawing.Color.White;
            this.btnCat3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCat3.Text = "  while / do-while\r\n  Bucles con while";
            this.btnCat3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCat3.Name = "btnCat3";
            this.btnCat3.Tag = "2";
            this.btnCat3.Click += new System.EventHandler(this.btnCategoria_Click);

            // btnCat4 - Matematicas
            this.btnCat4.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCat4.Height = 65;
            this.btnCat4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCat4.FlatAppearance.BorderSize = 0;
            this.btnCat4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(52, 73, 94);
            this.btnCat4.BackColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.btnCat4.ForeColor = System.Drawing.Color.White;
            this.btnCat4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCat4.Text = "  Matematicas";
            this.btnCat4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCat4.Name = "btnCat4";
            this.btnCat4.Tag = "3";
            this.btnCat4.Click += new System.EventHandler(this.btnCategoria_Click);

            // pnlDerecho
            this.pnlDerecho.BackColor = System.Drawing.Color.White;
            this.pnlDerecho.Controls.Add(this.lstEjercicios);
            this.pnlDerecho.Controls.Add(this.lblInstruccion);
            this.pnlDerecho.Controls.Add(this.lblCatActual);
            this.pnlDerecho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDerecho.Name = "pnlDerecho";
            this.pnlDerecho.Padding = new System.Windows.Forms.Padding(12, 10, 12, 10);

            // lblCatActual
            this.lblCatActual.AutoSize = false;
            this.lblCatActual.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCatActual.Height = 32;
            this.lblCatActual.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblCatActual.ForeColor = System.Drawing.Color.FromArgb(28, 40, 51);
            this.lblCatActual.Text = "Selecciona una categoria";
            this.lblCatActual.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.lblCatActual.Name = "lblCatActual";

            // lblInstruccion
            this.lblInstruccion.AutoSize = false;
            this.lblInstruccion.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblInstruccion.Height = 20;
            this.lblInstruccion.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblInstruccion.ForeColor = System.Drawing.Color.Gray;
            this.lblInstruccion.Text = "  Doble clic o boton Abrir para ejecutar un ejercicio";
            this.lblInstruccion.Name = "lblInstruccion";

            // lstEjercicios
            this.lstEjercicios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstEjercicios.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lstEjercicios.ItemHeight = 22;
            this.lstEjercicios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstEjercicios.Name = "lstEjercicios";
            this.lstEjercicios.DoubleClick += new System.EventHandler(this.lstEjercicios_DoubleClick);

            // pnlBottom
            this.pnlBottom.BackColor = System.Drawing.Color.FromArgb(236, 240, 241);
            this.pnlBottom.Controls.Add(this.btnSalir);
            this.pnlBottom.Controls.Add(this.lblTotal);
            this.pnlBottom.Controls.Add(this.btnAbrir);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Height = 58;
            this.pnlBottom.Name = "pnlBottom";

            // btnAbrir
            this.btnAbrir.Location = new System.Drawing.Point(12, 12);
            this.btnAbrir.Size = new System.Drawing.Size(140, 34);
            this.btnAbrir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbrir.FlatAppearance.BorderSize = 0;
            this.btnAbrir.BackColor = System.Drawing.Color.FromArgb(39, 174, 96);
            this.btnAbrir.ForeColor = System.Drawing.Color.White;
            this.btnAbrir.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAbrir.Text = "Abrir ejercicio";
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);

            // lblTotal
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(165, 20);
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblTotal.ForeColor = System.Drawing.Color.Gray;
            this.lblTotal.Text = "30 ejercicios en total";
            this.lblTotal.Name = "lblTotal";

            // btnSalir
            this.btnSalir.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.btnSalir.Location = new System.Drawing.Point(430, 12);
            this.btnSalir.Size = new System.Drawing.Size(130, 34);
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(231, 76, 60);
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSalir.Text = "Salir";
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);

            // FormMenu
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 470);
            this.Controls.Add(this.pnlDerecho);
            this.Controls.Add(this.pnlCategorias);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlBottom);
            this.MaximizeBox = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Name = "FormMenu";
            this.Text = "Portafolio de Ejercicios - C#";
            this.pnlTop.ResumeLayout(false);
            this.pnlCategorias.ResumeLayout(false);
            this.pnlDerecho.ResumeLayout(false);
            this.pnlBottom.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel   pnlTop;
        private System.Windows.Forms.Label   lblTitulo;
        private System.Windows.Forms.Label   lblSubtitulo;
        private System.Windows.Forms.Panel   pnlCategorias;
        private System.Windows.Forms.Label   lblCatHeader;
        private System.Windows.Forms.Button  btnCat1;
        private System.Windows.Forms.Button  btnCat2;
        private System.Windows.Forms.Button  btnCat3;
        private System.Windows.Forms.Button  btnCat4;
        private System.Windows.Forms.Panel   pnlDerecho;
        private System.Windows.Forms.Label   lblCatActual;
        private System.Windows.Forms.Label   lblInstruccion;
        private System.Windows.Forms.ListBox lstEjercicios;
        private System.Windows.Forms.Panel   pnlBottom;
        private System.Windows.Forms.Button  btnAbrir;
        private System.Windows.Forms.Label   lblTotal;
        private System.Windows.Forms.Button  btnSalir;
    }
}
