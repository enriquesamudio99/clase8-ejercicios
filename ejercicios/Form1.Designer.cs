
namespace ejercicios
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
            this.fechaNacimientoPicker = new System.Windows.Forms.DateTimePicker();
            this.buttonVerificarEdad = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.resultadoVerificacionEdad = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.inputNumero = new System.Windows.Forms.TextBox();
            this.buttonPulgadas = new System.Windows.Forms.Button();
            this.buttonCentimetros = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.resultadoConversion = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.buttonLeerTexto = new System.Windows.Forms.Button();
            this.resultadoTexto = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // fechaNacimientoPicker
            // 
            this.fechaNacimientoPicker.Location = new System.Drawing.Point(308, 58);
            this.fechaNacimientoPicker.MaxDate = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            this.fechaNacimientoPicker.MinDate = new System.DateTime(1899, 1, 1, 0, 0, 0, 0);
            this.fechaNacimientoPicker.Name = "fechaNacimientoPicker";
            this.fechaNacimientoPicker.Size = new System.Drawing.Size(200, 20);
            this.fechaNacimientoPicker.TabIndex = 0;
            this.fechaNacimientoPicker.Value = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            // 
            // buttonVerificarEdad
            // 
            this.buttonVerificarEdad.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonVerificarEdad.FlatAppearance.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.buttonVerificarEdad.FlatAppearance.BorderSize = 0;
            this.buttonVerificarEdad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVerificarEdad.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVerificarEdad.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonVerificarEdad.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonVerificarEdad.Location = new System.Drawing.Point(532, 52);
            this.buttonVerificarEdad.Name = "buttonVerificarEdad";
            this.buttonVerificarEdad.Size = new System.Drawing.Size(111, 32);
            this.buttonVerificarEdad.TabIndex = 1;
            this.buttonVerificarEdad.Text = "Verificar";
            this.buttonVerificarEdad.UseVisualStyleBackColor = false;
            this.buttonVerificarEdad.Click += new System.EventHandler(this.buttonVerificarEdad_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 56);
            this.label1.Margin = new System.Windows.Forms.Padding(16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ingrese su fecha de nacimiento: ";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(21, 12);
            this.textBox1.Margin = new System.Windows.Forms.Padding(12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(744, 28);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "Verificar si cumple con la edad para ingresar al SMO (18 - 26 Años) ";
            // 
            // resultadoVerificacionEdad
            // 
            this.resultadoVerificacionEdad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.resultadoVerificacionEdad.Enabled = false;
            this.resultadoVerificacionEdad.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultadoVerificacionEdad.Location = new System.Drawing.Point(21, 107);
            this.resultadoVerificacionEdad.Margin = new System.Windows.Forms.Padding(3, 16, 3, 16);
            this.resultadoVerificacionEdad.Name = "resultadoVerificacionEdad";
            this.resultadoVerificacionEdad.Size = new System.Drawing.Size(744, 25);
            this.resultadoVerificacionEdad.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(28, 184);
            this.textBox2.Margin = new System.Windows.Forms.Padding(12);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(744, 28);
            this.textBox2.TabIndex = 5;
            this.textBox2.Text = "Conversor de Pulgadas a Centimentros y viceversa.";
            // 
            // inputNumero
            // 
            this.inputNumero.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputNumero.Location = new System.Drawing.Point(28, 227);
            this.inputNumero.Multiline = true;
            this.inputNumero.Name = "inputNumero";
            this.inputNumero.Size = new System.Drawing.Size(123, 35);
            this.inputNumero.TabIndex = 6;
            // 
            // buttonPulgadas
            // 
            this.buttonPulgadas.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonPulgadas.FlatAppearance.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.buttonPulgadas.FlatAppearance.BorderSize = 0;
            this.buttonPulgadas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPulgadas.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPulgadas.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonPulgadas.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonPulgadas.Location = new System.Drawing.Point(295, 228);
            this.buttonPulgadas.Name = "buttonPulgadas";
            this.buttonPulgadas.Size = new System.Drawing.Size(111, 32);
            this.buttonPulgadas.TabIndex = 7;
            this.buttonPulgadas.Text = "Pulgadas";
            this.buttonPulgadas.UseVisualStyleBackColor = false;
            this.buttonPulgadas.Click += new System.EventHandler(this.buttonPulgadas_Click);
            // 
            // buttonCentimetros
            // 
            this.buttonCentimetros.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonCentimetros.FlatAppearance.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.buttonCentimetros.FlatAppearance.BorderSize = 0;
            this.buttonCentimetros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCentimetros.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCentimetros.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonCentimetros.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonCentimetros.Location = new System.Drawing.Point(412, 228);
            this.buttonCentimetros.Name = "buttonCentimetros";
            this.buttonCentimetros.Size = new System.Drawing.Size(124, 32);
            this.buttonCentimetros.TabIndex = 8;
            this.buttonCentimetros.Text = "Centímetros";
            this.buttonCentimetros.UseVisualStyleBackColor = false;
            this.buttonCentimetros.Click += new System.EventHandler(this.buttonCentimetros_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(170, 233);
            this.label2.Margin = new System.Windows.Forms.Padding(16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 22);
            this.label2.TabIndex = 9;
            this.label2.Text = "Convertir a:";
            // 
            // resultadoConversion
            // 
            this.resultadoConversion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.resultadoConversion.Enabled = false;
            this.resultadoConversion.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultadoConversion.Location = new System.Drawing.Point(28, 296);
            this.resultadoConversion.Margin = new System.Windows.Forms.Padding(3, 16, 3, 16);
            this.resultadoConversion.Name = "resultadoConversion";
            this.resultadoConversion.Size = new System.Drawing.Size(744, 25);
            this.resultadoConversion.TabIndex = 10;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.White;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Enabled = false;
            this.textBox3.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(28, 349);
            this.textBox3.Margin = new System.Windows.Forms.Padding(12);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(220, 28);
            this.textBox3.TabIndex = 11;
            this.textBox3.Text = "Leer un archivo .txt";
            // 
            // buttonLeerTexto
            // 
            this.buttonLeerTexto.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonLeerTexto.FlatAppearance.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.buttonLeerTexto.FlatAppearance.BorderSize = 0;
            this.buttonLeerTexto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLeerTexto.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLeerTexto.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonLeerTexto.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonLeerTexto.Location = new System.Drawing.Point(28, 392);
            this.buttonLeerTexto.Name = "buttonLeerTexto";
            this.buttonLeerTexto.Size = new System.Drawing.Size(111, 32);
            this.buttonLeerTexto.TabIndex = 12;
            this.buttonLeerTexto.Text = "Leer .txt";
            this.buttonLeerTexto.UseVisualStyleBackColor = false;
            this.buttonLeerTexto.Click += new System.EventHandler(this.buttonLeerTexto_Click);
            // 
            // resultadoTexto
            // 
            this.resultadoTexto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.resultadoTexto.Enabled = false;
            this.resultadoTexto.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultadoTexto.Location = new System.Drawing.Point(28, 454);
            this.resultadoTexto.Margin = new System.Windows.Forms.Padding(3, 16, 3, 16);
            this.resultadoTexto.Multiline = true;
            this.resultadoTexto.Name = "resultadoTexto";
            this.resultadoTexto.Size = new System.Drawing.Size(744, 176);
            this.resultadoTexto.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1032, 655);
            this.Controls.Add(this.resultadoTexto);
            this.Controls.Add(this.buttonLeerTexto);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.resultadoConversion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonCentimetros);
            this.Controls.Add(this.buttonPulgadas);
            this.Controls.Add(this.inputNumero);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.resultadoVerificacionEdad);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonVerificarEdad);
            this.Controls.Add(this.fechaNacimientoPicker);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker fechaNacimientoPicker;
        private System.Windows.Forms.Button buttonVerificarEdad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox resultadoVerificacionEdad;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox inputNumero;
        private System.Windows.Forms.Button buttonPulgadas;
        private System.Windows.Forms.Button buttonCentimetros;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox resultadoConversion;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button buttonLeerTexto;
        private System.Windows.Forms.TextBox resultadoTexto;
    }
}

