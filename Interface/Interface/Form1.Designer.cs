namespace Interface
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLampada = new System.Windows.Forms.Button();
            this.btnLigarDesligarArduino = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLampada
            // 
            this.btnLampada.Location = new System.Drawing.Point(263, 267);
            this.btnLampada.Name = "btnLampada";
            this.btnLampada.Size = new System.Drawing.Size(146, 23);
            this.btnLampada.TabIndex = 0;
            this.btnLampada.Text = "Ligar Lampada";
            this.btnLampada.UseVisualStyleBackColor = true;
            this.btnLampada.Click += new System.EventHandler(this.btnLampada_Click_1);
            // 
            // btnLigarDesligarArduino
            // 
            this.btnLigarDesligarArduino.Location = new System.Drawing.Point(263, 94);
            this.btnLigarDesligarArduino.Name = "btnLigarDesligarArduino";
            this.btnLigarDesligarArduino.Size = new System.Drawing.Size(161, 36);
            this.btnLigarDesligarArduino.TabIndex = 1;
            this.btnLigarDesligarArduino.Text = "Ligar Arduino";
            this.btnLigarDesligarArduino.UseVisualStyleBackColor = true;
            this.btnLigarDesligarArduino.Click += new System.EventHandler(this.btnLigarDesligarArduino_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 603);
            this.Controls.Add(this.btnLigarDesligarArduino);
            this.Controls.Add(this.btnLampada);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnLampada;
        private Button btnLigarDesligarArduino;
    }
}