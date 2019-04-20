namespace RescueTime_SaveBusyDude.Forms
{
    partial class FocusMode
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
            this.lbFocus1 = new System.Windows.Forms.Label();
            this.lbFocus2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btnGetFocus = new System.Windows.Forms.Button();
            this.lbFocus3 = new System.Windows.Forms.Label();
            this.lbFocus4 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbFocus1
            // 
            this.lbFocus1.AutoSize = true;
            this.lbFocus1.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbFocus1.Location = new System.Drawing.Point(8, 3);
            this.lbFocus1.Name = "lbFocus1";
            this.lbFocus1.Size = new System.Drawing.Size(125, 31);
            this.lbFocus1.TabIndex = 0;
            this.lbFocus1.Text = "Focus for ";
            // 
            // lbFocus2
            // 
            this.lbFocus2.AutoSize = true;
            this.lbFocus2.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbFocus2.Location = new System.Drawing.Point(248, 3);
            this.lbFocus2.Name = "lbFocus2";
            this.lbFocus2.Size = new System.Drawing.Size(108, 31);
            this.lbFocus2.TabIndex = 1;
            this.lbFocus2.Text = "minutes";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(139, 12);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(103, 22);
            this.numericUpDown1.TabIndex = 2;
            // 
            // btnGetFocus
            // 
            this.btnGetFocus.Location = new System.Drawing.Point(281, 47);
            this.btnGetFocus.Name = "btnGetFocus";
            this.btnGetFocus.Size = new System.Drawing.Size(75, 23);
            this.btnGetFocus.TabIndex = 3;
            this.btnGetFocus.Text = "Get Focused!";
            this.btnGetFocus.UseVisualStyleBackColor = true;
            // 
            // lbFocus3
            // 
            this.lbFocus3.AutoSize = true;
            this.lbFocus3.Location = new System.Drawing.Point(71, 52);
            this.lbFocus3.Name = "lbFocus3";
            this.lbFocus3.Size = new System.Drawing.Size(171, 12);
            this.lbFocus3.TabIndex = 4;
            this.lbFocus3.Text = "to configure your blocking settings.";
            // 
            // lbFocus4
            // 
            this.lbFocus4.AutoSize = true;
            this.lbFocus4.Location = new System.Drawing.Point(12, 52);
            this.lbFocus4.Name = "lbFocus4";
            this.lbFocus4.Size = new System.Drawing.Size(53, 12);
            this.lbFocus4.TabIndex = 5;
            this.lbFocus4.TabStop = true;
            this.lbFocus4.Text = "Click here";
            // 
            // FocusMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 74);
            this.Controls.Add(this.lbFocus4);
            this.Controls.Add(this.lbFocus3);
            this.Controls.Add(this.btnGetFocus);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.lbFocus2);
            this.Controls.Add(this.lbFocus1);
            this.Name = "FocusMode";
            this.Text = "FocusMode";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbFocus1;
        private System.Windows.Forms.Label lbFocus2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button btnGetFocus;
        private System.Windows.Forms.Label lbFocus3;
        private System.Windows.Forms.LinkLabel lbFocus4;
    }
}