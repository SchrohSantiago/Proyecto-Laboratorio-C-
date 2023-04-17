namespace Ejercicio10
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
            this.txtDiasTrabajados = new System.Windows.Forms.TextBox();
            this.txtHorasDiarias = new System.Windows.Forms.TextBox();
            this.txtTarifaHoraria = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnCalcularSalario = new System.Windows.Forms.Button();
            this.lab7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labSalario = new System.Windows.Forms.Label();
            this.lab0 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ad = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDiasTrabajados
            // 
            this.txtDiasTrabajados.Location = new System.Drawing.Point(436, 199);
            this.txtDiasTrabajados.Name = "txtDiasTrabajados";
            this.txtDiasTrabajados.Size = new System.Drawing.Size(100, 20);
            this.txtDiasTrabajados.TabIndex = 0;
            // 
            // txtHorasDiarias
            // 
            this.txtHorasDiarias.Location = new System.Drawing.Point(245, 199);
            this.txtHorasDiarias.Name = "txtHorasDiarias";
            this.txtHorasDiarias.Size = new System.Drawing.Size(100, 20);
            this.txtHorasDiarias.TabIndex = 1;
            // 
            // txtTarifaHoraria
            // 
            this.txtTarifaHoraria.Location = new System.Drawing.Point(505, 117);
            this.txtTarifaHoraria.Name = "txtTarifaHoraria";
            this.txtTarifaHoraria.Size = new System.Drawing.Size(100, 20);
            this.txtTarifaHoraria.TabIndex = 2;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(329, 117);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(107, 20);
            this.txtYear.TabIndex = 3;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(165, 117);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 4;
            // 
            // btnCalcularSalario
            // 
            this.btnCalcularSalario.Location = new System.Drawing.Point(329, 268);
            this.btnCalcularSalario.Name = "btnCalcularSalario";
            this.btnCalcularSalario.Size = new System.Drawing.Size(113, 23);
            this.btnCalcularSalario.TabIndex = 5;
            this.btnCalcularSalario.Text = "Calcular Salario";
            this.btnCalcularSalario.UseVisualStyleBackColor = true;
            this.btnCalcularSalario.Click += new System.EventHandler(this.btnCalcularSalario_Click);
            // 
            // lab7
            // 
            this.lab7.AutoSize = true;
            this.lab7.Location = new System.Drawing.Point(518, 140);
            this.lab7.Name = "lab7";
            this.lab7.Size = new System.Drawing.Size(71, 13);
            this.lab7.TabIndex = 6;
            this.lab7.Text = "Tarifa Horaria";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(190, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nombre";
            // 
            // labSalario
            // 
            this.labSalario.AutoSize = true;
            this.labSalario.Location = new System.Drawing.Point(364, 315);
            this.labSalario.Name = "labSalario";
            this.labSalario.Size = new System.Drawing.Size(0, 13);
            this.labSalario.TabIndex = 8;
            // 
            // lab0
            // 
            this.lab0.AutoSize = true;
            this.lab0.Location = new System.Drawing.Point(423, 222);
            this.lab0.Name = "lab0";
            this.lab0.Size = new System.Drawing.Size(128, 13);
            this.lab0.TabIndex = 9;
            this.lab0.Text = "Dias trabajados en el mes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(341, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Año de Ingreso";
            // 
            // ad
            // 
            this.ad.AutoSize = true;
            this.ad.Location = new System.Drawing.Point(259, 222);
            this.ad.Name = "ad";
            this.ad.Size = new System.Drawing.Size(70, 13);
            this.ad.TabIndex = 11;
            this.ad.Text = "Horas Diarias";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(612, 35);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(82, 41);
            this.btnCerrar.TabIndex = 12;
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
            this.Controls.Add(this.ad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lab0);
            this.Controls.Add(this.labSalario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lab7);
            this.Controls.Add(this.btnCalcularSalario);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.txtTarifaHoraria);
            this.Controls.Add(this.txtHorasDiarias);
            this.Controls.Add(this.txtDiasTrabajados);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDiasTrabajados;
        private System.Windows.Forms.TextBox txtHorasDiarias;
        private System.Windows.Forms.TextBox txtTarifaHoraria;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnCalcularSalario;
        private System.Windows.Forms.Label lab7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labSalario;
        private System.Windows.Forms.Label lab0;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ad;
        private System.Windows.Forms.Button btnCerrar;
    }
}

