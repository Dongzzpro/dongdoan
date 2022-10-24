using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyGhiDanh.Data
{
    [Table("KhoaHoc")]
    public class KhoaHoc
    {
        [Key]
        public int IdKhoaHoc { get; set; }
        public int KhoaHocName { get; set; }
    }
}
