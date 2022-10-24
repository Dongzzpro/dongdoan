using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyGhiDanh.Data
{
    [Table("NhomBoMon")]
    public class NhomBoMon
    {
        [Key]
        public int IdNhomBoMon { get; set; }
        public string NhomBoMonName { get; set; }
    }
}