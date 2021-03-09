using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace QuanLyDiem.Models
{
    [Table("LOPS")]
    public class LOP
    {
        [Key]
        public String Lop { get; set; }
        public int Khoi { get; set; }
        public String MaGV { get; set; }
        public int SiSo { get; set; }
    }
}