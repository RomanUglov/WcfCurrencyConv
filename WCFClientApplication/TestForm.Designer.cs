namespace WCFClientApplication
{
    partial class WcfTestForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WcfTestForm));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelState = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBoxIn = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnTestExpCSV = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxExpCsvCode = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dtpExpCSVFrom = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.dtpExpCSVTo = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnTestConv = new System.Windows.Forms.Button();
            this.tbxRateBCode = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbxRateACode = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbxConvSum = new System.Windows.Forms.TextBox();
            this.dtpConv = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTestRate = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxRateCode = new System.Windows.Forms.TextBox();
            this.dtpRateTo = new System.Windows.Forms.DateTimePicker();
            this.dtpRateFrom = new System.Windows.Forms.DateTimePicker();
            this.groupBoxOut = new System.Windows.Forms.GroupBox();
            this.lbxOutput = new System.Windows.Forms.ListBox();
            this.timerCheckState = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBoxIn.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBoxOut.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabelState});
            this.statusStrip1.Location = new System.Drawing.Point(0, 545);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(542, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(69, 17);
            this.toolStripStatusLabel1.Text = "Состояние:";
            // 
            // toolStripStatusLabelState
            // 
            this.toolStripStatusLabelState.Margin = new System.Windows.Forms.Padding(10, 3, 0, 2);
            this.toolStripStatusLabelState.Name = "toolStripStatusLabelState";
            this.toolStripStatusLabelState.Size = new System.Drawing.Size(0, 17);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 5);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBoxIn);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBoxOut);
            this.splitContainer1.Size = new System.Drawing.Size(542, 540);
            this.splitContainer1.SplitterDistance = 332;
            this.splitContainer1.TabIndex = 1;
            // 
            // groupBoxIn
            // 
            this.groupBoxIn.Controls.Add(this.groupBox3);
            this.groupBoxIn.Controls.Add(this.groupBox2);
            this.groupBoxIn.Controls.Add(this.groupBox1);
            this.groupBoxIn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxIn.Location = new System.Drawing.Point(0, 0);
            this.groupBoxIn.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.groupBoxIn.Name = "groupBoxIn";
            this.groupBoxIn.Size = new System.Drawing.Size(542, 332);
            this.groupBoxIn.TabIndex = 0;
            this.groupBoxIn.TabStop = false;
            this.groupBoxIn.Text = "Параметры:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnTestExpCSV);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.tbxExpCsvCode);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.dtpExpCSVFrom);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.dtpExpCSVTo);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.Location = new System.Drawing.Point(12, 202);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(518, 81);
            this.groupBox3.TabIndex = 29;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Экспорт CSV:";
            // 
            // btnTestExpCSV
            // 
            this.btnTestExpCSV.Location = new System.Drawing.Point(437, 46);
            this.btnTestExpCSV.Name = "btnTestExpCSV";
            this.btnTestExpCSV.Size = new System.Drawing.Size(75, 23);
            this.btnTestExpCSV.TabIndex = 13;
            this.btnTestExpCSV.Tag = "exp";
            this.btnTestExpCSV.Text = "Тест";
            this.btnTestExpCSV.UseVisualStyleBackColor = true;
            this.btnTestExpCSV.Click += new System.EventHandler(this.btnTestRate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(15, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Код валюты";
            // 
            // tbxExpCsvCode
            // 
            this.tbxExpCsvCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxExpCsvCode.Location = new System.Drawing.Point(86, 23);
            this.tbxExpCsvCode.Name = "tbxExpCsvCode";
            this.tbxExpCsvCode.Size = new System.Drawing.Size(75, 20);
            this.tbxExpCsvCode.TabIndex = 10;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(15, 55);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "За период:";
            // 
            // dtpExpCSVFrom
            // 
            this.dtpExpCSVFrom.CustomFormat = "";
            this.dtpExpCSVFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtpExpCSVFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpExpCSVFrom.Location = new System.Drawing.Point(86, 49);
            this.dtpExpCSVFrom.Name = "dtpExpCSVFrom";
            this.dtpExpCSVFrom.Size = new System.Drawing.Size(123, 20);
            this.dtpExpCSVFrom.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(215, 55);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(19, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "по";
            // 
            // dtpExpCSVTo
            // 
            this.dtpExpCSVTo.CustomFormat = "";
            this.dtpExpCSVTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtpExpCSVTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpExpCSVTo.Location = new System.Drawing.Point(240, 49);
            this.dtpExpCSVTo.Name = "dtpExpCSVTo";
            this.dtpExpCSVTo.Size = new System.Drawing.Size(123, 20);
            this.dtpExpCSVTo.TabIndex = 12;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnTestConv);
            this.groupBox2.Controls.Add(this.tbxRateBCode);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.tbxRateACode);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.tbxConvSum);
            this.groupBox2.Controls.Add(this.dtpConv);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(12, 108);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(518, 88);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Конвертация суммы:";
            // 
            // btnTestConv
            // 
            this.btnTestConv.Location = new System.Drawing.Point(437, 54);
            this.btnTestConv.Name = "btnTestConv";
            this.btnTestConv.Size = new System.Drawing.Size(75, 23);
            this.btnTestConv.TabIndex = 9;
            this.btnTestConv.Tag = "conv";
            this.btnTestConv.Text = "Тест";
            this.btnTestConv.UseVisualStyleBackColor = true;
            this.btnTestConv.Click += new System.EventHandler(this.btnTestRate_Click);
            // 
            // tbxRateBCode
            // 
            this.tbxRateBCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxRateBCode.Location = new System.Drawing.Point(286, 56);
            this.tbxRateBCode.Name = "tbxRateBCode";
            this.tbxRateBCode.Size = new System.Drawing.Size(75, 20);
            this.tbxRateBCode.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(215, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Валюта \"В\"";
            // 
            // tbxRateACode
            // 
            this.tbxRateACode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxRateACode.Location = new System.Drawing.Point(286, 27);
            this.tbxRateACode.Name = "tbxRateACode";
            this.tbxRateACode.Size = new System.Drawing.Size(75, 20);
            this.tbxRateACode.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(215, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Валюта \"А\"";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(15, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "На дату:";
            // 
            // tbxConvSum
            // 
            this.tbxConvSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxConvSum.Location = new System.Drawing.Point(86, 27);
            this.tbxConvSum.Name = "tbxConvSum";
            this.tbxConvSum.Size = new System.Drawing.Size(75, 20);
            this.tbxConvSum.TabIndex = 5;
            // 
            // dtpConv
            // 
            this.dtpConv.CustomFormat = "";
            this.dtpConv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtpConv.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpConv.Location = new System.Drawing.Point(86, 53);
            this.dtpConv.Name = "dtpConv";
            this.dtpConv.Size = new System.Drawing.Size(123, 20);
            this.dtpConv.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(15, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Сумма";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTestRate);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbxRateCode);
            this.groupBox1.Controls.Add(this.dtpRateTo);
            this.groupBox1.Controls.Add(this.dtpRateFrom);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(518, 83);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Курс валют:";
            // 
            // btnTestRate
            // 
            this.btnTestRate.Location = new System.Drawing.Point(437, 49);
            this.btnTestRate.Name = "btnTestRate";
            this.btnTestRate.Size = new System.Drawing.Size(75, 23);
            this.btnTestRate.TabIndex = 4;
            this.btnTestRate.Tag = "rate";
            this.btnTestRate.Text = "Тест";
            this.btnTestRate.UseVisualStyleBackColor = true;
            this.btnTestRate.Click += new System.EventHandler(this.btnTestRate_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(15, 25);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(68, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "Код валюты";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(215, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "по";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(15, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "За период:";
            // 
            // tbxRateCode
            // 
            this.tbxRateCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxRateCode.Location = new System.Drawing.Point(86, 22);
            this.tbxRateCode.Name = "tbxRateCode";
            this.tbxRateCode.Size = new System.Drawing.Size(75, 20);
            this.tbxRateCode.TabIndex = 1;
            // 
            // dtpRateTo
            // 
            this.dtpRateTo.CustomFormat = "";
            this.dtpRateTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtpRateTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpRateTo.Location = new System.Drawing.Point(240, 48);
            this.dtpRateTo.Name = "dtpRateTo";
            this.dtpRateTo.Size = new System.Drawing.Size(123, 20);
            this.dtpRateTo.TabIndex = 3;
            // 
            // dtpRateFrom
            // 
            this.dtpRateFrom.CustomFormat = "";
            this.dtpRateFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtpRateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpRateFrom.Location = new System.Drawing.Point(86, 48);
            this.dtpRateFrom.Name = "dtpRateFrom";
            this.dtpRateFrom.Size = new System.Drawing.Size(123, 20);
            this.dtpRateFrom.TabIndex = 2;
            // 
            // groupBoxOut
            // 
            this.groupBoxOut.Controls.Add(this.lbxOutput);
            this.groupBoxOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxOut.Location = new System.Drawing.Point(0, 0);
            this.groupBoxOut.Name = "groupBoxOut";
            this.groupBoxOut.Size = new System.Drawing.Size(542, 204);
            this.groupBoxOut.TabIndex = 0;
            this.groupBoxOut.TabStop = false;
            this.groupBoxOut.Text = "Выходные данные:";
            // 
            // lbxOutput
            // 
            this.lbxOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbxOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbxOutput.FormattingEnabled = true;
            this.lbxOutput.Location = new System.Drawing.Point(3, 16);
            this.lbxOutput.Name = "lbxOutput";
            this.lbxOutput.Size = new System.Drawing.Size(536, 185);
            this.lbxOutput.TabIndex = 0;
            // 
            // timerCheckState
            // 
            this.timerCheckState.Interval = 1000;
            this.timerCheckState.Tick += new System.EventHandler(this.timerCheckState_Tick);
            // 
            // WcfTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 567);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WcfTestForm";
            this.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Тест-клиент WCF сервиса";
            this.Load += new System.EventHandler(this.WcfTestForm_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBoxIn.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxOut.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelState;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBoxIn;
        private System.Windows.Forms.GroupBox groupBoxOut;
        private System.Windows.Forms.ListBox lbxOutput;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnTestExpCSV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxExpCsvCode;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dtpExpCSVFrom;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtpExpCSVTo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnTestConv;
        private System.Windows.Forms.TextBox tbxRateBCode;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbxRateACode;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbxConvSum;
        private System.Windows.Forms.DateTimePicker dtpConv;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTestRate;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxRateCode;
        private System.Windows.Forms.DateTimePicker dtpRateTo;
        private System.Windows.Forms.DateTimePicker dtpRateFrom;
        private System.Windows.Forms.Timer timerCheckState;
    }
}

