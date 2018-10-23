namespace STK
{
    partial class FrmAddBank
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
            this.btnDongY = new System.Windows.Forms.Button();
            this.txtMaNganHang = new System.Windows.Forms.TextBox();
            this.txtTenNganHang = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã ngân hàng : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên ngân hàng : ";
            // 
            // btnDongY
            // 
            this.btnDongY.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDongY.Location = new System.Drawing.Point(87, 105);
            this.btnDongY.Name = "btnDongY";
            this.btnDongY.Size = new System.Drawing.Size(85, 28);
            this.btnDongY.TabIndex = 2;
            this.btnDongY.Text = "Đồng ý";
            this.btnDongY.UseVisualStyleBackColor = true;
            this.btnDongY.Click += new System.EventHandler(this.btnDongY_Click);
            // 
            // txtMaNganHang
            // 
            this.txtMaNganHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNganHang.Location = new System.Drawing.Point(107, 27);
            this.txtMaNganHang.Name = "txtMaNganHang";
            this.txtMaNganHang.Size = new System.Drawing.Size(139, 21);
            this.txtMaNganHang.TabIndex = 3;
            this.txtMaNganHang.TextChanged += new System.EventHandler(this.txtMaNganHang_TextChanged);
            // 
            // txtTenNganHang
            // 
            this.txtTenNganHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNganHang.Location = new System.Drawing.Point(107, 64);
            this.txtTenNganHang.Name = "txtTenNganHang";
            this.txtTenNganHang.Size = new System.Drawing.Size(139, 21);
            this.txtTenNganHang.TabIndex = 4;
            this.txtTenNganHang.TextChanged += new System.EventHandler(this.txtTenNganHang_TextChanged);
            // 
            // FrmAddBank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(261, 142);
            this.Controls.Add(this.txtTenNganHang);
            this.Controls.Add(this.txtMaNganHang);
            this.Controls.Add(this.btnDongY);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmAddBank";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm ngân hàng";
            this.Load += new System.EventHandler(this.FrmAddBank_Load);
            this.TextChanged += new System.EventHandler(this.FrmAddBank_TextChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDongY;
        private System.Windows.Forms.TextBox txtMaNganHang;
        private System.Windows.Forms.TextBox txtTenNganHang;
    }
}