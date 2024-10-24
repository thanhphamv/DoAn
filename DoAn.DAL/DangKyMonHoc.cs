namespace DoAn.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DangKyMonHoc")]
    public partial class DangKyMonHoc
    {
        [Key]
        public int MaDangKy { get; set; }

        public int MaSinhVien { get; set; }

        public int MaMonHoc { get; set; }

        [Required]
        [StringLength(20)]
        public string HocKy { get; set; }

        public virtual MonHoc MonHoc { get; set; }

        public virtual SinhVien SinhVien { get; set; }
    }
}
