namespace Cinema
{
    partial class SettingsForm
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
            this.colsCountLBL = new System.Windows.Forms.Label();
            this.colsCountTB = new System.Windows.Forms.TextBox();
            this.rowsCountLBL = new System.Windows.Forms.Label();
            this.rowsCountTB = new System.Windows.Forms.TextBox();
            this.saveChangesBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // colsCountLBL
            // 
            this.colsCountLBL.AutoSize = true;
            this.colsCountLBL.Location = new System.Drawing.Point(12, 9);
            this.colsCountLBL.Name = "colsCountLBL";
            this.colsCountLBL.Size = new System.Drawing.Size(99, 13);
            this.colsCountLBL.TabIndex = 0;
            this.colsCountLBL.Text = "Количество рядов";
            // 
            // colsCountTB
            // 
            this.colsCountTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.colsCountTB.Location = new System.Drawing.Point(12, 25);
            this.colsCountTB.Name = "colsCountTB";
            this.colsCountTB.Size = new System.Drawing.Size(160, 20);
            this.colsCountTB.TabIndex = 1;
            // 
            // rowsCountLBL
            // 
            this.rowsCountLBL.AutoSize = true;
            this.rowsCountLBL.Location = new System.Drawing.Point(12, 48);
            this.rowsCountLBL.Name = "rowsCountLBL";
            this.rowsCountLBL.Size = new System.Drawing.Size(129, 13);
            this.rowsCountLBL.TabIndex = 2;
            this.rowsCountLBL.Text = "Количество мест в ряду";
            // 
            // rowsCountTB
            // 
            this.rowsCountTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rowsCountTB.Location = new System.Drawing.Point(12, 64);
            this.rowsCountTB.Name = "rowsCountTB";
            this.rowsCountTB.Size = new System.Drawing.Size(160, 20);
            this.rowsCountTB.TabIndex = 3;
            // 
            // saveChangesBTN
            // 
            this.saveChangesBTN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.saveChangesBTN.Location = new System.Drawing.Point(12, 90);
            this.saveChangesBTN.Name = "saveChangesBTN";
            this.saveChangesBTN.Size = new System.Drawing.Size(160, 23);
            this.saveChangesBTN.TabIndex = 4;
            this.saveChangesBTN.Text = "Сохранить изменения!";
            this.saveChangesBTN.UseVisualStyleBackColor = true;
            this.saveChangesBTN.Click += new System.EventHandler(this.saveChangesBTN_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(184, 125);
            this.Controls.Add(this.saveChangesBTN);
            this.Controls.Add(this.rowsCountTB);
            this.Controls.Add(this.rowsCountLBL);
            this.Controls.Add(this.colsCountTB);
            this.Controls.Add(this.colsCountLBL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Параметры";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SettingsForm_FormClosing);
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label colsCountLBL;
        private System.Windows.Forms.TextBox colsCountTB;
        private System.Windows.Forms.Label rowsCountLBL;
        private System.Windows.Forms.TextBox rowsCountTB;
        private System.Windows.Forms.Button saveChangesBTN;
    }
}