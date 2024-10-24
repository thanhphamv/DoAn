namespace DoAn.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Diem")]
    public partial class Diem
    {
        [Key]
        public int MaDiem { get; set; }

        public int MaSinhVien { get; set; }

        public int MaMonHoc { get; set; }

        public double DiemQuaTrinh { get; set; }

        public double DiemThi { get; set; }

        public double DiemTrungBinhSo { get; set; }

        [Required]
        [StringLength(50)]
        public string DiemTrungBinhChu { get; set; }

        [Required]
        [StringLength(20)]
        public string HocKy { get; set; }
        public MonHoc MonHoc { get; internal set; }
        public SinhVien SinhVien { get; internal set; }
    }
}
