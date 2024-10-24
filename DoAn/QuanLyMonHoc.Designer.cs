namespace DoAn
{
    partial class QuanLyMonHoc
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
            this.grbmonhoc = new System.Windows.Forms.GroupBox();
            this.dgvmonhoc = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.bttxoa = new System.Windows.Forms.Button();
            this.bttthem = new System.Windows.Forms.Button();
            this.txtmamonhoc = new System.Windows.Forms.TextBox();
            this.txtsotc = new System.Windows.Forms.TextBox();
            this.txttenmonhoc = new System.Windows.Forms.TextBox();
            this.txttietth = new System.Windows.Forms.TextBox();
            this.txttietlt = new System.Windows.Forms.TextBox();
            this.bttsua = new System.Windows.Forms.Button();
            this.mamonhoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenmonhoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sotc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tietlt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tietth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbmonhoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvmonhoc)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(363, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ MÔN HỌC";
            // 
            // grbmonhoc
            // 
            this.grbmonhoc.Controls.Add(this.txttietlt);
            this.grbmonhoc.Controls.Add(this.txttietth);
            this.grbmonhoc.Controls.Add(this.txttenmonhoc);
            this.grbmonhoc.Controls.Add(this.txtsotc);
            this.grbmonhoc.Controls.Add(this.txtmamonhoc);
            this.grbmonhoc.Controls.Add(this.bttsua);
            this.grbmonhoc.Controls.Add(this.bttthem);
            this.grbmonhoc.Controls.Add(this.bttxoa);
            this.grbmonhoc.Controls.Add(this.label6);
            this.grbmonhoc.Controls.Add(this.label5);
            this.grbmonhoc.Controls.Add(this.label4);
            this.grbmonhoc.Controls.Add(this.label3);
            this.grbmonhoc.Controls.Add(this.label2);
            this.grbmonhoc.Location = new System.Drawing.Point(12, 88);
            this.grbmonhoc.Name = "grbmonhoc";
            this.grbmonhoc.Size = new System.Drawing.Size(246, 277);
            this.grbmonhoc.TabIndex = 1;
            this.grbmonhoc.TabStop = false;
            this.grbmonhoc.Text = "Thông Tin";
            // 
            // dgvmonhoc
            // 
            this.dgvmonhoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvmonhoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mamonhoc,
            this.tenmonhoc,
            this.sotc,
            this.tietlt,
            this.tietth});
            this.dgvmonhoc.Location = new System.Drawing.Point(275, 88);
            this.dgvmonhoc.Name = "dgvmonhoc";
            this.dgvmonhoc.RowHeadersWidth = 51;
            this.dgvmonhoc.RowTemplate.Height = 24;
            this.dgvmonhoc.Size = new System.Drawing.Size(694, 277);
            this.dgvmonhoc.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Môn Học";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên Môn Học";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Số TC";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Số Tiết TH";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Số Tiết LT";
            // 
            // bttxoa
            // 
            this.bttxoa.Location = new System.Drawing.Point(99, 228);
            this.bttxoa.Name = "bttxoa";
            this.bttxoa.Size = new System.Drawing.Size(53, 23);
            this.bttxoa.TabIndex = 1;
            this.bttxoa.Text = "Xóa";
            this.bttxoa.UseVisualStyleBackColor = true;
            // 
            // bttthem
            // 
            this.bttthem.Location = new System.Drawing.Point(10, 228);
            this.bttthem.Name = "bttthem";
            this.bttthem.Size = new System.Drawing.Size(53, 23);
            this.bttthem.TabIndex = 1;
            this.bttthem.Text = "Thêm";
            this.bttthem.UseVisualStyleBackColor = true;
            // 
            // txtmamonhoc
            // 
            this.txtmamonhoc.Location = new System.Drawing.Point(112, 22);
            this.txtmamonhoc.Name = "txtmamonhoc";
            this.txtmamonhoc.Size = new System.Drawing.Size(128, 22);
            this.txtmamonhoc.TabIndex = 2;
            // 
            // txtsotc
            // 
            this.txtsotc.Location = new System.Drawing.Point(112, 96);
            this.txtsotc.Name = "txtsotc";
            this.txtsotc.Size = new System.Drawing.Size(128, 22);
            this.txtsotc.TabIndex = 2;
            // 
            // txttenmonhoc
            // 
            this.txttenmonhoc.Location = new System.Drawing.Point(112, 59);
            this.txttenmonhoc.Name = "txttenmonhoc";
            this.txttenmonhoc.Size = new System.Drawing.Size(128, 22);
            this.txttenmonhoc.TabIndex = 2;
            // 
            // txttietth
            // 
            this.txttietth.Location = new System.Drawing.Point(112, 181);
            this.txttietth.Name = "txttietth";
            this.txttietth.Size = new System.Drawing.Size(128, 22);
            this.txttietth.TabIndex = 2;
            // 
            // txttietlt
            // 
            this.txttietlt.Location = new System.Drawing.Point(112, 141);
            this.txttietlt.Name = "txttietlt";
            this.txttietlt.Size = new System.Drawing.Size(128, 22);
            this.txttietlt.TabIndex = 2;
            // 
            // bttsua
            // 
            this.bttsua.Location = new System.Drawing.Point(176, 228);
            this.bttsua.Name = "bttsua";
            this.bttsua.Size = new System.Drawing.Size(53, 23);
            this.bttsua.TabIndex = 1;
            this.bttsua.Text = "Sữa";
            this.bttsua.UseVisualStyleBackColor = true;
            // 
            // mamonhoc
            // 
            this.mamonhoc.HeaderText = "Mã Môn Học";
            this.mamonhoc.MinimumWidth = 6;
            this.mamonhoc.Name = "mamonhoc";
            this.mamonhoc.Width = 125;
            // 
            // tenmonhoc
            // 
            this.tenmonhoc.HeaderText = "Tên Môn Học";
            this.tenmonhoc.MinimumWidth = 6;
            this.tenmonhoc.Name = "tenmonhoc";
            this.tenmonhoc.Width = 125;
            // 
            // sotc
            // 
            this.sotc.HeaderText = "Số TC";
            this.sotc.MinimumWidth = 6;
            this.sotc.Name = "sotc";
            this.sotc.Width = 125;
            // 
            // tietlt
            // 
            this.tietlt.HeaderText = "Số Tiết LT";
            this.tietlt.MinimumWidth = 6;
            this.tietlt.Name = "tietlt";
            this.tietlt.Width = 125;
            // 
            // tietth
            // 
            this.tietth.HeaderText = "Số Tiết TH";
            this.tietth.MinimumWidth = 6;
            this.tietth.Name = "tietth";
            this.tietth.Width = 125;
            // 
            // QuanLyMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 384);
            this.Controls.Add(this.dgvmonhoc);
            this.Controls.Add(this.grbmonhoc);
            this.Controls.Add(this.label1);
            this.Name = "QuanLyMonHoc";
            this.Text = "QuanLyMonHoc";
            this.grbmonhoc.ResumeLayout(false);
            this.grbmonhoc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvmonhoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grbmonhoc;
        private System.Windows.Forms.DataGridView dgvmonhoc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txttietlt;
        private System.Windows.Forms.TextBox txttietth;
        private System.Windows.Forms.TextBox txttenmonhoc;
        private System.Windows.Forms.TextBox txtsotc;
        private System.Windows.Forms.TextBox txtmamonhoc;
        private System.Windows.Forms.Button bttthem;
        private System.Windows.Forms.Button bttxoa;
        private System.Windows.Forms.Button bttsua;
        private System.Windows.Forms.DataGridViewTextBoxColumn mamonhoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenmonhoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn sotc;
        private System.Windows.Forms.DataGridViewTextBoxColumn tietlt;
        private System.Windows.Forms.DataGridViewTextBoxColumn tietth;
    }
}