namespace DoAn
{
    partial class QuanLyDangKyMonHoc
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvdkmon = new System.Windows.Forms.DataGridView();
            this.masv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monhoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hocky = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bttthem = new System.Windows.Forms.Button();
            this.bttxoa = new System.Windows.Forms.Button();
            this.bttsua = new System.Windows.Forms.Button();
            this.bttthoat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdkmon)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(308, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(374, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ ĐĂNG KÝ MÔN HỌC";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bttthoat);
            this.groupBox1.Controls.Add(this.bttsua);
            this.groupBox1.Controls.Add(this.bttxoa);
            this.groupBox1.Controls.Add(this.bttthem);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(27, 111);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(270, 299);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "grbdkmon";
            // 
            // dgvdkmon
            // 
            this.dgvdkmon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdkmon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.masv,
            this.ten,
            this.monhoc,
            this.hocky});
            this.dgvdkmon.Location = new System.Drawing.Point(313, 111);
            this.dgvdkmon.Name = "dgvdkmon";
            this.dgvdkmon.RowHeadersWidth = 51;
            this.dgvdkmon.RowTemplate.Height = 24;
            this.dgvdkmon.Size = new System.Drawing.Size(644, 312);
            this.dgvdkmon.TabIndex = 2;
            // 
            // masv
            // 
            this.masv.HeaderText = "Mã SV";
            this.masv.MinimumWidth = 6;
            this.masv.Name = "masv";
            this.masv.Width = 125;
            // 
            // ten
            // 
            this.ten.HeaderText = "Tên SV";
            this.ten.MinimumWidth = 6;
            this.ten.Name = "ten";
            this.ten.Width = 125;
            // 
            // monhoc
            // 
            this.monhoc.HeaderText = "Tên Môn Học";
            this.monhoc.MinimumWidth = 6;
            this.monhoc.Name = "monhoc";
            this.monhoc.Width = 125;
            // 
            // hocky
            // 
            this.hocky.HeaderText = "Học Kỳ";
            this.hocky.MinimumWidth = 6;
            this.hocky.Name = "hocky";
            this.hocky.Width = 125;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Họ Tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên Môn Học";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Học Kỳ";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(131, 72);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 1;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(131, 42);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 24);
            this.comboBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(131, 105);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 2;
            // 
            // bttthem
            // 
            this.bttthem.Location = new System.Drawing.Point(6, 220);
            this.bttthem.Name = "bttthem";
            this.bttthem.Size = new System.Drawing.Size(75, 23);
            this.bttthem.TabIndex = 3;
            this.bttthem.Text = "Thêm";
            this.bttthem.UseVisualStyleBackColor = true;
            // 
            // bttxoa
            // 
            this.bttxoa.Location = new System.Drawing.Point(105, 220);
            this.bttxoa.Name = "bttxoa";
            this.bttxoa.Size = new System.Drawing.Size(75, 23);
            this.bttxoa.TabIndex = 3;
            this.bttxoa.Text = "Xóa";
            this.bttxoa.UseVisualStyleBackColor = true;
            // 
            // bttsua
            // 
            this.bttsua.Location = new System.Drawing.Point(189, 220);
            this.bttsua.Name = "bttsua";
            this.bttsua.Size = new System.Drawing.Size(75, 23);
            this.bttsua.TabIndex = 3;
            this.bttsua.Text = "Sữa";
            this.bttsua.UseVisualStyleBackColor = true;
            // 
            // bttthoat
            // 
            this.bttthoat.Location = new System.Drawing.Point(24, 260);
            this.bttthoat.Name = "bttthoat";
            this.bttthoat.Size = new System.Drawing.Size(75, 23);
            this.bttthoat.TabIndex = 3;
            this.bttthoat.Text = "Thoát";
            this.bttthoat.UseVisualStyleBackColor = true;
            // 
            // QuanLyDangKyMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 450);
            this.Controls.Add(this.dgvdkmon);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "QuanLyDangKyMonHoc";
            this.Text = "QuanLyDangKyMonHoc";
            this.Load += new System.EventHandler(this.QuanLyDangKyMonHoc_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdkmon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvdkmon;
        private System.Windows.Forms.Button bttthoat;
        private System.Windows.Forms.Button bttsua;
        private System.Windows.Forms.Button bttxoa;
        private System.Windows.Forms.Button bttthem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn masv;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn monhoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn hocky;
    }
}