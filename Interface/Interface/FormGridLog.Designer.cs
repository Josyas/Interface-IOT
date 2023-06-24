namespace Interface
{
    partial class FormGridLog
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
            this.dataGridViewLog = new System.Windows.Forms.DataGridView();
            this.IdLog = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeLog = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataLog = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLog)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewLog
            // 
            this.dataGridViewLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLog.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdLog,
            this.NomeLog,
            this.DataLog});
            this.dataGridViewLog.Location = new System.Drawing.Point(25, 70);
            this.dataGridViewLog.Name = "dataGridViewLog";
            this.dataGridViewLog.RowTemplate.Height = 25;
            this.dataGridViewLog.Size = new System.Drawing.Size(577, 323);
            this.dataGridViewLog.TabIndex = 0;
            // 
            // IdLog
            // 
            this.IdLog.HeaderText = "Id";
            this.IdLog.Name = "IdLog";
            this.IdLog.Visible = false;
            // 
            // NomeLog
            // 
            this.NomeLog.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NomeLog.HeaderText = "Nome";
            this.NomeLog.Name = "NomeLog";
            // 
            // DataLog
            // 
            this.DataLog.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DataLog.HeaderText = "Data Log";
            this.DataLog.Name = "DataLog";
            // 
            // FormGridLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 450);
            this.Controls.Add(this.dataGridViewLog);
            this.Name = "FormGridLog";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormGridLog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLog)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridViewLog;
        private DataGridViewTextBoxColumn IdLog;
        private DataGridViewTextBoxColumn NomeLog;
        private DataGridViewTextBoxColumn DataLog;
    }
}