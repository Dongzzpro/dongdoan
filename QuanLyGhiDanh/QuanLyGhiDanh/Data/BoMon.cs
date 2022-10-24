using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyGhiDanh.Data
{
    [Table("BoMon")]
    public class BoMon
    {
        [Key]
        public int IdBoMon { get; set; }
        public String BoMonName { get; set; }
    }
}


