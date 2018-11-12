namespace STK
{
    partial class FrmDSSTK
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDSSTK));
            this.lbnGetEmail = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.testMonth = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaSo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoTienGui = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KyHan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayGui = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LaiSuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbnSoTienGui = new System.Windows.Forms.Label();
            this.lbnIntKH = new System.Windows.Forms.Label();
            this.lbnIntKyHan = new System.Windows.Forms.Label();
            this.lbnKyHan = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Xem = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.lbnKey = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picPlusSTK = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbnSo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbnTongTien = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnTatToan = new System.Windows.Forms.Button();
            this.btnRut1Phan = new System.Windows.Forms.Button();
            this.btnGuiThem = new System.Windows.Forms.Button();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlusSTK)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbnGetEmail
            // 
            this.lbnGetEmail.AutoSize = true;
            this.lbnGetEmail.Location = new System.Drawing.Point(106, 49);
            this.lbnGetEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbnGetEmail.Name = "lbnGetEmail";
            this.lbnGetEmail.Size = new System.Drawing.Size(51, 20);
            this.lbnGetEmail.TabIndex = 0;
            this.lbnGetEmail.Text = "label1";
            this.lbnGetEmail.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.testMonth);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.lbnSoTienGui);
            this.panel1.Controls.Add(this.lbnIntKH);
            this.panel1.Controls.Add(this.lbnIntKyHan);
            this.panel1.Controls.Add(this.lbnKyHan);
            this.panel1.Controls.Add(this.dataGridView2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lbnKey);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.picPlusSTK);
            this.panel1.Controls.Add(this.lbnGetEmail);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lbnSo);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lbnTongTien);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(18, 18);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1188, 630);
            this.panel1.TabIndex = 2;
            // 
            // testMonth
            // 
            this.testMonth.AutoSize = true;
            this.testMonth.Location = new System.Drawing.Point(111, 225);
            this.testMonth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.testMonth.Name = "testMonth";
            this.testMonth.Size = new System.Drawing.Size(51, 20);
            this.testMonth.TabIndex = 18;
            this.testMonth.Text = "label6";
            this.testMonth.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.MaSo,
            this.SoTienGui,
            this.KyHan,
            this.NgayGui,
            this.LaiSuat});
            this.dataGridView1.Location = new System.Drawing.Point(16, 111);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1155, 289);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "Mã";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // MaSo
            // 
            this.MaSo.DataPropertyName = "MaSo";
            this.MaSo.HeaderText = "Mã sổ";
            this.MaSo.Name = "MaSo";
            this.MaSo.ReadOnly = true;
            // 
            // SoTienGui
            // 
            this.SoTienGui.DataPropertyName = "SoTienGui";
            this.SoTienGui.HeaderText = "Tổng số tiền gốc";
            this.SoTienGui.Name = "SoTienGui";
            this.SoTienGui.ReadOnly = true;
            // 
            // KyHan
            // 
            this.KyHan.DataPropertyName = "KyHan";
            this.KyHan.HeaderText = "Kỳ hạn";
            this.KyHan.Name = "KyHan";
            this.KyHan.ReadOnly = true;
            // 
            // NgayGui
            // 
            this.NgayGui.DataPropertyName = "NgayGui";
            this.NgayGui.HeaderText = "Ngày tạo";
            this.NgayGui.Name = "NgayGui";
            this.NgayGui.ReadOnly = true;
            // 
            // LaiSuat
            // 
            this.LaiSuat.DataPropertyName = "LaiSuat";
            this.LaiSuat.HeaderText = "Lãi suất";
            this.LaiSuat.Name = "LaiSuat";
            this.LaiSuat.ReadOnly = true;
            // 
            // lbnSoTienGui
            // 
            this.lbnSoTienGui.AutoSize = true;
            this.lbnSoTienGui.Location = new System.Drawing.Point(762, 15);
            this.lbnSoTienGui.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbnSoTienGui.Name = "lbnSoTienGui";
            this.lbnSoTienGui.Size = new System.Drawing.Size(51, 20);
            this.lbnSoTienGui.TabIndex = 17;
            this.lbnSoTienGui.Text = "label6";
            this.lbnSoTienGui.Visible = false;
            // 
            // lbnIntKH
            // 
            this.lbnIntKH.AutoSize = true;
            this.lbnIntKH.Location = new System.Drawing.Point(916, 25);
            this.lbnIntKH.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbnIntKH.Name = "lbnIntKH";
            this.lbnIntKH.Size = new System.Drawing.Size(51, 20);
            this.lbnIntKH.TabIndex = 16;
            this.lbnIntKH.Text = "label6";
            this.lbnIntKH.Visible = false;
            // 
            // lbnIntKyHan
            // 
            this.lbnIntKyHan.AutoSize = true;
            this.lbnIntKyHan.Location = new System.Drawing.Point(174, 0);
            this.lbnIntKyHan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbnIntKyHan.Name = "lbnIntKyHan";
            this.lbnIntKyHan.Size = new System.Drawing.Size(51, 20);
            this.lbnIntKyHan.TabIndex = 15;
            this.lbnIntKyHan.Text = "label6";
            this.lbnIntKyHan.Visible = false;
            // 
            // lbnKyHan
            // 
            this.lbnKyHan.AutoSize = true;
            this.lbnKyHan.Location = new System.Drawing.Point(16, 25);
            this.lbnKyHan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbnKyHan.Name = "lbnKyHan";
            this.lbnKyHan.Size = new System.Drawing.Size(51, 20);
            this.lbnKyHan.TabIndex = 14;
            this.lbnKyHan.Text = "label6";
            this.lbnKyHan.Visible = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn6,
            this.Xem});
            this.dataGridView2.Location = new System.Drawing.Point(16, 437);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(1155, 180);
            this.dataGridView2.TabIndex = 13;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            this.dataGridView2.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView2_CellFormatting);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "MaSo";
            this.dataGridViewTextBoxColumn2.HeaderText = "Mã sổ";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "SoTienGui";
            this.dataGridViewTextBoxColumn3.HeaderText = "Tổng số tiền gốc";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "KyHan";
            this.dataGridViewTextBoxColumn4.HeaderText = "Kỳ hạn";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "LaiSuat";
            this.dataGridViewTextBoxColumn6.HeaderText = "Lãi suất";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // Xem
            // 
            this.Xem.HeaderText = "Xem";
            this.Xem.Name = "Xem";
            this.Xem.ReadOnly = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(12, 405);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 29);
            this.label5.TabIndex = 12;
            this.label5.Text = "Đã tất toán";
            // 
            // lbnKey
            // 
            this.lbnKey.AutoSize = true;
            this.lbnKey.Location = new System.Drawing.Point(195, 49);
            this.lbnKey.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbnKey.Name = "lbnKey";
            this.lbnKey.Size = new System.Drawing.Size(56, 20);
            this.lbnKey.TabIndex = 11;
            this.lbnKey.Text = "lbnKey";
            this.lbnKey.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1038, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // picPlusSTK
            // 
            this.picPlusSTK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picPlusSTK.Image = ((System.Drawing.Image)(resources.GetObject("picPlusSTK.Image")));
            this.picPlusSTK.Location = new System.Drawing.Point(1119, 15);
            this.picPlusSTK.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picPlusSTK.Name = "picPlusSTK";
            this.picPlusSTK.Size = new System.Drawing.Size(52, 54);
            this.picPlusSTK.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPlusSTK.TabIndex = 8;
            this.picPlusSTK.TabStop = false;
            this.picPlusSTK.Click += new System.EventHandler(this.picPlusSTK_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(784, 60);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 34);
            this.label4.TabIndex = 7;
            this.label4.Text = "sổ )";
            // 
            // lbnSo
            // 
            this.lbnSo.AutoSize = true;
            this.lbnSo.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnSo.Location = new System.Drawing.Point(736, 60);
            this.lbnSo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbnSo.Name = "lbnSo";
            this.lbnSo.Size = new System.Drawing.Size(0, 34);
            this.lbnSo.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(712, 60);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 34);
            this.label3.TabIndex = 5;
            this.label3.Text = "(";
            // 
            // lbnTongTien
            // 
            this.lbnTongTien.AutoSize = true;
            this.lbnTongTien.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnTongTien.Location = new System.Drawing.Point(519, 60);
            this.lbnTongTien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbnTongTien.Name = "lbnTongTien";
            this.lbnTongTien.Size = new System.Drawing.Size(95, 34);
            this.lbnTongTien.TabIndex = 4;
            this.lbnTongTien.Text = "xxxxx";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(362, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 34);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tổng tiền :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(488, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 34);
            this.label1.TabIndex = 2;
            this.label1.Text = "SỔ TIẾT KIỆM";
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Snow;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(68, 12);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(174, 54);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btnTatToan);
            this.panel2.Controls.Add(this.btnRut1Phan);
            this.panel2.Controls.Add(this.btnGuiThem);
            this.panel2.Controls.Add(this.btnEdit);
            this.panel2.Location = new System.Drawing.Point(18, 673);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1188, 78);
            this.panel2.TabIndex = 3;
            // 
            // btnTatToan
            // 
            this.btnTatToan.BackColor = System.Drawing.Color.Snow;
            this.btnTatToan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTatToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTatToan.Location = new System.Drawing.Point(916, 12);
            this.btnTatToan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTatToan.Name = "btnTatToan";
            this.btnTatToan.Size = new System.Drawing.Size(174, 54);
            this.btnTatToan.TabIndex = 6;
            this.btnTatToan.Text = "Tất toán";
            this.btnTatToan.UseVisualStyleBackColor = false;
            this.btnTatToan.Click += new System.EventHandler(this.btnTatToan_Click);
            // 
            // btnRut1Phan
            // 
            this.btnRut1Phan.BackColor = System.Drawing.Color.Snow;
            this.btnRut1Phan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRut1Phan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRut1Phan.Location = new System.Drawing.Point(632, 12);
            this.btnRut1Phan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRut1Phan.Name = "btnRut1Phan";
            this.btnRut1Phan.Size = new System.Drawing.Size(174, 54);
            this.btnRut1Phan.TabIndex = 5;
            this.btnRut1Phan.Text = "Rút một phần";
            this.btnRut1Phan.UseVisualStyleBackColor = false;
            this.btnRut1Phan.Click += new System.EventHandler(this.btnRut1Phan_Click);
            // 
            // btnGuiThem
            // 
            this.btnGuiThem.BackColor = System.Drawing.Color.Snow;
            this.btnGuiThem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuiThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuiThem.Location = new System.Drawing.Point(345, 12);
            this.btnGuiThem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGuiThem.Name = "btnGuiThem";
            this.btnGuiThem.Size = new System.Drawing.Size(174, 54);
            this.btnGuiThem.TabIndex = 4;
            this.btnGuiThem.Text = "Gửi thêm";
            this.btnGuiThem.UseVisualStyleBackColor = false;
            this.btnGuiThem.Click += new System.EventHandler(this.btnGuiThem_Click);
            // 
            // FrmDSSTK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(1224, 778);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmDSSTK";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách sổ tiết kiệm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmDSSTK_FormClosed);
            this.Load += new System.EventHandler(this.FrmDSSTK_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlusSTK)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbnGetEmail;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picPlusSTK;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbnSo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbnTongTien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnTatToan;
        private System.Windows.Forms.Button btnRut1Phan;
        private System.Windows.Forms.Button btnGuiThem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbnKey;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label lbnKyHan;
        private System.Windows.Forms.Label lbnIntKyHan;
        private System.Windows.Forms.Label lbnIntKH;
        private System.Windows.Forms.Label lbnSoTienGui;
        private System.Windows.Forms.Label testMonth;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSo;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoTienGui;
        private System.Windows.Forms.DataGridViewTextBoxColumn KyHan;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayGui;
        private System.Windows.Forms.DataGridViewTextBoxColumn LaiSuat;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewButtonColumn Xem;
    }
}