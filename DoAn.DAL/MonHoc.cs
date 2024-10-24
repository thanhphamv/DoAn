namespace DoAn.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MonHoc")]
    public partial class MonHoc
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MonHoc()
        {
            DangKyMonHocs = new HashSet<DangKyMonHoc>();
            Diems = new HashSet<Diem>();
        }

        [Key]
        public int MaMonHoc { get; set; }

        [Required]
        [StringLength(100)]
        public string TenMonHoc { get; set; }

        public byte SoTC { get; set; }

        public byte TietLT { get; set; }

        public byte TietTH { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DangKyMonHoc> DangKyMonHocs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Diem> Diems { get; set; }
    }
}
