namespace Interface
{
    partial class Form2
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
            btnLigarDesligarArduino = new Button();
            btnLampada = new Button();
            desligarFumaca = new Button();
            desligaSom = new Button();
            logAcesso = new Button();
            SuspendLayout();
            // 
            // btnLigarDesligarArduino
            // 
            btnLigarDesligarArduino.Location = new Point(233, 65);
            btnLigarDesligarArduino.Name = "btnLigarDesligarArduino";
            btnLigarDesligarArduino.Size = new Size(161, 36);
            btnLigarDesligarArduino.TabIndex = 2;
            btnLigarDesligarArduino.Text = "Reset";
            btnLigarDesligarArduino.UseVisualStyleBackColor = true;
            btnLigarDesligarArduino.Click += btnLigarDesligarArduino_Click_1;
            // 
            // btnLampada
            // 
            btnLampada.Location = new Point(233, 166);
            btnLampada.Name = "btnLampada";
            btnLampada.Size = new Size(161, 23);
            btnLampada.TabIndex = 3;
            btnLampada.Text = "Desligar Lampada";
            btnLampada.UseVisualStyleBackColor = true;
            btnLampada.Click += btnLampada_Click_1;
            // 
            // desligarFumaca
            // 
            desligarFumaca.Location = new Point(233, 218);
            desligarFumaca.Name = "desligarFumaca";
            desligarFumaca.Size = new Size(161, 23);
            desligarFumaca.TabIndex = 4;
            desligarFumaca.Text = "Desligar Fumaça";
            desligarFumaca.UseVisualStyleBackColor = true;
            desligarFumaca.Click += desligarFumaca_Click_1;
            // 
            // desligaSom
            // 
            desligaSom.Location = new Point(233, 273);
            desligaSom.Name = "desligaSom";
            desligaSom.Size = new Size(161, 23);
            desligaSom.TabIndex = 5;
            desligaSom.Text = "Desligar Som";
            desligaSom.UseVisualStyleBackColor = true;
            desligaSom.Click += desligaSom_Click_1;
            // 
            // logAcesso
            // 
            logAcesso.Location = new Point(12, 415);
            logAcesso.Name = "logAcesso";
            logAcesso.Size = new Size(75, 23);
            logAcesso.TabIndex = 6;
            logAcesso.Text = "Logs";
            logAcesso.UseVisualStyleBackColor = true;
            logAcesso.Click += logAcesso_Click_1;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(631, 450);
            Controls.Add(logAcesso);
            Controls.Add(desligaSom);
            Controls.Add(desligarFumaca);
            Controls.Add(btnLampada);
            Controls.Add(btnLigarDesligarArduino);
            MaximizeBox = false;
            Name = "Form2";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Load += Form2_Load_1;
            ResumeLayout(false);
        }

        #endregion

        private Button btnLigarDesligarArduino;
        private Button btnLampada;
        private Button button2;
        private Button desligarFumaca;
        private Button desligaSom;
        private Button logAcesso;
    }
}