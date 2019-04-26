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
            this.lbAlertName = new System.Windows.Forms.Label();
            this.cbAlertType = new System.Windows.Forms.ComboBox();
            this.lbAlertType = new System.Windows.Forms.Label();
            this.ddHour = new System.Windows.Forms.NumericUpDown();
            this.ddMinute = new System.Windows.Forms.NumericUpDown();
            this.lbSpecificName = new System.Windows.Forms.ListBox();
            this.cbEnablePeriodName = new System.Windows.Forms.CheckedListBox();
            this.cbBlockWhenTrigger = new System.Windows.Forms.CheckBox();
            this.tbCusomMessage = new System.Windows.Forms.TextBox();
            this.lbCustomMessage = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ddHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddMinute)).BeginInit();
            this.SuspendLayout();
            // 
            // cbPeriodName
            // 
            this.cbPeriodName.FormattingEnabled = true;
            this.cbPeriodName.Location = new System.Drawing.Point(256, 104);
            this.cbPeriodName.Name = "cbPeriodName";
            this.cbPeriodName.Size = new System.Drawing.Size(101, 123);
            this.cbPeriodName.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(495, 9);
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
            this.cbEnableDays.Location = new System.Drawing.Point(470, 104);
            this.cbEnableDays.Name = "cbEnableDays";
            this.cbEnableDays.Size = new System.Drawing.Size(100, 123);
            this.cbEnableDays.TabIndex = 2;
            // 
            // lbAlertName
            // 
            this.lbAlertName.AutoSize = true;
            this.lbAlertName.Font = new System.Drawing.Font("PMingLiU", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbAlertName.Location = new System.Drawing.Point(12, 9);
            this.lbAlertName.Name = "lbAlertName";
            this.lbAlertName.Size = new System.Drawing.Size(84, 15);
            this.lbAlertName.TabIndex = 4;
            this.lbAlertName.Text = "AlertName：";
            // 
            // cbAlertType
            // 
            this.cbAlertType.FormattingEnabled = true;
            this.cbAlertType.Location = new System.Drawing.Point(83, 59);
            this.cbAlertType.Name = "cbAlertType";
            this.cbAlertType.Size = new System.Drawing.Size(121, 20);
            this.cbAlertType.TabIndex = 5;
            // 
            // lbAlertType
            // 
            this.lbAlertType.AutoSize = true;
            this.lbAlertType.Location = new System.Drawing.Point(13, 63);
            this.lbAlertType.Name = "lbAlertType";
            this.lbAlertType.Size = new System.Drawing.Size(64, 12);
            this.lbAlertType.TabIndex = 6;
            this.lbAlertType.Text = "AlertType：";
            // 
            // ddHour
            // 
            this.ddHour.Location = new System.Drawing.Point(83, 104);
            this.ddHour.Name = "ddHour";
            this.ddHour.Size = new System.Drawing.Size(56, 22);
            this.ddHour.TabIndex = 7;
            // 
            // ddMinute
            // 
            this.ddMinute.Location = new System.Drawing.Point(83, 157);
            this.ddMinute.Name = "ddMinute";
            this.ddMinute.Size = new System.Drawing.Size(56, 22);
            this.ddMinute.TabIndex = 8;
            // 
            // lbSpecificName
            // 
            this.lbSpecificName.FormattingEnabled = true;
            this.lbSpecificName.ItemHeight = 12;
            this.lbSpecificName.Location = new System.Drawing.Point(154, 106);
            this.lbSpecificName.Name = "lbSpecificName";
            this.lbSpecificName.Size = new System.Drawing.Size(96, 124);
            this.lbSpecificName.TabIndex = 9;
            // 
            // cbEnablePeriodName
            // 
            this.cbEnablePeriodName.FormattingEnabled = true;
            this.cbEnablePeriodName.Location = new System.Drawing.Point(363, 106);
            this.cbEnablePeriodName.Name = "cbEnablePeriodName";
            this.cbEnablePeriodName.Size = new System.Drawing.Size(101, 123);
            this.cbEnablePeriodName.TabIndex = 10;
            // 
            // cbBlockWhenTrigger
            // 
            this.cbBlockWhenTrigger.AutoSize = true;
            this.cbBlockWhenTrigger.Location = new System.Drawing.Point(18, 204);
            this.cbBlockWhenTrigger.Name = "cbBlockWhenTrigger";
            this.cbBlockWhenTrigger.Size = new System.Drawing.Size(121, 16);
            this.cbBlockWhenTrigger.TabIndex = 11;
            this.cbBlockWhenTrigger.Text = "Block When Trigger";
            this.cbBlockWhenTrigger.UseVisualStyleBackColor = true;
            // 
            // tbCusomMessage
            // 
            this.tbCusomMessage.Location = new System.Drawing.Point(321, 9);
            this.tbCusomMessage.Multiline = true;
            this.tbCusomMessage.Name = "tbCusomMessage";
            this.tbCusomMessage.Size = new System.Drawing.Size(162, 66);
            this.tbCusomMessage.TabIndex = 12;
            // 
            // lbCustomMessage
            // 
            this.lbCustomMessage.AutoSize = true;
            this.lbCustomMessage.Location = new System.Drawing.Point(223, 12);
            this.lbCustomMessage.Name = "lbCustomMessage";
            this.lbCustomMessage.Size = new System.Drawing.Size(92, 12);
            this.lbCustomMessage.TabIndex = 13;
            this.lbCustomMessage.Text = "CustomMessage：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 14;
            this.label1.Text = "Hour：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 12);
            this.label2.TabIndex = 15;
            this.label2.Text = "Minute：";
            // 
            // AlertRuleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 232);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbCustomMessage);
            this.Controls.Add(this.tbCusomMessage);
            this.Controls.Add(this.cbBlockWhenTrigger);
            this.Controls.Add(this.cbEnablePeriodName);
            this.Controls.Add(this.lbSpecificName);
            this.Controls.Add(this.ddMinute);
            this.Controls.Add(this.ddHour);
            this.Controls.Add(this.lbAlertType);
            this.Controls.Add(this.cbAlertType);
            this.Controls.Add(this.lbAlertName);
            this.Controls.Add(this.cbEnableDays);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cbPeriodName);
            this.Name = "AlertRuleForm";
            this.Text = "PeriodNameForm";
            ((System.ComponentModel.ISupportInitialize)(this.ddHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddMinute)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox cbPeriodName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.CheckedListBox cbEnableDays;
        private System.Windows.Forms.Label lbAlertName;
        private System.Windows.Forms.ComboBox cbAlertType;
        private System.Windows.Forms.Label lbAlertType;
        private System.Windows.Forms.NumericUpDown ddHour;
        private System.Windows.Forms.NumericUpDown ddMinute;
        private System.Windows.Forms.ListBox lbSpecificName;
        private System.Windows.Forms.CheckedListBox cbEnablePeriodName;
        private System.Windows.Forms.CheckBox cbBlockWhenTrigger;
        private System.Windows.Forms.TextBox tbCusomMessage;
        private System.Windows.Forms.Label lbCustomMessage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}