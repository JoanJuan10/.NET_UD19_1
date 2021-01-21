
namespace UD19_1
{
    partial class Ej3
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonWindows = new System.Windows.Forms.RadioButton();
            this.buttonLinux = new System.Windows.Forms.RadioButton();
            this.buttonMAC = new System.Windows.Forms.RadioButton();
            this.buttonProgramacion = new System.Windows.Forms.CheckBox();
            this.buttonGrafico = new System.Windows.Forms.CheckBox();
            this.buttonAdmin = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.horasPC = new System.Windows.Forms.TrackBar();
            this.enviar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.horasPC)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Elije un sistema operativo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Elije tu especialidad";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // buttonWindows
            // 
            this.buttonWindows.AutoSize = true;
            this.buttonWindows.Location = new System.Drawing.Point(47, 74);
            this.buttonWindows.Name = "buttonWindows";
            this.buttonWindows.Size = new System.Drawing.Size(69, 17);
            this.buttonWindows.TabIndex = 2;
            this.buttonWindows.TabStop = true;
            this.buttonWindows.Text = "Windows";
            this.buttonWindows.UseVisualStyleBackColor = true;
            this.buttonWindows.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // buttonLinux
            // 
            this.buttonLinux.AutoSize = true;
            this.buttonLinux.Location = new System.Drawing.Point(47, 114);
            this.buttonLinux.Name = "buttonLinux";
            this.buttonLinux.Size = new System.Drawing.Size(50, 17);
            this.buttonLinux.TabIndex = 3;
            this.buttonLinux.TabStop = true;
            this.buttonLinux.Text = "Linux";
            this.buttonLinux.UseVisualStyleBackColor = true;
            // 
            // buttonMAC
            // 
            this.buttonMAC.AutoSize = true;
            this.buttonMAC.Location = new System.Drawing.Point(47, 155);
            this.buttonMAC.Name = "buttonMAC";
            this.buttonMAC.Size = new System.Drawing.Size(73, 17);
            this.buttonMAC.TabIndex = 4;
            this.buttonMAC.TabStop = true;
            this.buttonMAC.Text = "MAC OSX";
            this.buttonMAC.UseVisualStyleBackColor = true;
            // 
            // buttonProgramacion
            // 
            this.buttonProgramacion.AutoSize = true;
            this.buttonProgramacion.Location = new System.Drawing.Point(45, 253);
            this.buttonProgramacion.Name = "buttonProgramacion";
            this.buttonProgramacion.Size = new System.Drawing.Size(91, 17);
            this.buttonProgramacion.TabIndex = 5;
            this.buttonProgramacion.Text = "Programación";
            this.buttonProgramacion.UseVisualStyleBackColor = true;
            this.buttonProgramacion.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // buttonGrafico
            // 
            this.buttonGrafico.AutoSize = true;
            this.buttonGrafico.Location = new System.Drawing.Point(45, 304);
            this.buttonGrafico.Name = "buttonGrafico";
            this.buttonGrafico.Size = new System.Drawing.Size(96, 17);
            this.buttonGrafico.TabIndex = 6;
            this.buttonGrafico.Text = "Diseño Gràfico";
            this.buttonGrafico.UseVisualStyleBackColor = true;
            // 
            // buttonAdmin
            // 
            this.buttonAdmin.AutoSize = true;
            this.buttonAdmin.Location = new System.Drawing.Point(45, 350);
            this.buttonAdmin.Name = "buttonAdmin";
            this.buttonAdmin.Size = new System.Drawing.Size(94, 17);
            this.buttonAdmin.TabIndex = 7;
            this.buttonAdmin.Text = "Administración";
            this.buttonAdmin.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(448, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(248, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Horas dedicadas en el ordenador:";
            // 
            // horasPC
            // 
            this.horasPC.Location = new System.Drawing.Point(449, 102);
            this.horasPC.Minimum = 1;
            this.horasPC.Name = "horasPC";
            this.horasPC.Size = new System.Drawing.Size(247, 45);
            this.horasPC.TabIndex = 9;
            this.horasPC.Value = 1;
            // 
            // enviar
            // 
            this.enviar.Location = new System.Drawing.Point(453, 268);
            this.enviar.Name = "enviar";
            this.enviar.Size = new System.Drawing.Size(262, 52);
            this.enviar.TabIndex = 10;
            this.enviar.Text = "Enviar";
            this.enviar.UseVisualStyleBackColor = true;
            this.enviar.Click += new System.EventHandler(this.enviar_Click);
            // 
            // Ej3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.enviar);
            this.Controls.Add(this.horasPC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonAdmin);
            this.Controls.Add(this.buttonGrafico);
            this.Controls.Add(this.buttonProgramacion);
            this.Controls.Add(this.buttonMAC);
            this.Controls.Add(this.buttonLinux);
            this.Controls.Add(this.buttonWindows);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Ej3";
            this.Text = "Ej3";
            ((System.ComponentModel.ISupportInitialize)(this.horasPC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton buttonWindows;
        private System.Windows.Forms.RadioButton buttonLinux;
        private System.Windows.Forms.RadioButton buttonMAC;
        private System.Windows.Forms.CheckBox buttonProgramacion;
        private System.Windows.Forms.CheckBox buttonGrafico;
        private System.Windows.Forms.CheckBox buttonAdmin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar horasPC;
        private System.Windows.Forms.Button enviar;
    }
}