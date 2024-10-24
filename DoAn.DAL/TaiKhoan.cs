namespace DoAn.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TaiKhoan")]
    public partial class TaiKhoan
    {
        [Key]
        public int MaDangNhap { get; set; }

        [Required]
        [StringLength(50)]
        public string TenDangNhap { get; set; }

        [Required]
        [StringLength(255)]
        public string MatKhau { get; set; }

        [Required]
        [StringLength(50)]
        public string LoaiTaiKhoan { get; set; }

        public int? MaSinhVien { get; set; }

        public int? MaGiangVien { get; set; }

        public virtual GiangVien GiangVien { get; set; }

        public virtual SinhVien SinhVien { get; set; }
    }
}
