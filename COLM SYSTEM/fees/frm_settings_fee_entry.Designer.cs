namespace COLM_SYSTEM
{
    partial class frm_settings_fee_entry
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFee = new System.Windows.Forms.TextBox();
            this.cmbFeeType = new System.Windows.Forms.ComboBox();
            this.cmbEducationLevel = new System.Windows.Forms.ComboBox();
            this.cmbYearLevel = new System.Windows.Forms.ComboBox();
            this.txtFeeAmount = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "FEE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "TYPE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "AMOUNT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(185, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "YEAR LEVEL";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "EDUCATION LEVEL";
            // 
            // txtFee
            // 
            this.txtFee.Location = new System.Drawing.Point(15, 29);
            this.txtFee.Name = "txtFee";
            this.txtFee.Size = new System.Drawing.Size(297, 24);
            this.txtFee.TabIndex = 5;
            // 
            // cmbFeeType
            // 
            this.cmbFeeType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFeeType.FormattingEnabled = true;
            this.cmbFeeType.Items.AddRange(new object[] {
            "TUITION FEE",
            "MISCELLANEOUS FEE",
            "ADDITIONAL FEE"});
            this.cmbFeeType.Location = new System.Drawing.Point(15, 76);
            this.cmbFeeType.Name = "cmbFeeType";
            this.cmbFeeType.Size = new System.Drawing.Size(297, 25);
            this.cmbFeeType.TabIndex = 6;
            // 
            // cmbEducationLevel
            // 
            this.cmbEducationLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEducationLevel.FormattingEnabled = true;
            this.cmbEducationLevel.Items.AddRange(new object[] {
            "PRE ELEMENTARY",
            "ELEMENTARY",
            "JUNIOR HIGH",
            "SENIOR HIGH"});
            this.cmbEducationLevel.Location = new System.Drawing.Point(15, 124);
            this.cmbEducationLevel.Name = "cmbEducationLevel";
            this.cmbEducationLevel.Size = new System.Drawing.Size(167, 25);
            this.cmbEducationLevel.TabIndex = 7;
            // 
            // cmbYearLevel
            // 
            this.cmbYearLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbYearLevel.FormattingEnabled = true;
            this.cmbYearLevel.Items.AddRange(new object[] {
            "PRE KINDER",
            "KINDER",
            "GRADE 1",
            "GRADE 2",
            "GRADE 3",
            "GRADE 4",
            "GRADE 5",
            "GRADE 6",
            "GRADE 7",
            "GRADE 8",
            "GRADE 9",
            "GRADE 10",
            "GRADE 11",
            "GRADE 12"});
            this.cmbYearLevel.Location = new System.Drawing.Point(188, 124);
            this.cmbYearLevel.Name = "cmbYearLevel";
            this.cmbYearLevel.Size = new System.Drawing.Size(124, 25);
            this.cmbYearLevel.TabIndex = 8;
            // 
            // txtFeeAmount
            // 
            this.txtFeeAmount.Location = new System.Drawing.Point(15, 172);
            this.txtFeeAmount.Name = "txtFeeAmount";
            this.txtFeeAmount.Size = new System.Drawing.Size(297, 24);
            this.txtFeeAmount.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(237, 217);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 30);
            this.button1.TabIndex = 10;
            this.button1.Text = "SAVE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(156, 217);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 30);
            this.button2.TabIndex = 11;
            this.button2.Text = "CANCEL";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 270);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtFeeAmount);
            this.Controls.Add(this.cmbYearLevel);
            this.Controls.Add(this.cmbEducationLevel);
            this.Controls.Add(this.cmbFeeType);
            this.Controls.Add(this.txtFee);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Source Sans Pro SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "FEE SETTINGS ENTRY";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFee;
        private System.Windows.Forms.ComboBox cmbFeeType;
        private System.Windows.Forms.ComboBox cmbEducationLevel;
        private System.Windows.Forms.ComboBox cmbYearLevel;
        private System.Windows.Forms.TextBox txtFeeAmount;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

