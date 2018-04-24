namespace bookstore
{
    partial class Report
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Report));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabReport = new System.Windows.Forms.TabControl();
            this.reportStock = new System.Windows.Forms.TabPage();
            this.btnView = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cbbType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.txtIDowner = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.sellReport = new System.Windows.Forms.TabPage();
            this.btnView1 = new System.Windows.Forms.Button();
            this.btnCancel1 = new System.Windows.Forms.Button();
            this.selldate2 = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.selldate1 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.txtIDowner1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.finanReport = new System.Windows.Forms.TabPage();
            this.btnView2 = new System.Windows.Forms.Button();
            this.btnCancel2 = new System.Windows.Forms.Button();
            this.finandate2 = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.finandate1 = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.txtIDowner2 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabReport.SuspendLayout();
            this.reportStock.SuspendLayout();
            this.sellReport.SuspendLayout();
            this.finanReport.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(82)))), ((int)(((byte)(57)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(935, 61);
            this.panel1.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(15, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(57, 53);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(67, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 31);
            this.label6.TabIndex = 0;
            this.label6.Text = "ดูรายงาน";
            // 
            // tabReport
            // 
            this.tabReport.Controls.Add(this.reportStock);
            this.tabReport.Controls.Add(this.sellReport);
            this.tabReport.Controls.Add(this.finanReport);
            this.tabReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tabReport.Location = new System.Drawing.Point(12, 64);
            this.tabReport.Name = "tabReport";
            this.tabReport.SelectedIndex = 0;
            this.tabReport.Size = new System.Drawing.Size(910, 455);
            this.tabReport.TabIndex = 13;
            // 
            // reportStock
            // 
            this.reportStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(160)))), ((int)(((byte)(157)))));
            this.reportStock.Controls.Add(this.btnView);
            this.reportStock.Controls.Add(this.btnCancel);
            this.reportStock.Controls.Add(this.cbbType);
            this.reportStock.Controls.Add(this.label1);
            this.reportStock.Controls.Add(this.label2);
            this.reportStock.Controls.Add(this.txtDate);
            this.reportStock.Controls.Add(this.txtIDowner);
            this.reportStock.Controls.Add(this.label4);
            this.reportStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.reportStock.Location = new System.Drawing.Point(4, 29);
            this.reportStock.Name = "reportStock";
            this.reportStock.Padding = new System.Windows.Forms.Padding(3);
            this.reportStock.Size = new System.Drawing.Size(902, 422);
            this.reportStock.TabIndex = 0;
            this.reportStock.Text = "รายงานสินค้าคงคลัง";
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(781, 368);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(101, 35);
            this.btnView.TabIndex = 132;
            this.btnView.Text = "ดูรายงาน";
            this.btnView.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(22, 368);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(101, 35);
            this.btnCancel.TabIndex = 131;
            this.btnCancel.Text = "ย้อนกลับ";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cbbType
            // 
            this.cbbType.FormattingEnabled = true;
            this.cbbType.Location = new System.Drawing.Point(351, 108);
            this.cbbType.Name = "cbbType";
            this.cbbType.Size = new System.Drawing.Size(216, 28);
            this.cbbType.TabIndex = 128;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(250, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 127;
            this.label1.Text = "ประเภทหนังสือ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.Location = new System.Drawing.Point(739, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 20);
            this.label2.TabIndex = 126;
            this.label2.Text = "วันที่";
            // 
            // txtDate
            // 
            this.txtDate.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtDate.Location = new System.Drawing.Point(780, 19);
            this.txtDate.Multiline = true;
            this.txtDate.Name = "txtDate";
            this.txtDate.ReadOnly = true;
            this.txtDate.Size = new System.Drawing.Size(102, 27);
            this.txtDate.TabIndex = 125;
            this.txtDate.TabStop = false;
            this.txtDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtIDowner
            // 
            this.txtIDowner.Location = new System.Drawing.Point(82, 16);
            this.txtIDowner.Multiline = true;
            this.txtIDowner.Name = "txtIDowner";
            this.txtIDowner.ReadOnly = true;
            this.txtIDowner.Size = new System.Drawing.Size(120, 27);
            this.txtIDowner.TabIndex = 123;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label4.Location = new System.Drawing.Point(18, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 122;
            this.label4.Text = "รหัสผู้ใช้";
            // 
            // sellReport
            // 
            this.sellReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(160)))), ((int)(((byte)(157)))));
            this.sellReport.Controls.Add(this.btnView1);
            this.sellReport.Controls.Add(this.btnCancel1);
            this.sellReport.Controls.Add(this.selldate2);
            this.sellReport.Controls.Add(this.label8);
            this.sellReport.Controls.Add(this.selldate1);
            this.sellReport.Controls.Add(this.label7);
            this.sellReport.Controls.Add(this.label5);
            this.sellReport.Controls.Add(this.textBox4);
            this.sellReport.Controls.Add(this.txtIDowner1);
            this.sellReport.Controls.Add(this.label3);
            this.sellReport.Location = new System.Drawing.Point(4, 29);
            this.sellReport.Name = "sellReport";
            this.sellReport.Padding = new System.Windows.Forms.Padding(3);
            this.sellReport.Size = new System.Drawing.Size(902, 422);
            this.sellReport.TabIndex = 1;
            this.sellReport.Text = "รายงานการขาย";
            // 
            // btnView1
            // 
            this.btnView1.Location = new System.Drawing.Point(777, 366);
            this.btnView1.Name = "btnView1";
            this.btnView1.Size = new System.Drawing.Size(101, 35);
            this.btnView1.TabIndex = 135;
            this.btnView1.Text = "ดูรายงาน";
            this.btnView1.UseVisualStyleBackColor = true;
            // 
            // btnCancel1
            // 
            this.btnCancel1.Location = new System.Drawing.Point(20, 366);
            this.btnCancel1.Name = "btnCancel1";
            this.btnCancel1.Size = new System.Drawing.Size(101, 35);
            this.btnCancel1.TabIndex = 134;
            this.btnCancel1.Text = "ย้อนกลับ";
            this.btnCancel1.UseVisualStyleBackColor = true;
            this.btnCancel1.Click += new System.EventHandler(this.btnCancel1_Click);
            // 
            // selldate2
            // 
            this.selldate2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.selldate2.Location = new System.Drawing.Point(485, 136);
            this.selldate2.Name = "selldate2";
            this.selldate2.Size = new System.Drawing.Size(127, 26);
            this.selldate2.TabIndex = 133;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label8.Location = new System.Drawing.Point(454, 141);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 20);
            this.label8.TabIndex = 132;
            this.label8.Text = "ถึง";
            // 
            // selldate1
            // 
            this.selldate1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.selldate1.Location = new System.Drawing.Point(321, 136);
            this.selldate1.Name = "selldate1";
            this.selldate1.Size = new System.Drawing.Size(127, 26);
            this.selldate1.TabIndex = 131;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label7.Location = new System.Drawing.Point(255, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 20);
            this.label7.TabIndex = 130;
            this.label7.Text = "ช่วงเวลา";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label5.Location = new System.Drawing.Point(732, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 20);
            this.label5.TabIndex = 129;
            this.label5.Text = " วันที่";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox4.Location = new System.Drawing.Point(777, 21);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(102, 27);
            this.textBox4.TabIndex = 128;
            this.textBox4.TabStop = false;
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtIDowner1
            // 
            this.txtIDowner1.Location = new System.Drawing.Point(80, 17);
            this.txtIDowner1.Multiline = true;
            this.txtIDowner1.Name = "txtIDowner1";
            this.txtIDowner1.ReadOnly = true;
            this.txtIDowner1.Size = new System.Drawing.Size(120, 27);
            this.txtIDowner1.TabIndex = 125;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label3.Location = new System.Drawing.Point(16, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 124;
            this.label3.Text = "รหัสผู้ใช้";
            // 
            // finanReport
            // 
            this.finanReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(160)))), ((int)(((byte)(157)))));
            this.finanReport.Controls.Add(this.btnView2);
            this.finanReport.Controls.Add(this.btnCancel2);
            this.finanReport.Controls.Add(this.finandate2);
            this.finanReport.Controls.Add(this.label9);
            this.finanReport.Controls.Add(this.finandate1);
            this.finanReport.Controls.Add(this.label10);
            this.finanReport.Controls.Add(this.label11);
            this.finanReport.Controls.Add(this.textBox6);
            this.finanReport.Controls.Add(this.txtIDowner2);
            this.finanReport.Controls.Add(this.label12);
            this.finanReport.Location = new System.Drawing.Point(4, 29);
            this.finanReport.Name = "finanReport";
            this.finanReport.Padding = new System.Windows.Forms.Padding(3);
            this.finanReport.Size = new System.Drawing.Size(902, 422);
            this.finanReport.TabIndex = 2;
            this.finanReport.Text = "รายงานการเงิน";
            // 
            // btnView2
            // 
            this.btnView2.Location = new System.Drawing.Point(777, 366);
            this.btnView2.Name = "btnView2";
            this.btnView2.Size = new System.Drawing.Size(101, 35);
            this.btnView2.TabIndex = 146;
            this.btnView2.Text = "ดูรายงาน";
            this.btnView2.UseVisualStyleBackColor = true;
            // 
            // btnCancel2
            // 
            this.btnCancel2.Location = new System.Drawing.Point(20, 366);
            this.btnCancel2.Name = "btnCancel2";
            this.btnCancel2.Size = new System.Drawing.Size(101, 35);
            this.btnCancel2.TabIndex = 145;
            this.btnCancel2.Text = "ย้อนกลับ";
            this.btnCancel2.UseVisualStyleBackColor = true;
            this.btnCancel2.Click += new System.EventHandler(this.btnCancel2_Click);
            // 
            // finandate2
            // 
            this.finandate2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.finandate2.Location = new System.Drawing.Point(485, 136);
            this.finandate2.Name = "finandate2";
            this.finandate2.Size = new System.Drawing.Size(127, 26);
            this.finandate2.TabIndex = 144;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label9.Location = new System.Drawing.Point(454, 141);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 20);
            this.label9.TabIndex = 143;
            this.label9.Text = "ถึง";
            // 
            // finandate1
            // 
            this.finandate1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.finandate1.Location = new System.Drawing.Point(321, 136);
            this.finandate1.Name = "finandate1";
            this.finandate1.Size = new System.Drawing.Size(127, 26);
            this.finandate1.TabIndex = 142;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label10.Location = new System.Drawing.Point(255, 141);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 20);
            this.label10.TabIndex = 141;
            this.label10.Text = "ช่วงเวลา";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label11.Location = new System.Drawing.Point(736, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 20);
            this.label11.TabIndex = 140;
            this.label11.Text = "วันที่";
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox6.Location = new System.Drawing.Point(777, 21);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(102, 27);
            this.textBox6.TabIndex = 139;
            this.textBox6.TabStop = false;
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtIDowner2
            // 
            this.txtIDowner2.Location = new System.Drawing.Point(80, 17);
            this.txtIDowner2.Multiline = true;
            this.txtIDowner2.Name = "txtIDowner2";
            this.txtIDowner2.ReadOnly = true;
            this.txtIDowner2.Size = new System.Drawing.Size(120, 27);
            this.txtIDowner2.TabIndex = 137;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label12.Location = new System.Drawing.Point(16, 24);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 20);
            this.label12.TabIndex = 136;
            this.label12.Text = "รหัสผู้ใช้";
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            this.ClientSize = new System.Drawing.Size(934, 531);
            this.Controls.Add(this.tabReport);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabReport.ResumeLayout(false);
            this.reportStock.ResumeLayout(false);
            this.reportStock.PerformLayout();
            this.sellReport.ResumeLayout(false);
            this.sellReport.PerformLayout();
            this.finanReport.ResumeLayout(false);
            this.finanReport.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabControl tabReport;
        private System.Windows.Forms.TabPage reportStock;
        private System.Windows.Forms.TabPage sellReport;
        private System.Windows.Forms.TabPage finanReport;
        private System.Windows.Forms.TextBox txtIDowner;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.ComboBox cbbType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnView1;
        private System.Windows.Forms.Button btnCancel1;
        private System.Windows.Forms.DateTimePicker selldate2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker selldate1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox txtIDowner1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnView2;
        private System.Windows.Forms.Button btnCancel2;
        private System.Windows.Forms.DateTimePicker finandate2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker finandate1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox txtIDowner2;
        private System.Windows.Forms.Label label12;
    }
}