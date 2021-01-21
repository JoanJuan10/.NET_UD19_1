
namespace UD19_1
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
            this.EjercicioTitulo = new System.Windows.Forms.Label();
            this.ej1Button = new System.Windows.Forms.Button();
            this.ej2Button = new System.Windows.Forms.Button();
            this.ej3Button = new System.Windows.Forms.Button();
            this.ej4Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EjercicioTitulo
            // 
            this.EjercicioTitulo.AutoSize = true;
            this.EjercicioTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EjercicioTitulo.Location = new System.Drawing.Point(53, 28);
            this.EjercicioTitulo.Name = "EjercicioTitulo";
            this.EjercicioTitulo.Size = new System.Drawing.Size(361, 26);
            this.EjercicioTitulo.TabIndex = 0;
            this.EjercicioTitulo.Text = "Elige el ejercicio que quiera ejecutar";
            // 
            // ej1Button
            // 
            this.ej1Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ej1Button.Location = new System.Drawing.Point(54, 105);
            this.ej1Button.Name = "ej1Button";
            this.ej1Button.Size = new System.Drawing.Size(219, 37);
            this.ej1Button.TabIndex = 1;
            this.ej1Button.Text = "Ejercicio 1";
            this.ej1Button.UseVisualStyleBackColor = true;
            this.ej1Button.Click += new System.EventHandler(this.ej1Button_Click);
            // 
            // ej2Button
            // 
            this.ej2Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ej2Button.Location = new System.Drawing.Point(412, 103);
            this.ej2Button.Name = "ej2Button";
            this.ej2Button.Size = new System.Drawing.Size(233, 38);
            this.ej2Button.TabIndex = 2;
            this.ej2Button.Text = "Ejercicio 2";
            this.ej2Button.UseVisualStyleBackColor = true;
            this.ej2Button.Click += new System.EventHandler(this.ej2Button_Click);
            // 
            // ej3Button
            // 
            this.ej3Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ej3Button.Location = new System.Drawing.Point(53, 235);
            this.ej3Button.Name = "ej3Button";
            this.ej3Button.Size = new System.Drawing.Size(219, 36);
            this.ej3Button.TabIndex = 3;
            this.ej3Button.Text = "Ejercicio 3";
            this.ej3Button.UseVisualStyleBackColor = true;
            this.ej3Button.Click += new System.EventHandler(this.ej3Button_Click);
            // 
            // ej4Button
            // 
            this.ej4Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ej4Button.Location = new System.Drawing.Point(420, 231);
            this.ej4Button.Name = "ej4Button";
            this.ej4Button.Size = new System.Drawing.Size(224, 39);
            this.ej4Button.TabIndex = 4;
            this.ej4Button.Text = "Ejercicio 4";
            this.ej4Button.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ej4Button);
            this.Controls.Add(this.ej3Button);
            this.Controls.Add(this.ej2Button);
            this.Controls.Add(this.ej1Button);
            this.Controls.Add(this.EjercicioTitulo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EjercicioTitulo;
        private System.Windows.Forms.Button ej1Button;
        private System.Windows.Forms.Button ej2Button;
        private System.Windows.Forms.Button ej3Button;
        private System.Windows.Forms.Button ej4Button;
    }
}

