namespace Ejercicio8
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
            this.txtNumeroB = new System.Windows.Forms.TextBox();
            this.txtNumeroA = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labNumeroB = new System.Windows.Forms.Label();
            this.labNumeroA = new System.Windows.Forms.Label();
            this.btnReemplazar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNumeroB
            // 
            this.txtNumeroB.Location = new System.Drawing.Point(419, 76);
            this.txtNumeroB.Name = "txtNumeroB";
            this.txtNumeroB.Size = new System.Drawing.Size(100, 20);
            this.txtNumeroB.TabIndex = 0;
            // 
            // txtNumeroA
            // 
            this.txtNumeroA.Location = new System.Drawing.Point(244, 76);
            this.txtNumeroA.Name = "txtNumeroA";
            this.txtNumeroA.Size = new System.Drawing.Size(100, 20);
            this.txtNumeroA.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(243, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Introducir Numero A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(418, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Introducir Numero B";
            // 
            // labNumeroB
            // 
            this.labNumeroB.AutoSize = true;
            this.labNumeroB.Location = new System.Drawing.Point(258, 216);
            this.labNumeroB.Name = "labNumeroB";
            this.labNumeroB.Size = new System.Drawing.Size(0, 13);
            this.labNumeroB.TabIndex = 4;
            // 
            // labNumeroA
            // 
            this.labNumeroA.AutoSize = true;
            this.labNumeroA.Location = new System.Drawing.Point(258, 179);
            this.labNumeroA.Name = "labNumeroA";
            this.labNumeroA.Size = new System.Drawing.Size(0, 13);
            this.labNumeroA.TabIndex = 5;
            // 
            // btnReemplazar
            // 
            this.btnReemplazar.Location = new System.Drawing.Point(316, 131);
            this.btnReemplazar.Name = "btnReemplazar";
            this.btnReemplazar.Size = new System.Drawing.Size(129, 23);
            this.btnReemplazar.TabIndex = 6;
            this.btnReemplazar.Text = "Reemplazar Posiciones";
            this.btnReemplazar.UseVisualStyleBackColor = true;
            this.btnReemplazar.Click += new System.EventHandler(this.btnReemplazar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(189, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Numero A: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(189, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Numero B:";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(578, 28);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 9;
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
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnReemplazar);
            this.Controls.Add(this.labNumeroA);
            this.Controls.Add(this.labNumeroB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNumeroA);
            this.Controls.Add(this.txtNumeroB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumeroB;
        private System.Windows.Forms.TextBox txtNumeroA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labNumeroB;
        private System.Windows.Forms.Label labNumeroA;
        private System.Windows.Forms.Button btnReemplazar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCerrar;
    }
}

