namespace HouseRentManagement.QLCHCC
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PHIEUTHICONG")]
    public partial class PHIEUTHICONG
    {
        [Key]
        [StringLength(20)]
        public string SoPhieuThiCong { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayLap { get; set; }

        [StringLength(200)]
        public string NoiDung { get; set; }

        [StringLength(30)]
        public string TinhTrang { get; set; }

        public DateTime? BDThiCong { get; set; }

        public DateTime? KTThiCong { get; set; }

        [Required]
        [StringLength(20)]
        public string MaCanHo { get; set; }

        [Required]
        [StringLength(20)]
        public string MaQL { get; set; }

        public virtual BANQUANLY BANQUANLY { get; set; }

        public virtual CANHO CANHO { get; set; }
    }
}
