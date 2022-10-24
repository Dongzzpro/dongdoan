
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyGhiDanh.Data
{
    [Table("HocVien")]
    public class HocVien
    {
        [Key]
        public int IdHocVien { get; set; }
        public string HocVienName { get; set; }
        public string DiaChiHV { get; set; }
        public string AnhDaiDienHV { get; set; }
        public int SDTPhuHuynh { get; set; }

    }
}
