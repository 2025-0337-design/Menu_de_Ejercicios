namespace ProyectoMenuWindowsFormsCSharp
{
    partial class FormEjercicio07
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.lblContador = new System.Windows.Forms.Label();
            this.lblHoras = new System.Windows.Forms.Label();
            this.txtHoras = new System.Windows.Forms.TextBox();
            this.lblTarifa = new System.Windows.Forms.Label();
            this.txtTarifa = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lstTrabajadores = new System.Windows.Forms.ListBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();

            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(20, 20);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(135, 15);
            this.lblCantidad.Text = "Cantidad de trabajadores";

            this.txtCantidad.Location = new System.Drawing.Point(220, 17);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 23);

            this.btnIniciar.Location = new System.Drawing.Point(20, 50);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(100, 28);
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);

            this.lblContador.AutoSize = true;
            this.lblContador.Location = new System.Drawing.Point(130, 56);
            this.lblContador.Name = "lblContador";
            this.lblContador.Size = new System.Drawing.Size(120, 15);
            this.lblContador.Text = "Ingresa la cantidad";

            this.lblHoras.AutoSize = true;
            this.lblHoras.Location = new System.Drawing.Point(20, 95);
            this.lblHoras.Name = "lblHoras";
            this.lblHoras.Size = new System.Drawing.Size(95, 15);
            this.lblHoras.Text = "Horas trabajadas";

            this.txtHoras.Enabled = false;
            this.txtHoras.Location = new System.Drawing.Point(220, 92);
            this.txtHoras.Name = "txtHoras";
            this.txtHoras.Size = new System.Drawing.Size(100, 23);

            this.lblTarifa.AutoSize = true;
            this.lblTarifa.Location = new System.Drawing.Point(20, 125);
            this.lblTarifa.Name = "lblTarifa";
            this.lblTarifa.Size = new System.Drawing.Size(38, 15);
            this.lblTarifa.Text = "Tarifa";

            this.txtTarifa.Enabled = false;
            this.txtTarifa.Location = new System.Drawing.Point(220, 122);
            this.txtTarifa.Name = "txtTarifa";
            this.txtTarifa.Size = new System.Drawing.Size(100, 23);

            this.btnAgregar.Enabled = false;
            this.btnAgregar.Location = new System.Drawing.Point(20, 155);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(150, 28);
            this.btnAgregar.Text = "Agregar trabajador";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);

            this.lstTrabajadores.FormattingEnabled = true;
            this.lstTrabajadores.Location = new System.Drawing.Point(20, 195);
            this.lstTrabajadores.Name = "lstTrabajadores";
            this.lstTrabajadores.Size = new System.Drawing.Size(320, 130);

            this.lblResultado.Location = new System.Drawing.Point(20, 335);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(320, 30);
            this.lblResultado.Text = "";

            this.btnLimpiar.Location = new System.Drawing.Point(20, 375);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(100, 30);
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);

            this.btnVolver.Location = new System.Drawing.Point(240, 375);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(100, 30);
            this.btnVolver.Text = "Salir";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);

            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 420);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.lblContador);
            this.Controls.Add(this.lblHoras);
            this.Controls.Add(this.txtHoras);
            this.Controls.Add(this.lblTarifa);
            this.Controls.Add(this.txtTarifa);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lstTrabajadores);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnVolver);
            this.MaximizeBox = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Name = "FormEjercicio07";
            this.Text = "Ejercicio 07 - Suma de salarios de varios trabajadores";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Label lblContador;
        private System.Windows.Forms.Label lblHoras;
        private System.Windows.Forms.TextBox txtHoras;
        private System.Windows.Forms.Label lblTarifa;
        private System.Windows.Forms.TextBox txtTarifa;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ListBox lstTrabajadores;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnVolver;
    }
}
