
namespace UD19_1
{
    partial class Ej1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.botonSaludo = new System.Windows.Forms.Button();
            this.saludoTitulo = new System.Windows.Forms.Label();
            this.saludoBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // botonSaludo
            // 
            this.botonSaludo.Location = new System.Drawing.Point(276, 284);
            this.botonSaludo.Name = "botonSaludo";
            this.botonSaludo.Size = new System.Drawing.Size(248, 47);
            this.botonSaludo.TabIndex = 0;
            this.botonSaludo.Text = "¡Saludar!";
            this.botonSaludo.UseVisualStyleBackColor = true;
            this.botonSaludo.Click += new System.EventHandler(this.botonSaludo_Click);
            // 
            // saludoTitulo
            // 
            this.saludoTitulo.AutoSize = true;
            this.saludoTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saludoTitulo.Location = new System.Drawing.Point(249, 82);
            this.saludoTitulo.Name = "saludoTitulo";
            this.saludoTitulo.Size = new System.Drawing.Size(327, 26);
            this.saludoTitulo.TabIndex = 1;
            this.saludoTitulo.Text = "Escribe un nombre para saludar.";
            // 
            // saludoBox
            // 
            this.saludoBox.Location = new System.Drawing.Point(238, 180);
            this.saludoBox.Name = "saludoBox";
            this.saludoBox.Size = new System.Drawing.Size(338, 20);
            this.saludoBox.TabIndex = 2;
            // 
            // Ej1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.saludoBox);
            this.Controls.Add(this.saludoTitulo);
            this.Controls.Add(this.botonSaludo);
            this.Name = "Ej1";
            this.Text = "Ej1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonSaludo;
        private System.Windows.Forms.Label saludoTitulo;
        private System.Windows.Forms.TextBox saludoBox;
    }
}