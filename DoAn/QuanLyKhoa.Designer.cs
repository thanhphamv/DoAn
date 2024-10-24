namespace DoAn
{
    partial class QuanLyKhoa
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
            this.dgvkhoa = new System.Windows.Forms.DataGridView();
            this.makhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenkhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbkhoa = new System.Windows.Forms.GroupBox();
            this.txttenkhoa = new System.Windows.Forms.TextBox();
            this.txtmakhoa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bttxoa = new System.Windows.Forms.Button();
            this.bttsua = new System.Windows.Forms.Button();
            this.bttthem = new System.Windows.Forms.Button();
            this.bttthoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvkhoa)).BeginInit();
            this.grbkhoa.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(311, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ KHOA";
            // 
            // dgvkhoa
            // 
            this.dgvkhoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvkhoa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.makhoa,
            this.tenkhoa});
            this.dgvkhoa.Location = new System.Drawing.Point(303, 92);
            this.dgvkhoa.Name = "dgvkhoa";
            this.dgvkhoa.RowHeadersWidth = 51;
            this.dgvkhoa.RowTemplate.Height = 24;
            this.dgvkhoa.Size = new System.Drawing.Size(607, 282);
            this.dgvkhoa.TabIndex = 1;
            // 
            // makhoa
            // 
            this.makhoa.HeaderText = "Mã Khoa";
            this.makhoa.MinimumWidth = 6;
            this.makhoa.Name = "makhoa";
            this.makhoa.Width = 125;
            // 
            // tenkhoa
            // 
            this.tenkhoa.HeaderText = "Tên Khoa";
            this.tenkhoa.MinimumWidth = 6;
            this.tenkhoa.Name = "tenkhoa";
            this.tenkhoa.Width = 125;
            // 
            // grbkhoa
            // 
            this.grbkhoa.Controls.Add(this.txttenkhoa);
            this.grbkhoa.Controls.Add(this.txtmakhoa);
            this.grbkhoa.Controls.Add(this.label3);
            this.grbkhoa.Controls.Add(this.label2);
            this.grbkhoa.Controls.Add(this.bttthoat);
            this.grbkhoa.Controls.Add(this.bttxoa);
            this.grbkhoa.Controls.Add(this.bttsua);
            this.grbkhoa.Controls.Add(this.bttthem);
            this.grbkhoa.Location = new System.Drawing.Point(12, 92);
            this.grbkhoa.Name = "grbkhoa";
            this.grbkhoa.Size = new System.Drawing.Size(285, 282);
            this.grbkhoa.TabIndex = 2;
            this.grbkhoa.TabStop = false;
            this.grbkhoa.Text = "Thông Tin";
            // 
            // txttenkhoa
            // 
            this.txttenkhoa.Location = new System.Drawing.Point(113, 112);
            this.txttenkhoa.Name = "txttenkhoa";
            this.txttenkhoa.Size = new System.Drawing.Size(137, 22);
            this.txttenkhoa.TabIndex = 2;
            // 
            // txtmakhoa
            // 
            this.txtmakhoa.Location = new System.Drawing.Point(113, 53);
            this.txtmakhoa.Name = "txtmakhoa";
            this.txtmakhoa.Size = new System.Drawing.Size(137, 22);
            this.txtmakhoa.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mã Khoa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Khoa";
            // 
            // bttxoa
            // 
            this.bttxoa.Location = new System.Drawing.Point(194, 169);
            this.bttxoa.Name = "bttxoa";
            this.bttxoa.Size = new System.Drawing.Size(75, 44);
            this.bttxoa.TabIndex = 0;
            this.bttxoa.Text = "Xóa";
            this.bttxoa.UseVisualStyleBackColor = true;
            // 
            // bttsua
            // 
            this.bttsua.Location = new System.Drawing.Point(104, 169);
            this.bttsua.Name = "bttsua";
            this.bttsua.Size = new System.Drawing.Size(75, 44);
            this.bttsua.TabIndex = 0;
            this.bttsua.Text = "Sữa";
            this.bttsua.UseVisualStyleBackColor = true;
            // 
            // bttthem
            // 
            this.bttthem.Location = new System.Drawing.Point(7, 169);
            this.bttthem.Name = "bttthem";
            this.bttthem.Size = new System.Drawing.Size(75, 44);
            this.bttthem.TabIndex = 0;
            this.bttthem.Text = "Thêm";
            this.bttthem.UseVisualStyleBackColor = true;
            // 
            // bttthoat
            // 
            this.bttthoat.Location = new System.Drawing.Point(7, 232);
            this.bttthoat.Name = "bttthoat";
            this.bttthoat.Size = new System.Drawing.Size(75, 44);
            this.bttthoat.TabIndex = 0;
            this.bttthoat.Text = "Thoát";
            this.bttthoat.UseVisualStyleBackColor = true;
            // 
            // QuanLyKhoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 390);
            this.Controls.Add(this.grbkhoa);
            this.Controls.Add(this.dgvkhoa);
            this.Controls.Add(this.label1);
            this.Name = "QuanLyKhoa";
            this.Text = "        ";
            ((System.ComponentModel.ISupportInitialize)(this.dgvkhoa)).EndInit();
            this.grbkhoa.ResumeLayout(false);
            this.grbkhoa.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvkhoa;
        private System.Windows.Forms.GroupBox grbkhoa;
        private System.Windows.Forms.TextBox txttenkhoa;
        private System.Windows.Forms.TextBox txtmakhoa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bttsua;
        private System.Windows.Forms.Button bttthem;
        private System.Windows.Forms.Button bttxoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn makhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenkhoa;
        private System.Windows.Forms.Button bttthoat;
    }
}