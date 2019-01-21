namespace CompanyController
{
    partial class CompanyUniversalPanel
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnclearlist = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSalaryCalcPanel = new System.Windows.Forms.Button();
            this.btnAverage = new System.Windows.Forms.Button();
            this.btnAllWorkers = new System.Windows.Forms.Button();
            this.btnDeleteWorker = new System.Windows.Forms.Button();
            this.btnAddWorker = new System.Windows.Forms.Button();
            this.dataGridViewUniversal = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUniversal)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox1.Controls.Add(this.btnclearlist);
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.dataGridViewUniversal);
            this.groupBox1.Location = new System.Drawing.Point(12, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1519, 695);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Welcome";
            // 
            // btnclearlist
            // 
            this.btnclearlist.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnclearlist.Location = new System.Drawing.Point(341, 623);
            this.btnclearlist.Name = "btnclearlist";
            this.btnclearlist.Size = new System.Drawing.Size(75, 39);
            this.btnclearlist.TabIndex = 12;
            this.btnclearlist.Text = "Clear";
            this.btnclearlist.UseVisualStyleBackColor = false;
            this.btnclearlist.Click += new System.EventHandler(this.btnclearlist_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange(new object[] {
            "Maasi maas ortalamasindan cox olan torpilliler"});
            this.listBox1.Location = new System.Drawing.Point(29, 514);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(294, 148);
            this.listBox1.TabIndex = 11;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox2.Controls.Add(this.btnSalaryCalcPanel);
            this.groupBox2.Controls.Add(this.btnAverage);
            this.groupBox2.Controls.Add(this.btnAllWorkers);
            this.groupBox2.Controls.Add(this.btnDeleteWorker);
            this.groupBox2.Controls.Add(this.btnAddWorker);
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(795, 519);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(692, 143);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "control panel";
            // 
            // btnSalaryCalcPanel
            // 
            this.btnSalaryCalcPanel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSalaryCalcPanel.Location = new System.Drawing.Point(50, 89);
            this.btnSalaryCalcPanel.Name = "btnSalaryCalcPanel";
            this.btnSalaryCalcPanel.Size = new System.Drawing.Size(169, 39);
            this.btnSalaryCalcPanel.TabIndex = 10;
            this.btnSalaryCalcPanel.Text = "Hourly Salary Calculate ";
            this.btnSalaryCalcPanel.UseVisualStyleBackColor = false;
            this.btnSalaryCalcPanel.Click += new System.EventHandler(this.btnSalaryCalcPanel_Click);
            // 
            // btnAverage
            // 
            this.btnAverage.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAverage.Location = new System.Drawing.Point(241, 89);
            this.btnAverage.Name = "btnAverage";
            this.btnAverage.Size = new System.Drawing.Size(75, 39);
            this.btnAverage.TabIndex = 7;
            this.btnAverage.Text = "Average";
            this.btnAverage.UseVisualStyleBackColor = false;
            this.btnAverage.Click += new System.EventHandler(this.btnAverage_Click);
            // 
            // btnAllWorkers
            // 
            this.btnAllWorkers.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAllWorkers.Location = new System.Drawing.Point(442, 41);
            this.btnAllWorkers.Name = "btnAllWorkers";
            this.btnAllWorkers.Size = new System.Drawing.Size(136, 42);
            this.btnAllWorkers.TabIndex = 9;
            this.btnAllWorkers.Text = "All Workers";
            this.btnAllWorkers.UseVisualStyleBackColor = false;
            this.btnAllWorkers.Click += new System.EventHandler(this.btnAllWorkers_Click);
            // 
            // btnDeleteWorker
            // 
            this.btnDeleteWorker.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDeleteWorker.Location = new System.Drawing.Point(522, 89);
            this.btnDeleteWorker.Name = "btnDeleteWorker";
            this.btnDeleteWorker.Size = new System.Drawing.Size(164, 39);
            this.btnDeleteWorker.TabIndex = 8;
            this.btnDeleteWorker.Text = "Delete worker";
            this.btnDeleteWorker.UseVisualStyleBackColor = false;
            this.btnDeleteWorker.Click += new System.EventHandler(this.btnDeleteWorker_Click);
            // 
            // btnAddWorker
            // 
            this.btnAddWorker.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAddWorker.Location = new System.Drawing.Point(346, 89);
            this.btnAddWorker.Name = "btnAddWorker";
            this.btnAddWorker.Size = new System.Drawing.Size(138, 39);
            this.btnAddWorker.TabIndex = 6;
            this.btnAddWorker.Text = "Add Worker";
            this.btnAddWorker.UseVisualStyleBackColor = false;
            this.btnAddWorker.Click += new System.EventHandler(this.btnAddWorker_Click);
            // 
            // dataGridViewUniversal
            // 
            this.dataGridViewUniversal.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridViewUniversal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUniversal.Location = new System.Drawing.Point(29, 32);
            this.dataGridViewUniversal.Name = "dataGridViewUniversal";
            this.dataGridViewUniversal.RowTemplate.Height = 24;
            this.dataGridViewUniversal.Size = new System.Drawing.Size(1458, 458);
            this.dataGridViewUniversal.TabIndex = 0;
            // 
            // CompanyUniversalPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1544, 738);
            this.Controls.Add(this.groupBox1);
            this.Name = "CompanyUniversalPanel";
            this.Text = "CompanyUniversalPanel";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUniversal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridViewUniversal;
        private System.Windows.Forms.Button btnSalaryCalcPanel;
        private System.Windows.Forms.Button btnAverage;
        private System.Windows.Forms.Button btnAllWorkers;
        private System.Windows.Forms.Button btnDeleteWorker;
        private System.Windows.Forms.Button btnAddWorker;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnclearlist;
    }
}