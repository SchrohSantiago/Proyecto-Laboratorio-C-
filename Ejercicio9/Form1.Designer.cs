namespace Ejercicio9
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
            this.btnSumarHoras = new System.Windows.Forms.Button();
            this.txtHoraA = new System.Windows.Forms.TextBox();
            this.txtMinutoA = new System.Windows.Forms.TextBox();
            this.txtSegundoA = new System.Windows.Forms.TextBox();
            this.txtSegundoB = new System.Windows.Forms.TextBox();
            this.txtMinutoB = new System.Windows.Forms.TextBox();
            this.txtHoraB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labResultado = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSumarHoras
            // 
            this.btnSumarHoras.Location = new System.Drawing.Point(347, 153);
            this.btnSumarHoras.Name = "btnSumarHoras";
            this.btnSumarHoras.Size = new System.Drawing.Size(105, 23);
            this.btnSumarHoras.TabIndex = 0;
            this.btnSumarHoras.Text = "Sumar Horas";
            this.btnSumarHoras.UseVisualStyleBackColor = true;
            this.btnSumarHoras.Click += new System.EventHandler(this.btnSumarHoras_Click);
            // 
            // txtHoraA
            // 
            this.txtHoraA.Location = new System.Drawing.Point(21, 77);
            this.txtHoraA.Name = "txtHoraA";
            this.txtHoraA.Size = new System.Drawing.Size(100, 20);
            this.txtHoraA.TabIndex = 1;
            // 
            // txtMinutoA
            // 
            this.txtMinutoA.Location = new System.Drawing.Point(140, 77);
            this.txtMinutoA.Name = "txtMinutoA";
            this.txtMinutoA.Size = new System.Drawing.Size(100, 20);
            this.txtMinutoA.TabIndex = 2;
            // 
            // txtSegundoA
            // 
            this.txtSegundoA.Location = new System.Drawing.Point(263, 77);
            this.txtSegundoA.Name = "txtSegundoA";
            this.txtSegundoA.Size = new System.Drawing.Size(100, 20);
            this.txtSegundoA.TabIndex = 3;
            this.txtSegundoA.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtSegundoB
            // 
            this.txtSegundoB.Location = new System.Drawing.Point(674, 77);
            this.txtSegundoB.Name = "txtSegundoB";
            this.txtSegundoB.Size = new System.Drawing.Size(100, 20);
            this.txtSegundoB.TabIndex = 4;
            // 
            // txtMinutoB
            // 
            this.txtMinutoB.Location = new System.Drawing.Point(555, 77);
            this.txtMinutoB.Name = "txtMinutoB";
            this.txtMinutoB.Size = new System.Drawing.Size(100, 20);
            this.txtMinutoB.TabIndex = 5;
            // 
            // txtHoraB
            // 
            this.txtHoraB.Location = new System.Drawing.Point(436, 77);
            this.txtHoraB.Name = "txtHoraB";
            this.txtHoraB.Size = new System.Drawing.Size(100, 20);
            this.txtHoraB.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Hora";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(169, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Minutos";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(286, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Segundos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(470, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Hora";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(586, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Minutos";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(697, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Segundos";
            // 
            // labResultado
            // 
            this.labResultado.AutoSize = true;
            this.labResultado.Location = new System.Drawing.Point(382, 202);
            this.labResultado.Name = "labResultado";
            this.labResultado.Size = new System.Drawing.Size(0, 13);
            this.labResultado.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label9.Location = new System.Drawing.Point(572, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "TIEMPO B";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label10.Location = new System.Drawing.Point(169, 36);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "TIEMPO A";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.labResultado);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtHoraB);
            this.Controls.Add(this.txtMinutoB);
            this.Controls.Add(this.txtSegundoB);
            this.Controls.Add(this.txtSegundoA);
            this.Controls.Add(this.txtMinutoA);
            this.Controls.Add(this.txtHoraA);
            this.Controls.Add(this.btnSumarHoras);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSumarHoras;
        private System.Windows.Forms.TextBox txtHoraA;
        private System.Windows.Forms.TextBox txtMinutoA;
        private System.Windows.Forms.TextBox txtSegundoA;
        private System.Windows.Forms.TextBox txtSegundoB;
        private System.Windows.Forms.TextBox txtMinutoB;
        private System.Windows.Forms.TextBox txtHoraB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labResultado;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}

