namespace COLM_SYSTEM.Discounts
{
    partial class frm_discount_entry
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbEducationLevel = new System.Windows.Forms.ComboBox();
            this.cmbYearLevel = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDiscountCode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbDiscountType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ch_TFee = new System.Windows.Forms.CheckBox();
            this.ch_MFee = new System.Windows.Forms.CheckBox();
            this.ch_OFee = new System.Windows.Forms.CheckBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtTFee = new System.Windows.Forms.TextBox();
            this.txtMFee = new System.Windows.Forms.TextBox();
            this.txtOFee = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblRemaining = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ch_customize = new System.Windows.Forms.CheckBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.er = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtDiscountValue = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.er)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "EDUCATION LEVEL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(159, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "YEAR LEVEL";
            // 
            // cmbEducationLevel
            // 
            this.cmbEducationLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEducationLevel.FormattingEnabled = true;
            this.er.SetIconPadding(this.cmbEducationLevel, -20);
            this.cmbEducationLevel.Items.AddRange(new object[] {
            "PRE ELEMENTARY",
            "ELEMENTARY",
            "JUNIOR HIGH",
            "SENIOR HIGH"});
            this.cmbEducationLevel.Location = new System.Drawing.Point(15, 108);
            this.cmbEducationLevel.Name = "cmbEducationLevel";
            this.cmbEducationLevel.Size = new System.Drawing.Size(141, 25);
            this.cmbEducationLevel.TabIndex = 2;
            this.cmbEducationLevel.SelectedIndexChanged += new System.EventHandler(this.cmbEducationLevel_SelectedIndexChanged);
            // 
            // cmbYearLevel
            // 
            this.cmbYearLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbYearLevel.FormattingEnabled = true;
            this.er.SetIconPadding(this.cmbYearLevel, -20);
            this.cmbYearLevel.Location = new System.Drawing.Point(162, 108);
            this.cmbYearLevel.Name = "cmbYearLevel";
            this.cmbYearLevel.Size = new System.Drawing.Size(141, 25);
            this.cmbYearLevel.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "DISCOUNT CODE";
            // 
            // txtDiscountCode
            // 
            this.er.SetIconPadding(this.txtDiscountCode, -20);
            this.txtDiscountCode.Location = new System.Drawing.Point(15, 29);
            this.txtDiscountCode.Multiline = true;
            this.txtDiscountCode.Name = "txtDiscountCode";
            this.txtDiscountCode.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDiscountCode.Size = new System.Drawing.Size(288, 56);
            this.txtDiscountCode.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "DISCOUNT TYPE";
            // 
            // cmbDiscountType
            // 
            this.cmbDiscountType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDiscountType.FormattingEnabled = true;
            this.er.SetIconPadding(this.cmbDiscountType, -20);
            this.cmbDiscountType.Items.AddRange(new object[] {
            "PERCENTAGE",
            "AMOUNT"});
            this.cmbDiscountType.Location = new System.Drawing.Point(15, 156);
            this.cmbDiscountType.Name = "cmbDiscountType";
            this.cmbDiscountType.Size = new System.Drawing.Size(141, 25);
            this.cmbDiscountType.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(159, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "VALUE / AMOUNT";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "AFFECTED FEES";
            // 
            // ch_TFee
            // 
            this.ch_TFee.AutoSize = true;
            this.ch_TFee.Location = new System.Drawing.Point(20, 50);
            this.ch_TFee.Name = "ch_TFee";
            this.ch_TFee.Size = new System.Drawing.Size(95, 21);
            this.ch_TFee.TabIndex = 12;
            this.ch_TFee.Text = "TUITION FEE";
            this.ch_TFee.UseVisualStyleBackColor = true;
            // 
            // ch_MFee
            // 
            this.ch_MFee.AutoSize = true;
            this.ch_MFee.Location = new System.Drawing.Point(20, 80);
            this.ch_MFee.Name = "ch_MFee";
            this.ch_MFee.Size = new System.Drawing.Size(141, 21);
            this.ch_MFee.TabIndex = 13;
            this.ch_MFee.Text = "MISCELLANEOUS FEE";
            this.ch_MFee.UseVisualStyleBackColor = true;
            // 
            // ch_OFee
            // 
            this.ch_OFee.AutoSize = true;
            this.ch_OFee.Location = new System.Drawing.Point(20, 110);
            this.ch_OFee.Name = "ch_OFee";
            this.ch_OFee.Size = new System.Drawing.Size(95, 21);
            this.ch_OFee.TabIndex = 14;
            this.ch_OFee.Text = "OTHER FEES";
            this.ch_OFee.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Source Sans Pro", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button3.Location = new System.Drawing.Point(79, 435);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(111, 31);
            this.button3.TabIndex = 23;
            this.button3.Text = "CANCEL";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Source Sans Pro", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(196, 435);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 31);
            this.button1.TabIndex = 22;
            this.button1.Text = "SAVE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtTFee
            // 
            this.er.SetIconPadding(this.txtTFee, -20);
            this.txtTFee.Location = new System.Drawing.Point(167, 48);
            this.txtTFee.Name = "txtTFee";
            this.txtTFee.Size = new System.Drawing.Size(90, 24);
            this.txtTFee.TabIndex = 24;
            this.txtTFee.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtMFee
            // 
            this.er.SetIconPadding(this.txtMFee, -20);
            this.txtMFee.Location = new System.Drawing.Point(167, 78);
            this.txtMFee.Name = "txtMFee";
            this.txtMFee.Size = new System.Drawing.Size(90, 24);
            this.txtMFee.TabIndex = 25;
            this.txtMFee.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtOFee
            // 
            this.er.SetIconPadding(this.txtOFee, -20);
            this.txtOFee.Location = new System.Drawing.Point(167, 108);
            this.txtOFee.Name = "txtOFee";
            this.txtOFee.Size = new System.Drawing.Size(90, 24);
            this.txtOFee.TabIndex = 26;
            this.txtOFee.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(164, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 17);
            this.label7.TabIndex = 27;
            this.label7.Text = "PERCENTAGE";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(93, 146);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 17);
            this.label8.TabIndex = 28;
            this.label8.Text = "REMAINING";
            // 
            // lblRemaining
            // 
            this.lblRemaining.Location = new System.Drawing.Point(195, 146);
            this.lblRemaining.Name = "lblRemaining";
            this.lblRemaining.Size = new System.Drawing.Size(68, 17);
            this.lblRemaining.TabIndex = 29;
            this.lblRemaining.Text = "0";
            this.lblRemaining.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(269, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(19, 17);
            this.label9.TabIndex = 30;
            this.label9.Text = "%";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(269, 81);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(19, 17);
            this.label10.TabIndex = 31;
            this.label10.Text = "%";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(269, 111);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(19, 17);
            this.label11.TabIndex = 32;
            this.label11.Text = "%";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(269, 146);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(19, 17);
            this.label12.TabIndex = 33;
            this.label12.Text = "%";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.ch_TFee);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.ch_MFee);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.ch_OFee);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtTFee);
            this.groupBox1.Controls.Add(this.lblRemaining);
            this.groupBox1.Controls.Add(this.txtMFee);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtOFee);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(15, 219);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(292, 174);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            // 
            // ch_customize
            // 
            this.ch_customize.AutoSize = true;
            this.ch_customize.Location = new System.Drawing.Point(15, 201);
            this.ch_customize.Name = "ch_customize";
            this.ch_customize.Size = new System.Drawing.Size(173, 21);
            this.ch_customize.TabIndex = 35;
            this.ch_customize.Text = "CUSTOMIZE COMPUTATION";
            this.ch_customize.UseVisualStyleBackColor = true;
            this.ch_customize.CheckedChanged += new System.EventHandler(this.ch_customize_CheckedChanged);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(235, 202);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(72, 17);
            this.linkLabel1.TabIndex = 36;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "What\'s this?";
            // 
            // er
            // 
            this.er.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.er.ContainerControl = this;
            // 
            // txtDiscountValue
            // 
            this.er.SetIconPadding(this.txtDiscountValue, -20);
            this.txtDiscountValue.Location = new System.Drawing.Point(162, 157);
            this.txtDiscountValue.Name = "txtDiscountValue";
            this.txtDiscountValue.Size = new System.Drawing.Size(141, 24);
            this.txtDiscountValue.TabIndex = 9;
            this.txtDiscountValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frm_discount_entry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 483);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.ch_customize);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDiscountValue);
            this.Controls.Add(this.cmbDiscountType);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDiscountCode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbYearLevel);
            this.Controls.Add(this.cmbEducationLevel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Source Sans Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_discount_entry";
            this.Text = "DISCOUNT ENTRY / UDPATE";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.er)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbEducationLevel;
        private System.Windows.Forms.ComboBox cmbYearLevel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDiscountCode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbDiscountType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox ch_TFee;
        private System.Windows.Forms.CheckBox ch_MFee;
        private System.Windows.Forms.CheckBox ch_OFee;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtTFee;
        private System.Windows.Forms.TextBox txtMFee;
        private System.Windows.Forms.TextBox txtOFee;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblRemaining;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox ch_customize;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.ErrorProvider er;
        private System.Windows.Forms.TextBox txtDiscountValue;
    }
}