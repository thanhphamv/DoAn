    
namespace DoAn
{
    partial class QuanLySinhVien

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
            this.dgvsinhvien = new System.Windows.Forms.DataGridView();
            this.masv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tensv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaysinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quequan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaynhaphoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.malop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.makhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbbkhoa = new System.Windows.Forms.ComboBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btn_last = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_New = new System.Windows.Forms.Button();
            this.btn_first = new System.Windows.Forms.Button();
            this.bttxoa = new System.Windows.Forms.Button();
            this.btn_prev = new System.Windows.Forms.Button();
            this.Label6 = new System.Windows.Forms.Label();
            this.txtmssv = new System.Windows.Forms.TextBox();
            this.rdio_female = new System.Windows.Forms.RadioButton();
            this.txtten = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.rdio_male = new System.Windows.Forms.RadioButton();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.bttsua = new System.Windows.Forms.Button();
            this.txtPhoto = new System.Windows.Forms.TextBox();
            this.btnDisable = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.dateTimengaysinh = new System.Windows.Forms.DateTimePicker();
            this.dateTimengaynhaphoc = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quảnLýChungToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýKhoaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýLớpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýĐăngKýMônHọcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýMônHọcToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýĐiểmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grbsinhvien = new System.Windows.Forms.GroupBox();
            this.txtquequan = new System.Windows.Forms.TextBox();
            this.txtlop = new System.Windows.Forms.TextBox();
            this.bttthem = new System.Windows.Forms.Button();
            this.bttim = new System.Windows.Forms.Button();
            this.txttimsv = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsinhvien)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.grbsinhvien.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvsinhvien
            // 
            this.dgvsinhvien.AllowUserToAddRows = false;
            this.dgvsinhvien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvsinhvien.ColumnHeadersHeight = 29;
            this.dgvsinhvien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.masv,
            this.tensv,
            this.ngaysinh,
            this.gioitinh,
            this.quequan,
            this.ngaynhaphoc,
            this.malop,
            this.makhoa});
            this.dgvsinhvien.Location = new System.Drawing.Point(251, 64);
            this.dgvsinhvien.Name = "dgvsinhvien";
            this.dgvsinhvien.RowHeadersVisible = false;
            this.dgvsinhvien.RowHeadersWidth = 51;
            this.dgvsinhvien.Size = new System.Drawing.Size(865, 368);
            this.dgvsinhvien.TabIndex = 0;
            // 
            // masv
            // 
            this.masv.HeaderText = "Mã SV";
            this.masv.MinimumWidth = 6;
            this.masv.Name = "masv";
            this.masv.Width = 76;
            // 
            // tensv
            // 
            this.tensv.HeaderText = "Tên sinh viên";
            this.tensv.MinimumWidth = 6;
            this.tensv.Name = "tensv";
            this.tensv.Width = 115;
            // 
            // ngaysinh
            // 
            this.ngaysinh.HeaderText = "Ngày sinh";
            this.ngaysinh.MinimumWidth = 6;
            this.ngaysinh.Name = "ngaysinh";
            this.ngaysinh.Width = 96;
            // 
            // gioitinh
            // 
            this.gioitinh.HeaderText = "Giới tính";
            this.gioitinh.MinimumWidth = 6;
            this.gioitinh.Name = "gioitinh";
            this.gioitinh.Width = 83;
            // 
            // quequan
            // 
            this.quequan.HeaderText = "Quê quán";
            this.quequan.MinimumWidth = 6;
            this.quequan.Name = "quequan";
            this.quequan.Width = 94;
            // 
            // ngaynhaphoc
            // 
            this.ngaynhaphoc.HeaderText = "Ngày nhập học";
            this.ngaynhaphoc.MinimumWidth = 6;
            this.ngaynhaphoc.Name = "ngaynhaphoc";
            this.ngaynhaphoc.Width = 127;
            // 
            // malop
            // 
            this.malop.HeaderText = "Mã lớp";
            this.malop.MinimumWidth = 6;
            this.malop.Name = "malop";
            this.malop.Width = 77;
            // 
            // makhoa
            // 
            this.makhoa.HeaderText = "Mã khoa";
            this.makhoa.MinimumWidth = 6;
            this.makhoa.Name = "makhoa";
            this.makhoa.Width = 88;
            // 
            // cbbkhoa
            // 
            this.cbbkhoa.Items.AddRange(new object[] {
            "Thể chất",
            "QTKD",
            "CNTT",
            "Luật"});
            this.cbbkhoa.Location = new System.Drawing.Point(89, 324);
            this.cbbkhoa.Name = "cbbkhoa";
            this.cbbkhoa.Size = new System.Drawing.Size(140, 24);
            this.cbbkhoa.TabIndex = 2;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(0, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 0;
            // 
            // btn_last
            // 
            this.btn_last.Location = new System.Drawing.Point(0, 0);
            this.btn_last.Name = "btn_last";
            this.btn_last.Size = new System.Drawing.Size(75, 23);
            this.btn_last.TabIndex = 0;
            // 
            // btn_next
            // 
            this.btn_next.Location = new System.Drawing.Point(0, 0);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(75, 23);
            this.btn_next.TabIndex = 0;
            // 
            // btn_New
            // 
            this.btn_New.Location = new System.Drawing.Point(0, 0);
            this.btn_New.Name = "btn_New";
            this.btn_New.Size = new System.Drawing.Size(75, 23);
            this.btn_New.TabIndex = 0;
            // 
            // btn_first
            // 
            this.btn_first.Location = new System.Drawing.Point(0, 0);
            this.btn_first.Name = "btn_first";
            this.btn_first.Size = new System.Drawing.Size(75, 23);
            this.btn_first.TabIndex = 0;
            // 
            // bttxoa
            // 
            this.bttxoa.Location = new System.Drawing.Point(99, 447);
            this.bttxoa.Name = "bttxoa";
            this.bttxoa.Size = new System.Drawing.Size(75, 23);
            this.bttxoa.TabIndex = 12;
            this.bttxoa.Text = "Xóa";
            // 
            // btn_prev
            // 
            this.btn_prev.Location = new System.Drawing.Point(0, 0);
            this.btn_prev.Name = "btn_prev";
            this.btn_prev.Size = new System.Drawing.Size(75, 23);
            this.btn_prev.TabIndex = 0;
            // 
            // Label6
            // 
            this.Label6.Location = new System.Drawing.Point(0, 0);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(100, 23);
            this.Label6.TabIndex = 0;
            // 
            // txtmssv
            // 
            this.txtmssv.Location = new System.Drawing.Point(89, 21);
            this.txtmssv.Name = "txtmssv";
            this.txtmssv.Size = new System.Drawing.Size(140, 22);
            this.txtmssv.TabIndex = 4;
            // 
            // rdio_female
            // 
            this.rdio_female.Location = new System.Drawing.Point(160, 151);
            this.rdio_female.Name = "rdio_female";
            this.rdio_female.Size = new System.Drawing.Size(53, 24);
            this.rdio_female.TabIndex = 9;
            this.rdio_female.Text = "Nữ";
            // 
            // txtten
            // 
            this.txtten.Location = new System.Drawing.Point(89, 53);
            this.txtten.Name = "txtten";
            this.txtten.Size = new System.Drawing.Size(140, 22);
            this.txtten.TabIndex = 5;
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(0, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(100, 23);
            this.Label1.TabIndex = 0;
            // 
            // Label2
            // 
            this.Label2.Location = new System.Drawing.Point(0, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(100, 23);
            this.Label2.TabIndex = 0;
            // 
            // Label3
            // 
            this.Label3.Location = new System.Drawing.Point(0, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(100, 23);
            this.Label3.TabIndex = 0;
            // 
            // rdio_male
            // 
            this.rdio_male.Location = new System.Drawing.Point(85, 151);
            this.rdio_male.Name = "rdio_male";
            this.rdio_male.Size = new System.Drawing.Size(64, 24);
            this.rdio_male.TabIndex = 8;
            this.rdio_male.Text = "Nam";
            // 
            // Label4
            // 
            this.Label4.Location = new System.Drawing.Point(0, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(100, 23);
            this.Label4.TabIndex = 0;
            // 
            // Label5
            // 
            this.Label5.Location = new System.Drawing.Point(0, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(100, 23);
            this.Label5.TabIndex = 0;
            // 
            // Label9
            // 
            this.Label9.Location = new System.Drawing.Point(0, 0);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(100, 23);
            this.Label9.TabIndex = 0;
            // 
            // bttsua
            // 
            this.bttsua.Location = new System.Drawing.Point(201, 447);
            this.bttsua.Name = "bttsua";
            this.bttsua.Size = new System.Drawing.Size(75, 23);
            this.bttsua.TabIndex = 13;
            this.bttsua.Text = "Sửa";
            // 
            // txtPhoto
            // 
            this.txtPhoto.Location = new System.Drawing.Point(0, 0);
            this.txtPhoto.Name = "txtPhoto";
            this.txtPhoto.Size = new System.Drawing.Size(100, 22);
            this.txtPhoto.TabIndex = 0;
            // 
            // btnDisable
            // 
            this.btnDisable.Location = new System.Drawing.Point(0, 0);
            this.btnDisable.Name = "btnDisable";
            this.btnDisable.Size = new System.Drawing.Size(75, 23);
            this.btnDisable.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Quê quán";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 332);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "Khoa";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 282);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 16);
            this.label10.TabIndex = 14;
            this.label10.Text = "Mã lớp";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 16);
            this.label11.TabIndex = 14;
            this.label11.Text = "MSSV";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 56);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 16);
            this.label12.TabIndex = 14;
            this.label12.Text = "Họ Tên SV";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 93);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 16);
            this.label13.TabIndex = 14;
            this.label13.Text = "Ngày Sinh";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(8, 219);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(101, 16);
            this.label15.TabIndex = 14;
            this.label15.Text = "Ngày nhập Học";
            // 
            // dateTimengaysinh
            // 
            this.dateTimengaysinh.Location = new System.Drawing.Point(54, 112);
            this.dateTimengaysinh.Name = "dateTimengaysinh";
            this.dateTimengaysinh.Size = new System.Drawing.Size(175, 22);
            this.dateTimengaysinh.TabIndex = 15;
            // 
            // dateTimengaynhaphoc
            // 
            this.dateTimengaynhaphoc.Location = new System.Drawing.Point(54, 238);
            this.dateTimengaynhaphoc.Name = "dateTimengaynhaphoc";
            this.dateTimengaynhaphoc.Size = new System.Drawing.Size(181, 22);
            this.dateTimengaynhaphoc.TabIndex = 15;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(8, 155);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(60, 16);
            this.label14.TabIndex = 14;
            this.label14.Text = "Giới Tính";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýChungToolStripMenuItem,
            this.quảnLýKhoaToolStripMenuItem1,
            this.quảnLýLớpToolStripMenuItem1,
            this.quảnLýĐăngKýMônHọcToolStripMenuItem,
            this.quảnLýMônHọcToolStripMenuItem1,
            this.quảnLýĐiểmToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1157, 28);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quảnLýChungToolStripMenuItem
            // 
            this.quảnLýChungToolStripMenuItem.Name = "quảnLýChungToolStripMenuItem";
            this.quảnLýChungToolStripMenuItem.Size = new System.Drawing.Size(117, 24);
            this.quảnLýChungToolStripMenuItem.Text = "Quản lý chung";
            // 
            // quảnLýKhoaToolStripMenuItem1
            // 
            this.quảnLýKhoaToolStripMenuItem1.Name = "quảnLýKhoaToolStripMenuItem1";
            this.quảnLýKhoaToolStripMenuItem1.Size = new System.Drawing.Size(109, 24);
            this.quảnLýKhoaToolStripMenuItem1.Text = "Quản lý khoa";
            this.quảnLýKhoaToolStripMenuItem1.Click += new System.EventHandler(this.quảnLýKhoaToolStripMenuItem1_Click);
            // 
            // quảnLýLớpToolStripMenuItem1
            // 
            this.quảnLýLớpToolStripMenuItem1.Name = "quảnLýLớpToolStripMenuItem1";
            this.quảnLýLớpToolStripMenuItem1.Size = new System.Drawing.Size(99, 24);
            this.quảnLýLớpToolStripMenuItem1.Text = "Quản lý lớp";
            this.quảnLýLớpToolStripMenuItem1.Click += new System.EventHandler(this.quảnLýLớpToolStripMenuItem1_Click);
            // 
            // quảnLýĐăngKýMônHọcToolStripMenuItem
            // 
            this.quảnLýĐăngKýMônHọcToolStripMenuItem.Name = "quảnLýĐăngKýMônHọcToolStripMenuItem";
            this.quảnLýĐăngKýMônHọcToolStripMenuItem.Size = new System.Drawing.Size(191, 24);
            this.quảnLýĐăngKýMônHọcToolStripMenuItem.Text = "Quản lý đăng ký môn học";
            this.quảnLýĐăngKýMônHọcToolStripMenuItem.Click += new System.EventHandler(this.quảnLýĐăngKýMônHọcToolStripMenuItem_Click);
            // 
            // quảnLýMônHọcToolStripMenuItem1
            // 
            this.quảnLýMônHọcToolStripMenuItem1.Name = "quảnLýMônHọcToolStripMenuItem1";
            this.quảnLýMônHọcToolStripMenuItem1.Size = new System.Drawing.Size(135, 24);
            this.quảnLýMônHọcToolStripMenuItem1.Text = "Quản lý môn học";
            this.quảnLýMônHọcToolStripMenuItem1.Click += new System.EventHandler(this.quảnLýMônHọcToolStripMenuItem1_Click);
            // 
            // quảnLýĐiểmToolStripMenuItem
            // 
            this.quảnLýĐiểmToolStripMenuItem.Name = "quảnLýĐiểmToolStripMenuItem";
            this.quảnLýĐiểmToolStripMenuItem.Size = new System.Drawing.Size(111, 24);
            this.quảnLýĐiểmToolStripMenuItem.Text = "Quản lý điểm";
            this.quảnLýĐiểmToolStripMenuItem.Click += new System.EventHandler(this.quảnLýĐiểmToolStripMenuItem_Click);
            // 
            // grbsinhvien
            // 
            this.grbsinhvien.Controls.Add(this.dateTimengaynhaphoc);
            this.grbsinhvien.Controls.Add(this.cbbkhoa);
            this.grbsinhvien.Controls.Add(this.txtquequan);
            this.grbsinhvien.Controls.Add(this.label15);
            this.grbsinhvien.Controls.Add(this.dateTimengaysinh);
            this.grbsinhvien.Controls.Add(this.label14);
            this.grbsinhvien.Controls.Add(this.label10);
            this.grbsinhvien.Controls.Add(this.rdio_female);
            this.grbsinhvien.Controls.Add(this.rdio_male);
            this.grbsinhvien.Controls.Add(this.label13);
            this.grbsinhvien.Controls.Add(this.label8);
            this.grbsinhvien.Controls.Add(this.label11);
            this.grbsinhvien.Controls.Add(this.label7);
            this.grbsinhvien.Controls.Add(this.label12);
            this.grbsinhvien.Controls.Add(this.txtten);
            this.grbsinhvien.Controls.Add(this.txtlop);
            this.grbsinhvien.Controls.Add(this.txtmssv);
            this.grbsinhvien.Location = new System.Drawing.Point(10, 64);
            this.grbsinhvien.Name = "grbsinhvien";
            this.grbsinhvien.Size = new System.Drawing.Size(235, 368);
            this.grbsinhvien.TabIndex = 17;
            this.grbsinhvien.TabStop = false;
            this.grbsinhvien.Text = "Thông Tin";
            // 
            // txtquequan
            // 
            this.txtquequan.Location = new System.Drawing.Point(89, 183);
            this.txtquequan.Name = "txtquequan";
            this.txtquequan.Size = new System.Drawing.Size(140, 22);
            this.txtquequan.TabIndex = 16;
            // 
            // txtlop
            // 
            this.txtlop.Location = new System.Drawing.Point(89, 276);
            this.txtlop.Name = "txtlop";
            this.txtlop.Size = new System.Drawing.Size(140, 22);
            this.txtlop.TabIndex = 4;
            // 
            // bttthem
            // 
            this.bttthem.Location = new System.Drawing.Point(10, 447);
            this.bttthem.Name = "bttthem";
            this.bttthem.Size = new System.Drawing.Size(79, 23);
            this.bttthem.TabIndex = 18;
            this.bttthem.Text = "Thêm";
            this.bttthem.UseVisualStyleBackColor = true;
            // 
            // bttim
            // 
            this.bttim.Location = new System.Drawing.Point(309, 447);
            this.bttim.Name = "bttim";
            this.bttim.Size = new System.Drawing.Size(75, 23);
            this.bttim.TabIndex = 19;
            this.bttim.Text = "Tìm";
            this.bttim.UseVisualStyleBackColor = true;
            // 
            // txttimsv
            // 
            this.txttimsv.Location = new System.Drawing.Point(410, 448);
            this.txttimsv.Name = "txttimsv";
            this.txttimsv.Size = new System.Drawing.Size(137, 22);
            this.txttimsv.TabIndex = 21;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label16.ForeColor = System.Drawing.Color.Red;
            this.label16.Location = new System.Drawing.Point(496, 32);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(258, 29);
            this.label16.TabIndex = 22;
            this.label16.Text = "QUẢN LÝ SINH VIÊN";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(587, 446);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // QuanLySinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 480);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txttimsv);
            this.Controls.Add(this.bttim);
            this.Controls.Add(this.bttthem);
            this.Controls.Add(this.dgvsinhvien);
            this.Controls.Add(this.bttxoa);
            this.Controls.Add(this.bttsua);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.grbsinhvien);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "QuanLySinhVien";
            this.Text = "QuanLySinhVien";
            this.Load += new System.EventHandler(this.QuanLySinhVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvsinhvien)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grbsinhvien.ResumeLayout(false);
            this.grbsinhvien.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.ComboBox cbbkhoa;
        internal System.Windows.Forms.Button btnClose;
        internal System.Windows.Forms.Button btn_last;
        internal System.Windows.Forms.Button btn_next;
        internal System.Windows.Forms.Button btn_New;
        internal System.Windows.Forms.Button btn_first;
        internal System.Windows.Forms.Button bttxoa;
        internal System.Windows.Forms.Button btn_prev;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.DataGridView dgvsinhvien;
        internal System.Windows.Forms.TextBox txtmssv;
        internal System.Windows.Forms.RadioButton rdio_female;
        internal System.Windows.Forms.TextBox txtten;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.RadioButton rdio_male;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.Button bttsua;
        internal System.Windows.Forms.TextBox txtPhoto;
        internal System.Windows.Forms.Button btnDisable;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker dateTimengaysinh;
        private System.Windows.Forms.DateTimePicker dateTimengaynhaphoc;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quảnLýChungToolStripMenuItem;
        private System.Windows.Forms.GroupBox grbsinhvien;
        private System.Windows.Forms.TextBox txtquequan;
        internal System.Windows.Forms.TextBox txtlop;
        private System.Windows.Forms.DataGridViewTextBoxColumn masv;
        private System.Windows.Forms.DataGridViewTextBoxColumn tensv;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaysinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn quequan;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaynhaphoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn malop;
        private System.Windows.Forms.DataGridViewTextBoxColumn makhoa;
        private System.Windows.Forms.Button bttthem;
        private System.Windows.Forms.Button bttim;
        private System.Windows.Forms.TextBox txttimsv;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem quảnLýKhoaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem quảnLýLớpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem quảnLýĐăngKýMônHọcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýMônHọcToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem quảnLýĐiểmToolStripMenuItem;
    }
}