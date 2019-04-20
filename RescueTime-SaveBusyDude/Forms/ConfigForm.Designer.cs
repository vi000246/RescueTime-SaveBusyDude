namespace RescueTime_SaveBusyDude.Forms
{
    partial class ConfigForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage_main = new System.Windows.Forms.TabPage();
            this.tabPage_alertRule = new System.Windows.Forms.TabPage();
            this.tabPage_period = new System.Windows.Forms.TabPage();
            this.lbApiKey = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbBlockMode = new System.Windows.Forms.Label();
            this.cbBlockingMode = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lvPeriod = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvAlertRule = new System.Windows.Forms.ListView();
            this.btnPeriod_Edit = new System.Windows.Forms.Button();
            this.btnPeriod_Delete = new System.Windows.Forms.Button();
            this.btnPeriod_Add = new System.Windows.Forms.Button();
            this.btnAlertRule_Add = new System.Windows.Forms.Button();
            this.btnAlertRule_Delete = new System.Windows.Forms.Button();
            this.btnAlertRule_Edit = new System.Windows.Forms.Button();
            this.btnSaveBasic = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.btnBlockingList_Add = new System.Windows.Forms.Button();
            this.btnBlockingList_Delete = new System.Windows.Forms.Button();
            this.btnBlockingList_Edit = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage_main.SuspendLayout();
            this.tabPage_alertRule.SuspendLayout();
            this.tabPage_period.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage_main);
            this.tabControl1.Controls.Add(this.tabPage_alertRule);
            this.tabControl1.Controls.Add(this.tabPage_period);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 426);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage_main
            // 
            this.tabPage_main.Controls.Add(this.btnSaveBasic);
            this.tabPage_main.Controls.Add(this.groupBox1);
            this.tabPage_main.Controls.Add(this.textBox1);
            this.tabPage_main.Controls.Add(this.lbApiKey);
            this.tabPage_main.Location = new System.Drawing.Point(4, 22);
            this.tabPage_main.Name = "tabPage_main";
            this.tabPage_main.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_main.Size = new System.Drawing.Size(768, 400);
            this.tabPage_main.TabIndex = 0;
            this.tabPage_main.Text = "Basic";
            this.tabPage_main.UseVisualStyleBackColor = true;
            // 
            // tabPage_alertRule
            // 
            this.tabPage_alertRule.Controls.Add(this.btnAlertRule_Add);
            this.tabPage_alertRule.Controls.Add(this.btnAlertRule_Delete);
            this.tabPage_alertRule.Controls.Add(this.btnAlertRule_Edit);
            this.tabPage_alertRule.Controls.Add(this.lvAlertRule);
            this.tabPage_alertRule.Location = new System.Drawing.Point(4, 22);
            this.tabPage_alertRule.Name = "tabPage_alertRule";
            this.tabPage_alertRule.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_alertRule.Size = new System.Drawing.Size(768, 400);
            this.tabPage_alertRule.TabIndex = 1;
            this.tabPage_alertRule.Text = "Alert Rule";
            this.tabPage_alertRule.UseVisualStyleBackColor = true;
            // 
            // tabPage_period
            // 
            this.tabPage_period.Controls.Add(this.btnPeriod_Add);
            this.tabPage_period.Controls.Add(this.btnPeriod_Delete);
            this.tabPage_period.Controls.Add(this.btnPeriod_Edit);
            this.tabPage_period.Controls.Add(this.lvPeriod);
            this.tabPage_period.Location = new System.Drawing.Point(4, 22);
            this.tabPage_period.Name = "tabPage_period";
            this.tabPage_period.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_period.Size = new System.Drawing.Size(768, 400);
            this.tabPage_period.TabIndex = 2;
            this.tabPage_period.Text = "Period Setting";
            this.tabPage_period.UseVisualStyleBackColor = true;
            // 
            // lbApiKey
            // 
            this.lbApiKey.AutoSize = true;
            this.lbApiKey.Location = new System.Drawing.Point(16, 12);
            this.lbApiKey.Name = "lbApiKey";
            this.lbApiKey.Size = new System.Drawing.Size(53, 12);
            this.lbApiKey.TabIndex = 2;
            this.lbApiKey.Text = "ApiKey：";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(104, 9);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(220, 22);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "tbApiKey";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBlockingList_Add);
            this.groupBox1.Controls.Add(this.btnBlockingList_Delete);
            this.groupBox1.Controls.Add(this.btnBlockingList_Edit);
            this.groupBox1.Controls.Add(this.checkedListBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbBlockingMode);
            this.groupBox1.Controls.Add(this.lbBlockMode);
            this.groupBox1.Location = new System.Drawing.Point(8, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(442, 237);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Focus Mode Setting：";
            // 
            // lbBlockMode
            // 
            this.lbBlockMode.AutoSize = true;
            this.lbBlockMode.Location = new System.Drawing.Point(8, 42);
            this.lbBlockMode.Name = "lbBlockMode";
            this.lbBlockMode.Size = new System.Drawing.Size(90, 12);
            this.lbBlockMode.TabIndex = 0;
            this.lbBlockMode.Text = "Blocking Mode：";
            // 
            // cbBlockingMode
            // 
            this.cbBlockingMode.FormattingEnabled = true;
            this.cbBlockingMode.Location = new System.Drawing.Point(96, 39);
            this.cbBlockingMode.Name = "cbBlockingMode";
            this.cbBlockingMode.Size = new System.Drawing.Size(121, 20);
            this.cbBlockingMode.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "Blocking List：";
            // 
            // lvPeriod
            // 
            this.lvPeriod.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvPeriod.GridLines = true;
            this.lvPeriod.Location = new System.Drawing.Point(6, 6);
            this.lvPeriod.Name = "lvPeriod";
            this.lvPeriod.Size = new System.Drawing.Size(465, 278);
            this.lvPeriod.TabIndex = 1;
            this.lvPeriod.UseCompatibleStateImageBehavior = false;
            this.lvPeriod.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = 102;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Width = 118;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Width = 112;
            // 
            // lvAlertRule
            // 
            this.lvAlertRule.GridLines = true;
            this.lvAlertRule.Location = new System.Drawing.Point(6, 6);
            this.lvAlertRule.Name = "lvAlertRule";
            this.lvAlertRule.Size = new System.Drawing.Size(466, 278);
            this.lvAlertRule.TabIndex = 0;
            this.lvAlertRule.UseCompatibleStateImageBehavior = false;
            this.lvAlertRule.View = System.Windows.Forms.View.Details;
            // 
            // btnPeriod_Edit
            // 
            this.btnPeriod_Edit.Location = new System.Drawing.Point(477, 232);
            this.btnPeriod_Edit.Name = "btnPeriod_Edit";
            this.btnPeriod_Edit.Size = new System.Drawing.Size(55, 23);
            this.btnPeriod_Edit.TabIndex = 2;
            this.btnPeriod_Edit.Text = "Edit";
            this.btnPeriod_Edit.UseVisualStyleBackColor = true;
            // 
            // btnPeriod_Delete
            // 
            this.btnPeriod_Delete.Location = new System.Drawing.Point(478, 261);
            this.btnPeriod_Delete.Name = "btnPeriod_Delete";
            this.btnPeriod_Delete.Size = new System.Drawing.Size(55, 23);
            this.btnPeriod_Delete.TabIndex = 3;
            this.btnPeriod_Delete.Text = "Delete";
            this.btnPeriod_Delete.UseVisualStyleBackColor = true;
            // 
            // btnPeriod_Add
            // 
            this.btnPeriod_Add.Location = new System.Drawing.Point(477, 203);
            this.btnPeriod_Add.Name = "btnPeriod_Add";
            this.btnPeriod_Add.Size = new System.Drawing.Size(55, 23);
            this.btnPeriod_Add.TabIndex = 4;
            this.btnPeriod_Add.Text = "Add";
            this.btnPeriod_Add.UseVisualStyleBackColor = true;
            // 
            // btnAlertRule_Add
            // 
            this.btnAlertRule_Add.Location = new System.Drawing.Point(478, 201);
            this.btnAlertRule_Add.Name = "btnAlertRule_Add";
            this.btnAlertRule_Add.Size = new System.Drawing.Size(55, 23);
            this.btnAlertRule_Add.TabIndex = 7;
            this.btnAlertRule_Add.Text = "Add";
            this.btnAlertRule_Add.UseVisualStyleBackColor = true;
            // 
            // btnAlertRule_Delete
            // 
            this.btnAlertRule_Delete.Location = new System.Drawing.Point(479, 259);
            this.btnAlertRule_Delete.Name = "btnAlertRule_Delete";
            this.btnAlertRule_Delete.Size = new System.Drawing.Size(55, 23);
            this.btnAlertRule_Delete.TabIndex = 6;
            this.btnAlertRule_Delete.Text = "Delete";
            this.btnAlertRule_Delete.UseVisualStyleBackColor = true;
            // 
            // btnAlertRule_Edit
            // 
            this.btnAlertRule_Edit.Location = new System.Drawing.Point(478, 230);
            this.btnAlertRule_Edit.Name = "btnAlertRule_Edit";
            this.btnAlertRule_Edit.Size = new System.Drawing.Size(55, 23);
            this.btnAlertRule_Edit.TabIndex = 5;
            this.btnAlertRule_Edit.Text = "Edit";
            this.btnAlertRule_Edit.UseVisualStyleBackColor = true;
            // 
            // btnSaveBasic
            // 
            this.btnSaveBasic.Location = new System.Drawing.Point(458, 261);
            this.btnSaveBasic.Name = "btnSaveBasic";
            this.btnSaveBasic.Size = new System.Drawing.Size(75, 23);
            this.btnSaveBasic.TabIndex = 6;
            this.btnSaveBasic.Text = "Save";
            this.btnSaveBasic.UseVisualStyleBackColor = true;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(96, 76);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(279, 157);
            this.checkedListBox1.TabIndex = 3;
            // 
            // btnBlockingList_Add
            // 
            this.btnBlockingList_Add.Location = new System.Drawing.Point(380, 150);
            this.btnBlockingList_Add.Name = "btnBlockingList_Add";
            this.btnBlockingList_Add.Size = new System.Drawing.Size(55, 23);
            this.btnBlockingList_Add.TabIndex = 10;
            this.btnBlockingList_Add.Text = "Add";
            this.btnBlockingList_Add.UseVisualStyleBackColor = true;
            // 
            // btnBlockingList_Delete
            // 
            this.btnBlockingList_Delete.Location = new System.Drawing.Point(381, 208);
            this.btnBlockingList_Delete.Name = "btnBlockingList_Delete";
            this.btnBlockingList_Delete.Size = new System.Drawing.Size(55, 23);
            this.btnBlockingList_Delete.TabIndex = 9;
            this.btnBlockingList_Delete.Text = "Delete";
            this.btnBlockingList_Delete.UseVisualStyleBackColor = true;
            // 
            // btnBlockingList_Edit
            // 
            this.btnBlockingList_Edit.Location = new System.Drawing.Point(380, 179);
            this.btnBlockingList_Edit.Name = "btnBlockingList_Edit";
            this.btnBlockingList_Edit.Size = new System.Drawing.Size(55, 23);
            this.btnBlockingList_Edit.TabIndex = 8;
            this.btnBlockingList_Edit.Text = "Edit";
            this.btnBlockingList_Edit.UseVisualStyleBackColor = true;
            // 
            // ConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 330);
            this.Controls.Add(this.tabControl1);
            this.Name = "ConfigForm";
            this.Text = "ConfigForm";
            this.tabControl1.ResumeLayout(false);
            this.tabPage_main.ResumeLayout(false);
            this.tabPage_main.PerformLayout();
            this.tabPage_alertRule.ResumeLayout(false);
            this.tabPage_period.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage_main;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbApiKey;
        private System.Windows.Forms.TabPage tabPage_alertRule;
        private System.Windows.Forms.TabPage tabPage_period;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbBlockMode;
        private System.Windows.Forms.ComboBox cbBlockingMode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvPeriod;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ListView lvAlertRule;
        private System.Windows.Forms.Button btnPeriod_Add;
        private System.Windows.Forms.Button btnPeriod_Delete;
        private System.Windows.Forms.Button btnPeriod_Edit;
        private System.Windows.Forms.Button btnSaveBasic;
        private System.Windows.Forms.Button btnBlockingList_Add;
        private System.Windows.Forms.Button btnBlockingList_Delete;
        private System.Windows.Forms.Button btnBlockingList_Edit;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button btnAlertRule_Add;
        private System.Windows.Forms.Button btnAlertRule_Delete;
        private System.Windows.Forms.Button btnAlertRule_Edit;
    }
}