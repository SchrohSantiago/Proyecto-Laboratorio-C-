namespace Ejercicio6
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPorcentajeOcupacion = new System.Windows.Forms.Button();
            this.btnUnoMenos = new System.Windows.Forms.Button();
            this.btnEntroUno = new System.Windows.Forms.Button();
            this.txtCupoMaximo = new System.Windows.Forms.TextBox();
            this.txtCantidadDePersonas = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labPorcentaje = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPorcentajeOcupacion
            // 
            this.btnPorcentajeOcupacion.Location = new System.Drawing.Point(336, 178);
            this.btnPorcentajeOcupacion.Name = "btnPorcentajeOcupacion";
            this.btnPorcentajeOcupacion.Size = new System.Drawing.Size(75, 23);
            this.btnPorcentajeOcupacion.TabIndex = 0;
            this.btnPorcentajeOcupacion.Text = "Ocupacion actual en la sala";
            this.btnPorcentajeOcupacion.UseVisualStyleBackColor = true;
            this.btnPorcentajeOcupacion.Click += new System.EventHandler(this.btnPorcentajeOcupacion_Click);
            // 
            // btnUnoMenos
            // 
            this.btnUnoMenos.Location = new System.Drawing.Point(206, 178);
            this.btnUnoMenos.Name = "btnUnoMenos";
            this.btnUnoMenos.Size = new System.Drawing.Size(75, 40);
            this.btnUnoMenos.TabIndex = 1;
            this.btnUnoMenos.Text = "Disminuir Cantidad";
            this.btnUnoMenos.UseVisualStyleBackColor = true;
            this.btnUnoMenos.Click += new System.EventHandler(this.btnUnoMenos_Click);
            // 
            // btnEntroUno
            // 
            this.btnEntroUno.Location = new System.Drawing.Point(462, 178);
            this.btnEntroUno.Name = "btnEntroUno";
            this.btnEntroUno.Size = new System.Drawing.Size(75, 40);
            this.btnEntroUno.TabIndex = 2;
            this.btnEntroUno.Text = "Aumentar Cantidad";
            this.btnEntroUno.UseVisualStyleBackColor = true;
            this.btnEntroUno.Click += new System.EventHandler(this.btnEntroUno_Click);
            // 
            // txtCupoMaximo
            // 
            this.txtCupoMaximo.Location = new System.Drawing.Point(230, 100);
            this.txtCupoMaximo.Name = "txtCupoMaximo";
            this.txtCupoMaximo.Size = new System.Drawing.Size(100, 20);
            this.txtCupoMaximo.TabIndex = 3;
            // 
            // txtCantidadDePersonas
            // 
            this.txtCantidadDePersonas.Location = new System.Drawing.Point(428, 100);
            this.txtCantidadDePersonas.Name = "txtCantidadDePersonas";
            this.txtCantidadDePersonas.Size = new System.Drawing.Size(100, 20);
            this.txtCantidadDePersonas.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(242, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Cupo Maximo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(425, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Cantidad de Personas";
            // 
            // labPorcentaje
            // 
            this.labPorcentaje.AutoSize = true;
            this.labPorcentaje.Location = new System.Drawing.Point(354, 243);
            this.labPorcentaje.Name = "labPorcentaje";
            this.labPorcentaje.Size = new System.Drawing.Size(0, 13);
            this.labPorcentaje.TabIndex = 7;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(600, 41);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 8;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.labPorcentaje);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCantidadDePersonas);
            this.Controls.Add(this.txtCupoMaximo);
            this.Controls.Add(this.btnEntroUno);
            this.Controls.Add(this.btnUnoMenos);
            this.Controls.Add(this.btnPorcentajeOcupacion);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPorcentajeOcupacion;
        private System.Windows.Forms.Button btnUnoMenos;
        private System.Windows.Forms.Button btnEntroUno;
        private System.Windows.Forms.TextBox txtCupoMaximo;
        private System.Windows.Forms.TextBox txtCantidadDePersonas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labPorcentaje;
        private System.Windows.Forms.Button btnCerrar;
    }
}

