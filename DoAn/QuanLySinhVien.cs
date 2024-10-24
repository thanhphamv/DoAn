using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn
{
    public partial class QuanLySinhVien : Form
    {
        public QuanLySinhVien()
        {
            InitializeComponent();
            
        }

        private void quảnLýKhoaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            QuanLyKhoa quanlykhoa = new QuanLyKhoa();   
            quanlykhoa.ShowDialog();
              
        }

        private void quảnLýLớpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            QuanLyLop quanLyLop = new QuanLyLop();  
            quanLyLop.ShowDialog();  
        }

        private void quảnLýĐăngKýMônHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyDangKyMonHoc quanlydangkymonhoc  = new QuanLyDangKyMonHoc();
            quanlydangkymonhoc.ShowDialog();    
        }

        private void quảnLýMônHọcToolStripMenuItem1_Click(object sender, EventArgs e)
        {   QuanLyMonHoc quanLyMonHoc = new QuanLyMonHoc(); 
            quanLyMonHoc.ShowDialog();

        }

        private void quảnLýĐiểmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyDiem quanLyDiem   = new QuanLyDiem(); 
            quanLyDiem.ShowDialog();    
        }

        

        private void QuanLySinhVien_Load(object sender, EventArgs e)
        {

        }
    }
}
