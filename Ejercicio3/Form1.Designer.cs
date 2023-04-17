namespace Ejercicio3
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
            this.labCantidadArena = new System.Windows.Forms.Label();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.txtAncho = new System.Windows.Forms.TextBox();
            this.labAltura = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnArenaTotal = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labCantidadArena
            // 
            this.labCantidadArena.AutoSize = true;
            this.labCantidadArena.Location = new System.Drawing.Point(313, 256);
            this.labCantidadArena.Name = "labCantidadArena";
            this.labCantidadArena.Size = new System.Drawing.Size(0, 13);
            this.labCantidadArena.TabIndex = 2;
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(256, 147);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(100, 20);
            this.txtAltura.TabIndex = 3;
            // 
            // txtAncho
            // 
            this.txtAncho.Location = new System.Drawing.Point(437, 147);
            this.txtAncho.Name = "txtAncho";
            this.txtAncho.Size = new System.Drawing.Size(100, 20);
            this.txtAncho.TabIndex = 4;
            // 
            // labAltura
            // 
            this.labAltura.AutoSize = true;
            this.labAltura.Location = new System.Drawing.Point(269, 170);
            this.labAltura.Name = "labAltura";
            this.labAltura.Size = new System.Drawing.Size(74, 13);
            this.labAltura.TabIndex = 5;
            this.labAltura.Text = "Agregar Altura";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(448, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Agregar Ancho";
            // 
            // btnArenaTotal
            // 
            this.btnArenaTotal.Location = new System.Drawing.Point(307, 207);
            this.btnArenaTotal.Name = "btnArenaTotal";
            this.btnArenaTotal.Size = new System.Drawing.Size(176, 23);
            this.btnArenaTotal.TabIndex = 7;
            this.btnArenaTotal.Text = "Calcular la cantidad de arena necesaria";
            this.btnArenaTotal.UseVisualStyleBackColor = true;
            this.btnArenaTotal.Click += new System.EventHandler(this.btnArenaTotal_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(574, 78);
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
            this.Controls.Add(this.btnArenaTotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labAltura);
            this.Controls.Add(this.txtAncho);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.labCantidadArena);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labCantidadArena;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.TextBox txtAncho;
        private System.Windows.Forms.Label labAltura;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnArenaTotal;
        private System.Windows.Forms.Button btnCerrar;
    }
}

