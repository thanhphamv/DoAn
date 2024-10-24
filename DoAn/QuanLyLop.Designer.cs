namespace DoAn
{
    partial class QuanLyLop
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
            this.grblop = new System.Windows.Forms.GroupBox();
            this.dgvlop = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txttenlop = new System.Windows.Forms.TextBox();
            this.txtmalop = new System.Windows.Forms.TextBox();
            this.cmbkhoa = new System.Windows.Forms.ComboBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.bttthem = new System.Windows.Forms.Button();
            this.bttxoa = new System.Windows.Forms.Button();
            this.bttsua = new System.Windows.Forms.Button();
            this.malop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenlop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.makhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenkhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grblop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(381, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ LỚP";
            // 
            // grblop
            // 
            this.grblop.Controls.Add(this.bttsua);
            this.grblop.Controls.Add(this.bttxoa);
            this.grblop.Controls.Add(this.bttthem);
            this.grblop.Controls.Add(this.numericUpDown1);
            this.grblop.Controls.Add(this.cmbkhoa);
            this.grblop.Controls.Add(this.txtmalop);
            this.grblop.Controls.Add(this.txttenlop);
            this.grblop.Controls.Add(this.label5);
            this.grblop.Controls.Add(this.label4);
            this.grblop.Controls.Add(this.label3);
            this.grblop.Controls.Add(this.label2);
            this.grblop.Location = new System.Drawing.Point(12, 103);
            this.grblop.Name = "grblop";
            this.grblop.Size = new System.Drawing.Size(245, 299);
            this.grblop.TabIndex = 1;
            this.grblop.TabStop = false;
            this.grblop.Text = "Thông Tin ";
            // 
            // dgvlop
            // 
            this.dgvlop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvlop.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.malop,
            this.tenlop,
            this.soluong,
            this.makhoa,
            this.tenkhoa});
            this.dgvlop.Location = new System.Drawing.Point(276, 103);
            this.dgvlop.Name = "dgvlop";
            this.dgvlop.RowHeadersWidth = 51;
            this.dgvlop.RowTemplate.Height = 24;
            this.dgvlop.Size = new System.Drawing.Size(685, 299);
            this.dgvlop.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Lớp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên Lớp";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Khoa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Số Lượng ";
            // 
            // txttenlop
            // 
            this.txttenlop.Location = new System.Drawing.Point(110, 84);
            this.txttenlop.Name = "txttenlop";
            this.txttenlop.Size = new System.Drawing.Size(121, 22);
            this.txttenlop.TabIndex = 1;
            // 
            // txtmalop
            // 
            this.txtmalop.Location = new System.Drawing.Point(110, 38);
            this.txtmalop.Name = "txtmalop";
            this.txtmalop.Size = new System.Drawing.Size(121, 22);
            this.txtmalop.TabIndex = 1;
            // 
            // cmbkhoa
            // 
            this.cmbkhoa.FormattingEnabled = true;
            this.cmbkhoa.Location = new System.Drawing.Point(110, 129);
            this.cmbkhoa.Name = "cmbkhoa";
            this.cmbkhoa.Size = new System.Drawing.Size(121, 24);
            this.cmbkhoa.TabIndex = 2;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(110, 167);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown1.TabIndex = 3;
            // 
            // bttthem
            // 
            this.bttthem.Location = new System.Drawing.Point(23, 232);
            this.bttthem.Name = "bttthem";
            this.bttthem.Size = new System.Drawing.Size(58, 41);
            this.bttthem.TabIndex = 4;
            this.bttthem.Text = "Thêm";
            this.bttthem.UseVisualStyleBackColor = true;
            // 
            // bttxoa
            // 
            this.bttxoa.Location = new System.Drawing.Point(97, 232);
            this.bttxoa.Name = "bttxoa";
            this.bttxoa.Size = new System.Drawing.Size(58, 41);
            this.bttxoa.TabIndex = 4;
            this.bttxoa.Text = "Xóa";
            this.bttxoa.UseVisualStyleBackColor = true;
            // 
            // bttsua
            // 
            this.bttsua.Location = new System.Drawing.Point(173, 232);
            this.bttsua.Name = "bttsua";
            this.bttsua.Size = new System.Drawing.Size(58, 41);
            this.bttsua.TabIndex = 4;
            this.bttsua.Text = "Sữa";
            this.bttsua.UseVisualStyleBackColor = true;
            // 
            // malop
            // 
            this.malop.HeaderText = "Mã Lớp";
            this.malop.MinimumWidth = 6;
            this.malop.Name = "malop";
            this.malop.Width = 125;
            // 
            // tenlop
            // 
            this.tenlop.HeaderText = "Tên Lớp";
            this.tenlop.MinimumWidth = 6;
            this.tenlop.Name = "tenlop";
            this.tenlop.Width = 125;
            // 
            // soluong
            // 
            this.soluong.HeaderText = "Số Lượng";
            this.soluong.MinimumWidth = 6;
            this.soluong.Name = "soluong";
            this.soluong.Width = 125;
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
            // QuanLyLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 450);
            this.Controls.Add(this.dgvlop);
            this.Controls.Add(this.grblop);
            this.Controls.Add(this.label1);
            this.Name = "QuanLyLop";
            this.Text = "QuanLyLop";
            this.grblop.ResumeLayout(false);
            this.grblop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grblop;
        private System.Windows.Forms.DataGridView dgvlop;
        private System.Windows.Forms.ComboBox cmbkhoa;
        private System.Windows.Forms.TextBox txtmalop;
        private System.Windows.Forms.TextBox txttenlop;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bttsua;
        private System.Windows.Forms.Button bttxoa;
        private System.Windows.Forms.Button bttthem;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.DataGridViewTextBoxColumn malop;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenlop;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn makhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenkhoa;
    }
}