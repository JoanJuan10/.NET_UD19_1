
namespace UD19_1
{
    partial class Ej2
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
            this.labelAddPelicula = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addPelicula = new System.Windows.Forms.Button();
            this.tituloPelicula = new System.Windows.Forms.TextBox();
            this.boxPeliculas = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // labelAddPelicula
            // 
            this.labelAddPelicula.AutoSize = true;
            this.labelAddPelicula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddPelicula.Location = new System.Drawing.Point(81, 85);
            this.labelAddPelicula.Name = "labelAddPelicula";
            this.labelAddPelicula.Size = new System.Drawing.Size(211, 20);
            this.labelAddPelicula.TabIndex = 0;
            this.labelAddPelicula.Text = "Escribe el titulo de la pelicula";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(581, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Peliculas";
            // 
            // addPelicula
            // 
            this.addPelicula.Location = new System.Drawing.Point(99, 244);
            this.addPelicula.Name = "addPelicula";
            this.addPelicula.Size = new System.Drawing.Size(170, 35);
            this.addPelicula.TabIndex = 2;
            this.addPelicula.Text = "Añadir";
            this.addPelicula.UseVisualStyleBackColor = true;
            this.addPelicula.Click += new System.EventHandler(this.addPelicula_Click);
            // 
            // tituloPelicula
            // 
            this.tituloPelicula.Location = new System.Drawing.Point(51, 155);
            this.tituloPelicula.Name = "tituloPelicula";
            this.tituloPelicula.Size = new System.Drawing.Size(280, 20);
            this.tituloPelicula.TabIndex = 3;
            // 
            // boxPeliculas
            // 
            this.boxPeliculas.FormattingEnabled = true;
            this.boxPeliculas.Location = new System.Drawing.Point(515, 154);
            this.boxPeliculas.Name = "boxPeliculas";
            this.boxPeliculas.Size = new System.Drawing.Size(203, 21);
            this.boxPeliculas.TabIndex = 4;
            this.boxPeliculas.SelectedIndexChanged += new System.EventHandler(this.boxPeliculas_SelectedIndexChanged);
            // 
            // Ej2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.boxPeliculas);
            this.Controls.Add(this.tituloPelicula);
            this.Controls.Add(this.addPelicula);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelAddPelicula);
            this.Name = "Ej2";
            this.Text = "Ej2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAddPelicula;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addPelicula;
        private System.Windows.Forms.TextBox tituloPelicula;
        private System.Windows.Forms.ComboBox boxPeliculas;
    }
}