using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyGhiDanh.Data
{
    [Table("GiaoVien")]
    public class GiaoVien
    {
        [Key]
        public int IdGiaoVien { get; set; }
        public string GiaoVienName { get; set; }
        public string DiaChiGV { get; set; }
        public string AnhDaiDienGV { get; set; }
        public int SDTGiaoVien { get; set; }
        public string NgayHopTac { get; set; }
        public string CacMonGiangDay { get; set; }
    }
}
