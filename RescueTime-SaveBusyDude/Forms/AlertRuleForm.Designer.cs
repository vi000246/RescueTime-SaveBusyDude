namespace RescueTime_SaveBusyDude.Forms
{
    partial class AlertRuleForm
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
            this.cbPeriodName = new System.Windows.Forms.CheckedListBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.cbEnableDays = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // cbPeriodName
            // 
            this.cbPeriodName.FormattingEnabled = true;
            this.cbPeriodName.Location = new System.Drawing.Point(13, 13);
            this.cbPeriodName.Name = "cbPeriodName";
            this.cbPeriodName.Size = new System.Drawing.Size(211, 208);
            this.cbPeriodName.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(563, 198);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cbEnableDays
            // 
            this.cbEnableDays.FormattingEnabled = true;
            this.cbEnableDays.Location = new System.Drawing.Point(230, 13);
            this.cbEnableDays.Name = "cbEnableDays";
            this.cbEnableDays.Size = new System.Drawing.Size(100, 123);
            this.cbEnableDays.TabIndex = 2;
            // 
            // AlertRuleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 232);
            this.Controls.Add(this.cbEnableDays);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cbPeriodName);
            this.Name = "AlertRuleForm";
            this.Text = "PeriodNameForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox cbPeriodName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.CheckedListBox cbEnableDays;
    }
}