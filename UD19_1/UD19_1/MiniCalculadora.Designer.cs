
namespace UD19_1
{
    partial class MiniCalculadora
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
            this.textoCalculadora = new System.Windows.Forms.Label();
            this.restar = new System.Windows.Forms.Button();
            this.sumar = new System.Windows.Forms.Button();
            this.resolver = new System.Windows.Forms.Button();
            this.resetCalculadora = new System.Windows.Forms.Button();
            this.boton0 = new System.Windows.Forms.Button();
            this.multiplicar = new System.Windows.Forms.Button();
            this.dividir = new System.Windows.Forms.Button();
            this.boton1 = new System.Windows.Forms.Button();
            this.boton2 = new System.Windows.Forms.Button();
            this.boton3 = new System.Windows.Forms.Button();
            this.boton5 = new System.Windows.Forms.Button();
            this.boton4 = new System.Windows.Forms.Button();
            this.boton6 = new System.Windows.Forms.Button();
            this.boton7 = new System.Windows.Forms.Button();
            this.boton8 = new System.Windows.Forms.Button();
            this.boton9 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textoCalculadora
            // 
            this.textoCalculadora.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textoCalculadora.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoCalculadora.ForeColor = System.Drawing.Color.White;
            this.textoCalculadora.Location = new System.Drawing.Point(-2, -1);
            this.textoCalculadora.Name = "textoCalculadora";
            this.textoCalculadora.Size = new System.Drawing.Size(310, 110);
            this.textoCalculadora.TabIndex = 0;
            this.textoCalculadora.Text = "0";
            this.textoCalculadora.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // restar
            // 
            this.restar.BackColor = System.Drawing.Color.Orange;
            this.restar.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.restar.Location = new System.Drawing.Point(231, 260);
            this.restar.Name = "restar";
            this.restar.Size = new System.Drawing.Size(77, 79);
            this.restar.TabIndex = 3;
            this.restar.Text = "-";
            this.restar.UseVisualStyleBackColor = false;
            this.restar.Click += new System.EventHandler(this.restar_Click);
            // 
            // sumar
            // 
            this.sumar.BackColor = System.Drawing.Color.Orange;
            this.sumar.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sumar.Location = new System.Drawing.Point(231, 336);
            this.sumar.Name = "sumar";
            this.sumar.Size = new System.Drawing.Size(77, 71);
            this.sumar.TabIndex = 4;
            this.sumar.Text = "+";
            this.sumar.UseVisualStyleBackColor = false;
            this.sumar.Click += new System.EventHandler(this.sumar_Click);
            // 
            // resolver
            // 
            this.resolver.BackColor = System.Drawing.Color.Orange;
            this.resolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resolver.Location = new System.Drawing.Point(63, 404);
            this.resolver.Name = "resolver";
            this.resolver.Size = new System.Drawing.Size(245, 51);
            this.resolver.TabIndex = 5;
            this.resolver.Text = "=";
            this.resolver.UseVisualStyleBackColor = false;
            this.resolver.Click += new System.EventHandler(this.resolver_Click);
            // 
            // resetCalculadora
            // 
            this.resetCalculadora.BackColor = System.Drawing.Color.Gray;
            this.resetCalculadora.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetCalculadora.ForeColor = System.Drawing.SystemColors.ControlText;
            this.resetCalculadora.Location = new System.Drawing.Point(-2, 404);
            this.resetCalculadora.Name = "resetCalculadora";
            this.resetCalculadora.Size = new System.Drawing.Size(68, 51);
            this.resetCalculadora.TabIndex = 6;
            this.resetCalculadora.Text = "C";
            this.resetCalculadora.UseVisualStyleBackColor = false;
            this.resetCalculadora.Click += new System.EventHandler(this.resetCalculadora_Click);
            // 
            // boton0
            // 
            this.boton0.BackColor = System.Drawing.Color.White;
            this.boton0.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton0.Location = new System.Drawing.Point(-2, 336);
            this.boton0.Name = "boton0";
            this.boton0.Size = new System.Drawing.Size(235, 71);
            this.boton0.TabIndex = 7;
            this.boton0.Text = "0";
            this.boton0.UseVisualStyleBackColor = false;
            this.boton0.Click += new System.EventHandler(this.boton0_Click);
            // 
            // multiplicar
            // 
            this.multiplicar.BackColor = System.Drawing.Color.Orange;
            this.multiplicar.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiplicar.Location = new System.Drawing.Point(231, 183);
            this.multiplicar.Name = "multiplicar";
            this.multiplicar.Size = new System.Drawing.Size(77, 79);
            this.multiplicar.TabIndex = 8;
            this.multiplicar.Text = "X";
            this.multiplicar.UseVisualStyleBackColor = false;
            this.multiplicar.Click += new System.EventHandler(this.multiplicar_Click);
            // 
            // dividir
            // 
            this.dividir.BackColor = System.Drawing.Color.Orange;
            this.dividir.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dividir.Location = new System.Drawing.Point(231, 109);
            this.dividir.Name = "dividir";
            this.dividir.Size = new System.Drawing.Size(77, 79);
            this.dividir.TabIndex = 9;
            this.dividir.Text = "/";
            this.dividir.UseVisualStyleBackColor = false;
            this.dividir.Click += new System.EventHandler(this.dividir_Click);
            // 
            // boton1
            // 
            this.boton1.BackColor = System.Drawing.Color.White;
            this.boton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton1.Location = new System.Drawing.Point(-2, 260);
            this.boton1.Name = "boton1";
            this.boton1.Size = new System.Drawing.Size(80, 79);
            this.boton1.TabIndex = 12;
            this.boton1.Text = "1";
            this.boton1.UseVisualStyleBackColor = false;
            this.boton1.Click += new System.EventHandler(this.boton1_Click);
            // 
            // boton2
            // 
            this.boton2.BackColor = System.Drawing.Color.White;
            this.boton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton2.Location = new System.Drawing.Point(75, 260);
            this.boton2.Name = "boton2";
            this.boton2.Size = new System.Drawing.Size(80, 79);
            this.boton2.TabIndex = 13;
            this.boton2.Text = "2";
            this.boton2.UseVisualStyleBackColor = false;
            this.boton2.Click += new System.EventHandler(this.boton2_Click);
            // 
            // boton3
            // 
            this.boton3.BackColor = System.Drawing.Color.White;
            this.boton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton3.Location = new System.Drawing.Point(153, 260);
            this.boton3.Name = "boton3";
            this.boton3.Size = new System.Drawing.Size(80, 79);
            this.boton3.TabIndex = 14;
            this.boton3.Text = "3";
            this.boton3.UseVisualStyleBackColor = false;
            this.boton3.Click += new System.EventHandler(this.boton3_Click);
            // 
            // boton5
            // 
            this.boton5.BackColor = System.Drawing.Color.White;
            this.boton5.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton5.Location = new System.Drawing.Point(75, 183);
            this.boton5.Name = "boton5";
            this.boton5.Size = new System.Drawing.Size(80, 79);
            this.boton5.TabIndex = 15;
            this.boton5.Text = "5";
            this.boton5.UseVisualStyleBackColor = false;
            this.boton5.Click += new System.EventHandler(this.boton5_Click);
            // 
            // boton4
            // 
            this.boton4.BackColor = System.Drawing.Color.White;
            this.boton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton4.Location = new System.Drawing.Point(-2, 183);
            this.boton4.Name = "boton4";
            this.boton4.Size = new System.Drawing.Size(80, 79);
            this.boton4.TabIndex = 16;
            this.boton4.Text = "4";
            this.boton4.UseVisualStyleBackColor = false;
            this.boton4.Click += new System.EventHandler(this.boton4_Click);
            // 
            // boton6
            // 
            this.boton6.BackColor = System.Drawing.Color.White;
            this.boton6.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton6.Location = new System.Drawing.Point(153, 183);
            this.boton6.Name = "boton6";
            this.boton6.Size = new System.Drawing.Size(80, 79);
            this.boton6.TabIndex = 17;
            this.boton6.Text = "6";
            this.boton6.UseVisualStyleBackColor = false;
            this.boton6.Click += new System.EventHandler(this.boton6_Click);
            // 
            // boton7
            // 
            this.boton7.BackColor = System.Drawing.Color.White;
            this.boton7.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton7.Location = new System.Drawing.Point(-2, 109);
            this.boton7.Name = "boton7";
            this.boton7.Size = new System.Drawing.Size(80, 79);
            this.boton7.TabIndex = 18;
            this.boton7.Text = "7";
            this.boton7.UseVisualStyleBackColor = false;
            this.boton7.Click += new System.EventHandler(this.boton7_Click);
            // 
            // boton8
            // 
            this.boton8.BackColor = System.Drawing.Color.White;
            this.boton8.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton8.Location = new System.Drawing.Point(75, 109);
            this.boton8.Name = "boton8";
            this.boton8.Size = new System.Drawing.Size(80, 79);
            this.boton8.TabIndex = 19;
            this.boton8.Text = "8";
            this.boton8.UseVisualStyleBackColor = false;
            this.boton8.Click += new System.EventHandler(this.boton8_Click);
            // 
            // boton9
            // 
            this.boton9.BackColor = System.Drawing.Color.White;
            this.boton9.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton9.Location = new System.Drawing.Point(153, 109);
            this.boton9.Name = "boton9";
            this.boton9.Size = new System.Drawing.Size(80, 79);
            this.boton9.TabIndex = 20;
            this.boton9.Text = "9";
            this.boton9.UseVisualStyleBackColor = false;
            this.boton9.Click += new System.EventHandler(this.boton9_Click);
            // 
            // MiniCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 455);
            this.Controls.Add(this.boton9);
            this.Controls.Add(this.boton8);
            this.Controls.Add(this.boton7);
            this.Controls.Add(this.boton6);
            this.Controls.Add(this.boton4);
            this.Controls.Add(this.boton5);
            this.Controls.Add(this.boton3);
            this.Controls.Add(this.boton2);
            this.Controls.Add(this.boton1);
            this.Controls.Add(this.dividir);
            this.Controls.Add(this.multiplicar);
            this.Controls.Add(this.boton0);
            this.Controls.Add(this.resetCalculadora);
            this.Controls.Add(this.resolver);
            this.Controls.Add(this.sumar);
            this.Controls.Add(this.restar);
            this.Controls.Add(this.textoCalculadora);
            this.Name = "MiniCalculadora";
            this.Text = "MiniCalculadora";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label textoCalculadora;
        private System.Windows.Forms.Button restar;
        private System.Windows.Forms.Button sumar;
        private System.Windows.Forms.Button resolver;
        private System.Windows.Forms.Button resetCalculadora;
        private System.Windows.Forms.Button boton0;
        private System.Windows.Forms.Button multiplicar;
        private System.Windows.Forms.Button dividir;
        private System.Windows.Forms.Button boton1;
        private System.Windows.Forms.Button boton2;
        private System.Windows.Forms.Button boton3;
        private System.Windows.Forms.Button boton5;
        private System.Windows.Forms.Button boton4;
        private System.Windows.Forms.Button boton6;
        private System.Windows.Forms.Button boton7;
        private System.Windows.Forms.Button boton8;
        private System.Windows.Forms.Button boton9;
    }
}