namespace RescueTime_SaveBusyDude.Forms
{
    partial class PeriodRule
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
            this.lbPeriodName = new System.Windows.Forms.Label();
            this.tbPeriodName = new System.Windows.Forms.TextBox();
            this.lbHour_Bebin = new System.Windows.Forms.Label();
            this.tbHourBebin = new System.Windows.Forms.NumericUpDown();
            this.tbHourEnd = new System.Windows.Forms.NumericUpDown();
            this.lbHour_end = new System.Windows.Forms.Label();
            this.btnPeriodSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tbHourBebin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbHourEnd)).BeginInit();
            this.SuspendLayout();
            // 
            // lbPeriodName
            // 
            this.lbPeriodName.AutoSize = true;
            this.lbPeriodName.Location = new System.Drawing.Point(12, 13);
            this.lbPeriodName.Name = "lbPeriodName";
            this.lbPeriodName.Size = new System.Drawing.Size(74, 12);
            this.lbPeriodName.TabIndex = 0;
            this.lbPeriodName.Text = "PeriodName：";
            // 
            // tbPeriodName
            // 
            this.tbPeriodName.Location = new System.Drawing.Point(92, 13);
            this.tbPeriodName.Name = "tbPeriodName";
            this.tbPeriodName.Size = new System.Drawing.Size(120, 22);
            this.tbPeriodName.TabIndex = 1;
            // 
            // lbHour_Bebin
            // 
            this.lbHour_Bebin.AutoSize = true;
            this.lbHour_Bebin.Location = new System.Drawing.Point(12, 55);
            this.lbHour_Bebin.Name = "lbHour_Bebin";
            this.lbHour_Bebin.Size = new System.Drawing.Size(70, 12);
            this.lbHour_Bebin.TabIndex = 2;
            this.lbHour_Bebin.Text = "Hour begin：";
            // 
            // tbHourBebin
            // 
            this.tbHourBebin.Location = new System.Drawing.Point(92, 53);
            this.tbHourBebin.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.tbHourBebin.Name = "tbHourBebin";
            this.tbHourBebin.Size = new System.Drawing.Size(120, 22);
            this.tbHourBebin.TabIndex = 3;
            // 
            // tbHourEnd
            // 
            this.tbHourEnd.Location = new System.Drawing.Point(92, 95);
            this.tbHourEnd.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.tbHourEnd.Name = "tbHourEnd";
            this.tbHourEnd.Size = new System.Drawing.Size(120, 22);
            this.tbHourEnd.TabIndex = 5;
            // 
            // lbHour_end
            // 
            this.lbHour_end.AutoSize = true;
            this.lbHour_end.Location = new System.Drawing.Point(12, 97);
            this.lbHour_end.Name = "lbHour_end";
            this.lbHour_end.Size = new System.Drawing.Size(61, 12);
            this.lbHour_end.TabIndex = 4;
            this.lbHour_end.Text = "Hour end：";
            // 
            // btnPeriodSave
            // 
            this.btnPeriodSave.Location = new System.Drawing.Point(137, 123);
            this.btnPeriodSave.Name = "btnPeriodSave";
            this.btnPeriodSave.Size = new System.Drawing.Size(75, 23);
            this.btnPeriodSave.TabIndex = 6;
            this.btnPeriodSave.Text = "Save";
            this.btnPeriodSave.UseVisualStyleBackColor = true;
            this.btnPeriodSave.Click += new System.EventHandler(this.btnPeriodSave_Click);
            // 
            // PeriodRule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 155);
            this.Controls.Add(this.btnPeriodSave);
            this.Controls.Add(this.tbHourEnd);
            this.Controls.Add(this.lbHour_end);
            this.Controls.Add(this.tbHourBebin);
            this.Controls.Add(this.lbHour_Bebin);
            this.Controls.Add(this.tbPeriodName);
            this.Controls.Add(this.lbPeriodName);
            this.Name = "PeriodRule";
            this.Text = "PeriodRule";
            ((System.ComponentModel.ISupportInitialize)(this.tbHourBebin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbHourEnd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbPeriodName;
        private System.Windows.Forms.TextBox tbPeriodName;
        private System.Windows.Forms.Label lbHour_Bebin;
        private System.Windows.Forms.NumericUpDown tbHourBebin;
        private System.Windows.Forms.NumericUpDown tbHourEnd;
        private System.Windows.Forms.Label lbHour_end;
        private System.Windows.Forms.Button btnPeriodSave;
    }
}