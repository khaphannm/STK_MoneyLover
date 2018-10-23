namespace STK
{
    partial class FRMThemSTK
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMThemSTK));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMaSo = new System.Windows.Forms.TextBox();
            this.txtSoTienGui = new System.Windows.Forms.TextBox();
            this.cbbKyHan = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtLaiSuat = new System.Windows.Forms.TextBox();
            this.cbbTraLai = new System.Windows.Forms.ComboBox();
            this.cbbKhiDenHan = new System.Windows.Forms.ComboBox();
            this.txtLKKH = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbbNganHang = new System.Windows.Forms.ComboBox();
            this.nganHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_MoneyDataSet = new STK.db_MoneyDataSet();
            this.bthThem = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.dbMoneyDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nganHangTableAdapter = new STK.db_MoneyDataSetTableAdapters.NganHangTableAdapter();
            this.labMaNganHang = new System.Windows.Forms.Label();
            this.labkhidenhan = new System.Windows.Forms.Label();
            this.labTraLai = new System.Windows.Forms.Label();
            this.labKyHan = new System.Windows.Forms.Label();
            this.lab_Get_Email = new System.Windows.Forms.Label();
            this.labTatToan = new System.Windows.Forms.Label();
            this.labLKKH = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nganHangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_MoneyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbMoneyDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(22, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "THÊM SỔ TIẾT KIỆM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã sổ :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(211, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngân hàng :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày gửi :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(214, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Số tiền gửi :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(235, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Kỳ hạn :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(21, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "Lãi suất :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(21, 211);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 15);
            this.label8.TabIndex = 7;
            this.label8.Text = "Lãi suất không kỳ hạn :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(30, 168);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 15);
            this.label9.TabIndex = 8;
            this.label9.Text = "Trả lãi :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(206, 129);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 15);
            this.label10.TabIndex = 9;
            this.label10.Text = "Khi đến hạn :";
            // 
            // txtMaSo
            // 
            this.txtMaSo.Location = new System.Drawing.Point(123, 52);
            this.txtMaSo.Name = "txtMaSo";
            this.txtMaSo.Size = new System.Drawing.Size(66, 20);
            this.txtMaSo.TabIndex = 10;
            // 
            // txtSoTienGui
            // 
            this.txtSoTienGui.Location = new System.Drawing.Point(291, 91);
            this.txtSoTienGui.Name = "txtSoTienGui";
            this.txtSoTienGui.Size = new System.Drawing.Size(139, 20);
            this.txtSoTienGui.TabIndex = 11;
            // 
            // cbbKyHan
            // 
            this.cbbKyHan.FormattingEnabled = true;
            this.cbbKyHan.Items.AddRange(new object[] {
            "Không kỳ hạn",
            "1 tháng",
            "3 tháng",
            "6 tháng",
            "12 tháng"});
            this.cbbKyHan.Location = new System.Drawing.Point(291, 168);
            this.cbbKyHan.Name = "cbbKyHan";
            this.cbbKyHan.Size = new System.Drawing.Size(139, 21);
            this.cbbKyHan.TabIndex = 13;
            this.cbbKyHan.SelectedIndexChanged += new System.EventHandler(this.cbbKyHan_SelectedIndexChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(83, 88);
            this.dateTimePicker1.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(106, 20);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // txtLaiSuat
            // 
            this.txtLaiSuat.Location = new System.Drawing.Point(83, 128);
            this.txtLaiSuat.Name = "txtLaiSuat";
            this.txtLaiSuat.Size = new System.Drawing.Size(56, 20);
            this.txtLaiSuat.TabIndex = 15;
            // 
            // cbbTraLai
            // 
            this.cbbTraLai.FormattingEnabled = true;
            this.cbbTraLai.Items.AddRange(new object[] {
            "Đầu kỳ",
            "Cuối Kỳ",
            "Định kỳ hàng tháng"});
            this.cbbTraLai.Location = new System.Drawing.Point(83, 168);
            this.cbbTraLai.Name = "cbbTraLai";
            this.cbbTraLai.Size = new System.Drawing.Size(106, 21);
            this.cbbTraLai.TabIndex = 16;
            this.cbbTraLai.SelectedIndexChanged += new System.EventHandler(this.cbbTraLai_SelectedIndexChanged);
            // 
            // cbbKhiDenHan
            // 
            this.cbbKhiDenHan.FormattingEnabled = true;
            this.cbbKhiDenHan.Items.AddRange(new object[] {
            "Tái tục gốc và lãi",
            "Tái tục gốc",
            "Tất toán sổ"});
            this.cbbKhiDenHan.Location = new System.Drawing.Point(291, 127);
            this.cbbKhiDenHan.Name = "cbbKhiDenHan";
            this.cbbKhiDenHan.Size = new System.Drawing.Size(139, 21);
            this.cbbKhiDenHan.TabIndex = 17;
            this.cbbKhiDenHan.SelectedIndexChanged += new System.EventHandler(this.cbbKhiDenHan_SelectedIndexChanged);
            // 
            // txtLKKH
            // 
            this.txtLKKH.Location = new System.Drawing.Point(158, 210);
            this.txtLKKH.Name = "txtLKKH";
            this.txtLKKH.Size = new System.Drawing.Size(106, 20);
            this.txtLKKH.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(267, 211);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(141, 15);
            this.label11.TabIndex = 19;
            this.label11.Text = "( Mặc định 0.05%/ năm )";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(436, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // cbbNganHang
            // 
            this.cbbNganHang.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.nganHangBindingSource, "TenNganHang", true));
            this.cbbNganHang.FormattingEnabled = true;
            this.cbbNganHang.Items.AddRange(new object[] {
            "HUNG",
            "VIETCOMBANK"});
            this.cbbNganHang.Location = new System.Drawing.Point(291, 51);
            this.cbbNganHang.Name = "cbbNganHang";
            this.cbbNganHang.Size = new System.Drawing.Size(139, 21);
            this.cbbNganHang.TabIndex = 21;
            this.cbbNganHang.SelectedIndexChanged += new System.EventHandler(this.cbbNganHang_SelectedIndexChanged);
            // 
            // nganHangBindingSource
            // 
            this.nganHangBindingSource.DataMember = "NganHang";
            this.nganHangBindingSource.DataSource = this.db_MoneyDataSet;
            // 
            // db_MoneyDataSet
            // 
            this.db_MoneyDataSet.DataSetName = "db_MoneyDataSet";
            this.db_MoneyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bthThem
            // 
            this.bthThem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bthThem.Location = new System.Drawing.Point(102, 255);
            this.bthThem.Name = "bthThem";
            this.bthThem.Size = new System.Drawing.Size(90, 25);
            this.bthThem.TabIndex = 22;
            this.bthThem.Text = "Thêm";
            this.bthThem.UseVisualStyleBackColor = true;
            this.bthThem.Click += new System.EventHandler(this.bthThem_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLamMoi.Location = new System.Drawing.Point(258, 255);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(90, 25);
            this.btnLamMoi.TabIndex = 23;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(145, 129);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 15);
            this.label12.TabIndex = 25;
            this.label12.Text = "%/ năm";
            // 
            // dbMoneyDataSetBindingSource
            // 
            this.dbMoneyDataSetBindingSource.DataSource = this.db_MoneyDataSet;
            this.dbMoneyDataSetBindingSource.Position = 0;
            // 
            // nganHangTableAdapter
            // 
            this.nganHangTableAdapter.ClearBeforeFill = true;
            // 
            // labMaNganHang
            // 
            this.labMaNganHang.AutoSize = true;
            this.labMaNganHang.Location = new System.Drawing.Point(217, 12);
            this.labMaNganHang.Name = "labMaNganHang";
            this.labMaNganHang.Size = new System.Drawing.Size(52, 13);
            this.labMaNganHang.TabIndex = 26;
            this.labMaNganHang.Text = "labMaNH";
            this.labMaNganHang.Visible = false;
            // 
            // labkhidenhan
            // 
            this.labkhidenhan.AutoSize = true;
            this.labkhidenhan.Location = new System.Drawing.Point(276, 12);
            this.labkhidenhan.Name = "labkhidenhan";
            this.labkhidenhan.Size = new System.Drawing.Size(76, 13);
            this.labkhidenhan.TabIndex = 27;
            this.labkhidenhan.Text = "labKhiDenHan";
            this.labkhidenhan.Visible = false;
            // 
            // labTraLai
            // 
            this.labTraLai.AutoSize = true;
            this.labTraLai.Location = new System.Drawing.Point(359, 12);
            this.labTraLai.Name = "labTraLai";
            this.labTraLai.Size = new System.Drawing.Size(51, 13);
            this.labTraLai.TabIndex = 28;
            this.labTraLai.Text = "labTraLai";
            this.labTraLai.Visible = false;
            // 
            // labKyHan
            // 
            this.labKyHan.AutoSize = true;
            this.labKyHan.Location = new System.Drawing.Point(376, 266);
            this.labKyHan.Name = "labKyHan";
            this.labKyHan.Size = new System.Drawing.Size(53, 13);
            this.labKyHan.TabIndex = 29;
            this.labKyHan.Text = "labKyHan";
            // 
            // lab_Get_Email
            // 
            this.lab_Get_Email.AutoSize = true;
            this.lab_Get_Email.Location = new System.Drawing.Point(13, 255);
            this.lab_Get_Email.Name = "lab_Get_Email";
            this.lab_Get_Email.Size = new System.Drawing.Size(47, 13);
            this.lab_Get_Email.TabIndex = 30;
            this.lab_Get_Email.Text = "getEmail";
            this.lab_Get_Email.Visible = false;
            // 
            // labTatToan
            // 
            this.labTatToan.AutoSize = true;
            this.labTatToan.Location = new System.Drawing.Point(379, 238);
            this.labTatToan.Name = "labTatToan";
            this.labTatToan.Size = new System.Drawing.Size(29, 13);
            this.labTatToan.TabIndex = 31;
            this.labTatToan.Text = "false";
            this.labTatToan.Visible = false;
            // 
            // labLKKH
            // 
            this.labLKKH.AutoSize = true;
            this.labLKKH.Location = new System.Drawing.Point(410, 216);
            this.labLKKH.Name = "labLKKH";
            this.labLKKH.Size = new System.Drawing.Size(28, 13);
            this.labLKKH.TabIndex = 32;
            this.labLKKH.Text = "0.05";
            this.labLKKH.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(83, 52);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(43, 20);
            this.textBox1.TabIndex = 33;
            // 
            // FRMThemSTK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(463, 292);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labLKKH);
            this.Controls.Add(this.labTatToan);
            this.Controls.Add(this.lab_Get_Email);
            this.Controls.Add(this.labKyHan);
            this.Controls.Add(this.labTraLai);
            this.Controls.Add(this.labkhidenhan);
            this.Controls.Add(this.labMaNganHang);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.bthThem);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cbbNganHang);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtLKKH);
            this.Controls.Add(this.cbbKhiDenHan);
            this.Controls.Add(this.cbbTraLai);
            this.Controls.Add(this.txtLaiSuat);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cbbKyHan);
            this.Controls.Add(this.txtSoTienGui);
            this.Controls.Add(this.txtMaSo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FRMThemSTK";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm Sổ Tiết Kiệm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FRMThemSTK_FormClosing);
            this.Load += new System.EventHandler(this.FRMThemSTK_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nganHangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_MoneyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbMoneyDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtMaSo;
        private System.Windows.Forms.TextBox txtSoTienGui;
        private System.Windows.Forms.ComboBox cbbKyHan;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtLaiSuat;
        private System.Windows.Forms.ComboBox cbbTraLai;
        private System.Windows.Forms.ComboBox cbbKhiDenHan;
        private System.Windows.Forms.TextBox txtLKKH;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cbbNganHang;
        private System.Windows.Forms.Button bthThem;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.BindingSource dbMoneyDataSetBindingSource;
        private db_MoneyDataSet db_MoneyDataSet;
        private System.Windows.Forms.BindingSource nganHangBindingSource;
        private db_MoneyDataSetTableAdapters.NganHangTableAdapter nganHangTableAdapter;
        private System.Windows.Forms.Label labMaNganHang;
        private System.Windows.Forms.Label labkhidenhan;
        private System.Windows.Forms.Label labTraLai;
        private System.Windows.Forms.Label labKyHan;
        private System.Windows.Forms.Label lab_Get_Email;
        private System.Windows.Forms.Label labTatToan;
        private System.Windows.Forms.Label labLKKH;
        private System.Windows.Forms.TextBox textBox1;
    }
}