namespace CompanyController
{
    partial class HourlPayCalcPanel
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewSalaryCalc = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnExitDate = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lblstart = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnStartDate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dateTimePickerExit = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSalaryCalc)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox1.Controls.Add(this.dataGridViewSalaryCalc);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(24, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1601, 723);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Salary calculate";
            // 
            // dataGridViewSalaryCalc
            // 
            this.dataGridViewSalaryCalc.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridViewSalaryCalc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSalaryCalc.Location = new System.Drawing.Point(18, 22);
            this.dataGridViewSalaryCalc.Name = "dataGridViewSalaryCalc";
            this.dataGridViewSalaryCalc.RowTemplate.Height = 24;
            this.dataGridViewSalaryCalc.Size = new System.Drawing.Size(1563, 499);
            this.dataGridViewSalaryCalc.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox2.Controls.Add(this.btnExitDate);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.lblstart);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnStartDate);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnCalc);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.dateTimePickerExit);
            this.groupBox2.Location = new System.Drawing.Point(764, 542);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(817, 161);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Calculate Panel";
            // 
            // btnExitDate
            // 
            this.btnExitDate.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnExitDate.Location = new System.Drawing.Point(98, 99);
            this.btnExitDate.Name = "btnExitDate";
            this.btnExitDate.Size = new System.Drawing.Size(104, 37);
            this.btnExitDate.TabIndex = 11;
            this.btnExitDate.Text = "Exit";
            this.btnExitDate.UseVisualStyleBackColor = false;
            this.btnExitDate.Click += new System.EventHandler(this.btnExitDate_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(487, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "4.  ";
            // 
            // lblstart
            // 
            this.lblstart.AutoSize = true;
            this.lblstart.Location = new System.Drawing.Point(267, 50);
            this.lblstart.Name = "lblstart";
            this.lblstart.Size = new System.Drawing.Size(116, 17);
            this.lblstart.TabIndex = 9;
            this.lblstart.Text = "MM/dd/yyyy h:i:m";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(72, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "2.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "1.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(229, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(12, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = ":";
            // 
            // btnStartDate
            // 
            this.btnStartDate.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnStartDate.Location = new System.Drawing.Point(98, 40);
            this.btnStartDate.Name = "btnStartDate";
            this.btnStartDate.Size = new System.Drawing.Size(104, 37);
            this.btnStartDate.TabIndex = 5;
            this.btnStartDate.Text = "Start";
            this.btnStartDate.UseVisualStyleBackColor = false;
            this.btnStartDate.Click += new System.EventHandler(this.btnStartDate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(487, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "3.    Hourly Pay";
            // 
            // btnCalc
            // 
            this.btnCalc.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCalc.Location = new System.Drawing.Point(521, 91);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(222, 52);
            this.btnCalc.TabIndex = 3;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = false;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "10",
            "20",
            "30",
            "40",
            "50",
            "60",
            "70",
            "80",
            "90",
            "100"});
            this.comboBox1.Location = new System.Drawing.Point(621, 46);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(122, 24);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.Text = "10";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dateTimePickerExit
            // 
            this.dateTimePickerExit.CustomFormat = "MM/dd/yyyy h:i:m";
            this.dateTimePickerExit.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerExit.Location = new System.Drawing.Point(232, 106);
            this.dateTimePickerExit.Name = "dateTimePickerExit";
            this.dateTimePickerExit.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerExit.TabIndex = 1;
            // 
            // HourlPayCalcPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1656, 760);
            this.Controls.Add(this.groupBox1);
            this.Name = "HourlPayCalcPanel";
            this.Text = "HourlPayCalcPanel";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSalaryCalc)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewSalaryCalc;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnStartDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePickerExit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblstart;
        private System.Windows.Forms.Button btnExitDate;
    }
}