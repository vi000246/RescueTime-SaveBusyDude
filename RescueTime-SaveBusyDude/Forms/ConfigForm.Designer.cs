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
            this.components = new System.ComponentModel.Container();
            this.tcConfigForm = new System.Windows.Forms.TabControl();
            this.Basic = new System.Windows.Forms.TabPage();
            this.btnSaveBasic = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBlockingList_Add = new System.Windows.Forms.Button();
            this.btnBlockingList_Delete = new System.Windows.Forms.Button();
            this.btnBlockingList_Edit = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbBlockingMode = new System.Windows.Forms.ComboBox();
            this.lbBlockMode = new System.Windows.Forms.Label();
            this.tbApiKey = new System.Windows.Forms.TextBox();
            this.lbApiKey = new System.Windows.Forms.Label();
            this.AlertRule = new System.Windows.Forms.TabPage();
            this.gvAlertRule = new System.Windows.Forms.DataGridView();
            this.AlertName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AlertType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Hour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Minute = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SpecificName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PeriodName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EnableDays = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EnablePeriodName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BlockWhenTrigger = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.CustomMessage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAlertRule_Add = new System.Windows.Forms.Button();
            this.btnAlertRule_Delete = new System.Windows.Forms.Button();
            this.Period = new System.Windows.Forms.TabPage();
            this.btnPeriodDelete = new System.Windows.Forms.Button();
            this.gvPeriodSetting = new System.Windows.Forms.DataGridView();
            this.PeriodName1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hour_begin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hour_end = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPeriod_Add = new System.Windows.Forms.Button();
            this.tbActivitySearch = new System.Windows.Forms.TabPage();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbSearchResult = new System.Windows.Forms.ListBox();
            this.tbSearchField = new System.Windows.Forms.TextBox();
            this.periodRuleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alertRuleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.tcConfigForm.SuspendLayout();
            this.Basic.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.AlertRule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvAlertRule)).BeginInit();
            this.Period.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvPeriodSetting)).BeginInit();
            this.tbActivitySearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.periodRuleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alertRuleBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tcConfigForm
            // 
            this.tcConfigForm.Controls.Add(this.Basic);
            this.tcConfigForm.Controls.Add(this.AlertRule);
            this.tcConfigForm.Controls.Add(this.Period);
            this.tcConfigForm.Controls.Add(this.tbActivitySearch);
            this.tcConfigForm.Location = new System.Drawing.Point(12, 12);
            this.tcConfigForm.Name = "tcConfigForm";
            this.tcConfigForm.SelectedIndex = 0;
            this.tcConfigForm.Size = new System.Drawing.Size(1129, 316);
            this.tcConfigForm.TabIndex = 5;
            // 
            // Basic
            // 
            this.Basic.Controls.Add(this.btnSaveBasic);
            this.Basic.Controls.Add(this.groupBox1);
            this.Basic.Controls.Add(this.tbApiKey);
            this.Basic.Controls.Add(this.lbApiKey);
            this.Basic.Location = new System.Drawing.Point(4, 22);
            this.Basic.Name = "Basic";
            this.Basic.Padding = new System.Windows.Forms.Padding(3);
            this.Basic.Size = new System.Drawing.Size(1121, 290);
            this.Basic.TabIndex = 0;
            this.Basic.Text = "Basic";
            this.Basic.UseVisualStyleBackColor = true;
            // 
            // btnSaveBasic
            // 
            this.btnSaveBasic.Location = new System.Drawing.Point(458, 261);
            this.btnSaveBasic.Name = "btnSaveBasic";
            this.btnSaveBasic.Size = new System.Drawing.Size(75, 23);
            this.btnSaveBasic.TabIndex = 6;
            this.btnSaveBasic.Text = "Save";
            this.btnSaveBasic.UseVisualStyleBackColor = true;
            this.btnSaveBasic.Click += new System.EventHandler(this.btnSaveBasic_Click);
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
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(96, 76);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(279, 157);
            this.checkedListBox1.TabIndex = 3;
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
            // cbBlockingMode
            // 
            this.cbBlockingMode.FormattingEnabled = true;
            this.cbBlockingMode.Location = new System.Drawing.Point(96, 39);
            this.cbBlockingMode.Name = "cbBlockingMode";
            this.cbBlockingMode.Size = new System.Drawing.Size(121, 20);
            this.cbBlockingMode.TabIndex = 1;
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
            // tbApiKey
            // 
            this.tbApiKey.Location = new System.Drawing.Point(104, 9);
            this.tbApiKey.Name = "tbApiKey";
            this.tbApiKey.Size = new System.Drawing.Size(279, 22);
            this.tbApiKey.TabIndex = 3;
            this.tbApiKey.Text = "tbApiKey";
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
            // AlertRule
            // 
            this.AlertRule.Controls.Add(this.gvAlertRule);
            this.AlertRule.Controls.Add(this.btnAlertRule_Add);
            this.AlertRule.Controls.Add(this.btnAlertRule_Delete);
            this.AlertRule.Location = new System.Drawing.Point(4, 22);
            this.AlertRule.Name = "AlertRule";
            this.AlertRule.Padding = new System.Windows.Forms.Padding(3);
            this.AlertRule.Size = new System.Drawing.Size(1121, 290);
            this.AlertRule.TabIndex = 1;
            this.AlertRule.Text = "Alert Rule";
            this.AlertRule.UseVisualStyleBackColor = true;
            // 
            // gvAlertRule
            // 
            this.gvAlertRule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvAlertRule.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AlertName,
            this.AlertType,
            this.Hour,
            this.Minute,
            this.SpecificName,
            this.PeriodName,
            this.EnableDays,
            this.EnablePeriodName,
            this.BlockWhenTrigger,
            this.CustomMessage});
            this.gvAlertRule.Location = new System.Drawing.Point(7, 7);
            this.gvAlertRule.Name = "gvAlertRule";
            this.gvAlertRule.RowTemplate.Height = 24;
            this.gvAlertRule.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvAlertRule.Size = new System.Drawing.Size(1043, 277);
            this.gvAlertRule.TabIndex = 8;
            this.gvAlertRule.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.gvAlertRule_CellBeginEdit);
            this.gvAlertRule.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvAlertRule_CellClick);
            this.gvAlertRule.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvAlertRule_CellEndEdit);
            this.gvAlertRule.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.gvAlertRule_CellValidating);
            this.gvAlertRule.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvAlertRule_RowEnter);
            // 
            // AlertName
            // 
            this.AlertName.DataPropertyName = "AlertName";
            this.AlertName.Frozen = true;
            this.AlertName.HeaderText = "AlertName";
            this.AlertName.Name = "AlertName";
            this.AlertName.ReadOnly = true;
            // 
            // AlertType
            // 
            this.AlertType.DataPropertyName = "AlertType";
            this.AlertType.HeaderText = "AlertType";
            this.AlertType.Name = "AlertType";
            this.AlertType.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Hour
            // 
            this.Hour.DataPropertyName = "Hour";
            this.Hour.HeaderText = "Hour";
            this.Hour.Name = "Hour";
            // 
            // Minute
            // 
            this.Minute.DataPropertyName = "Minute";
            this.Minute.HeaderText = "Minute";
            this.Minute.Name = "Minute";
            // 
            // SpecificName
            // 
            this.SpecificName.DataPropertyName = "SpecificName";
            this.SpecificName.HeaderText = "SpecificName";
            this.SpecificName.Name = "SpecificName";
            // 
            // PeriodName
            // 
            this.PeriodName.DataPropertyName = "PeriodName";
            this.PeriodName.HeaderText = "PeriodName";
            this.PeriodName.Name = "PeriodName";
            // 
            // EnableDays
            // 
            this.EnableDays.DataPropertyName = "EnableDays";
            this.EnableDays.HeaderText = "EnableDays";
            this.EnableDays.Name = "EnableDays";
            // 
            // EnablePeriodName
            // 
            this.EnablePeriodName.DataPropertyName = "EnablePeriodName";
            this.EnablePeriodName.HeaderText = "EnablePeriodName";
            this.EnablePeriodName.Name = "EnablePeriodName";
            // 
            // BlockWhenTrigger
            // 
            this.BlockWhenTrigger.DataPropertyName = "BlockWhenTrigger";
            this.BlockWhenTrigger.FalseValue = "";
            this.BlockWhenTrigger.HeaderText = "BlockWhenTrigger";
            this.BlockWhenTrigger.Name = "BlockWhenTrigger";
            this.BlockWhenTrigger.TrueValue = "";
            // 
            // CustomMessage
            // 
            this.CustomMessage.DataPropertyName = "CustomMessage";
            this.CustomMessage.HeaderText = "CustomMessage";
            this.CustomMessage.Name = "CustomMessage";
            // 
            // btnAlertRule_Add
            // 
            this.btnAlertRule_Add.Location = new System.Drawing.Point(1056, 232);
            this.btnAlertRule_Add.Name = "btnAlertRule_Add";
            this.btnAlertRule_Add.Size = new System.Drawing.Size(55, 23);
            this.btnAlertRule_Add.TabIndex = 7;
            this.btnAlertRule_Add.Text = "Add";
            this.btnAlertRule_Add.UseVisualStyleBackColor = true;
            // 
            // btnAlertRule_Delete
            // 
            this.btnAlertRule_Delete.Location = new System.Drawing.Point(1057, 261);
            this.btnAlertRule_Delete.Name = "btnAlertRule_Delete";
            this.btnAlertRule_Delete.Size = new System.Drawing.Size(55, 23);
            this.btnAlertRule_Delete.TabIndex = 6;
            this.btnAlertRule_Delete.Text = "Delete";
            this.btnAlertRule_Delete.UseVisualStyleBackColor = true;
            // 
            // Period
            // 
            this.Period.Controls.Add(this.btnPeriodDelete);
            this.Period.Controls.Add(this.gvPeriodSetting);
            this.Period.Controls.Add(this.btnPeriod_Add);
            this.Period.Location = new System.Drawing.Point(4, 22);
            this.Period.Name = "Period";
            this.Period.Padding = new System.Windows.Forms.Padding(3);
            this.Period.Size = new System.Drawing.Size(1121, 290);
            this.Period.TabIndex = 2;
            this.Period.Text = "Period Setting";
            this.Period.UseVisualStyleBackColor = true;
            // 
            // btnPeriodDelete
            // 
            this.btnPeriodDelete.Location = new System.Drawing.Point(472, 261);
            this.btnPeriodDelete.Name = "btnPeriodDelete";
            this.btnPeriodDelete.Size = new System.Drawing.Size(55, 23);
            this.btnPeriodDelete.TabIndex = 13;
            this.btnPeriodDelete.Text = "Delete";
            this.btnPeriodDelete.UseVisualStyleBackColor = true;
            this.btnPeriodDelete.Click += new System.EventHandler(this.btnPeriodDelete_Click);
            // 
            // gvPeriodSetting
            // 
            this.gvPeriodSetting.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvPeriodSetting.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PeriodName1,
            this.hour_begin,
            this.hour_end});
            this.gvPeriodSetting.Location = new System.Drawing.Point(6, 6);
            this.gvPeriodSetting.Name = "gvPeriodSetting";
            this.gvPeriodSetting.RowTemplate.Height = 24;
            this.gvPeriodSetting.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvPeriodSetting.Size = new System.Drawing.Size(448, 278);
            this.gvPeriodSetting.TabIndex = 12;
            this.gvPeriodSetting.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.gvPeriodSetting_CellBeginEdit);
            this.gvPeriodSetting.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvPeriodSetting_CellEndEdit);
            this.gvPeriodSetting.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvPeriodSetting_CellLeave);
            this.gvPeriodSetting.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.gvPeriodSetting_CellValidating);
            // 
            // PeriodName1
            // 
            this.PeriodName1.DataPropertyName = "PeriodName";
            this.PeriodName1.HeaderText = "PeriodName";
            this.PeriodName1.Name = "PeriodName1";
            this.PeriodName1.ReadOnly = true;
            // 
            // hour_begin
            // 
            this.hour_begin.DataPropertyName = "Hour_begin";
            this.hour_begin.HeaderText = "Hour begin";
            this.hour_begin.Name = "hour_begin";
            // 
            // hour_end
            // 
            this.hour_end.DataPropertyName = "Hour_end";
            this.hour_end.HeaderText = "Hour end";
            this.hour_end.Name = "hour_end";
            // 
            // btnPeriod_Add
            // 
            this.btnPeriod_Add.Location = new System.Drawing.Point(472, 234);
            this.btnPeriod_Add.Name = "btnPeriod_Add";
            this.btnPeriod_Add.Size = new System.Drawing.Size(55, 23);
            this.btnPeriod_Add.TabIndex = 4;
            this.btnPeriod_Add.Text = "Add";
            this.btnPeriod_Add.UseVisualStyleBackColor = true;
            this.btnPeriod_Add.Click += new System.EventHandler(this.btnPeriod_Add_Click);
            // 
            // tbActivitySearch
            // 
            this.tbActivitySearch.Controls.Add(this.label2);
            this.tbActivitySearch.Controls.Add(this.btnSearch);
            this.tbActivitySearch.Controls.Add(this.tbSearchResult);
            this.tbActivitySearch.Controls.Add(this.tbSearchField);
            this.tbActivitySearch.Location = new System.Drawing.Point(4, 22);
            this.tbActivitySearch.Name = "tbActivitySearch";
            this.tbActivitySearch.Padding = new System.Windows.Forms.Padding(3);
            this.tbActivitySearch.Size = new System.Drawing.Size(1121, 290);
            this.tbActivitySearch.TabIndex = 3;
            this.tbActivitySearch.Text = "Activity Search";
            this.tbActivitySearch.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(272, 37);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tbSearchResult
            // 
            this.tbSearchResult.FormattingEnabled = true;
            this.tbSearchResult.ItemHeight = 12;
            this.tbSearchResult.Location = new System.Drawing.Point(30, 106);
            this.tbSearchResult.Name = "tbSearchResult";
            this.tbSearchResult.Size = new System.Drawing.Size(495, 172);
            this.tbSearchResult.TabIndex = 1;
            // 
            // tbSearchField
            // 
            this.tbSearchField.Location = new System.Drawing.Point(30, 24);
            this.tbSearchField.Multiline = true;
            this.tbSearchField.Name = "tbSearchField";
            this.tbSearchField.Size = new System.Drawing.Size(236, 50);
            this.tbSearchField.TabIndex = 0;
            // 
            // periodRuleBindingSource
            // 
            this.periodRuleBindingSource.DataSource = typeof(RescueTime_SaveBusyDude.Model.ConfigModel.PeriodRule);
            // 
            // alertRuleBindingSource
            // 
            this.alertRuleBindingSource.DataSource = typeof(RescueTime_SaveBusyDude.Model.ConfigModel.AlertRule);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "可搜尋Actitivy或Category，用逗號分隔";
            // 
            // ConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 330);
            this.Controls.Add(this.tcConfigForm);
            this.Name = "ConfigForm";
            this.Text = "ConfigForm";
            this.tcConfigForm.ResumeLayout(false);
            this.Basic.ResumeLayout(false);
            this.Basic.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.AlertRule.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvAlertRule)).EndInit();
            this.Period.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvPeriodSetting)).EndInit();
            this.tbActivitySearch.ResumeLayout(false);
            this.tbActivitySearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.periodRuleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alertRuleBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcConfigForm;
        private System.Windows.Forms.TabPage Basic;
        private System.Windows.Forms.TextBox tbApiKey;
        private System.Windows.Forms.Label lbApiKey;
        private System.Windows.Forms.TabPage AlertRule;
        private System.Windows.Forms.TabPage Period;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbBlockMode;
        private System.Windows.Forms.ComboBox cbBlockingMode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPeriod_Add;
        private System.Windows.Forms.Button btnSaveBasic;
        private System.Windows.Forms.Button btnBlockingList_Add;
        private System.Windows.Forms.Button btnBlockingList_Delete;
        private System.Windows.Forms.Button btnBlockingList_Edit;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button btnAlertRule_Add;
        private System.Windows.Forms.Button btnAlertRule_Delete;
        private System.Windows.Forms.DataGridView gvAlertRule;
        private System.Windows.Forms.BindingSource alertRuleBindingSource;
        private System.Windows.Forms.DataGridView gvPeriodSetting;
        private System.Windows.Forms.BindingSource periodRuleBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn PeriodName1;
        private System.Windows.Forms.DataGridViewTextBoxColumn hour_begin;
        private System.Windows.Forms.DataGridViewTextBoxColumn hour_end;
        private System.Windows.Forms.Button btnPeriodDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn AlertName;
        private System.Windows.Forms.DataGridViewComboBoxColumn AlertType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hour;
        private System.Windows.Forms.DataGridViewTextBoxColumn Minute;
        private System.Windows.Forms.DataGridViewTextBoxColumn SpecificName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PeriodName;
        private System.Windows.Forms.DataGridViewTextBoxColumn EnableDays;
        private System.Windows.Forms.DataGridViewTextBoxColumn EnablePeriodName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn BlockWhenTrigger;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomMessage;
        private System.Windows.Forms.TabPage tbActivitySearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ListBox tbSearchResult;
        private System.Windows.Forms.TextBox tbSearchField;
        private System.Windows.Forms.Label label2;
    }
}