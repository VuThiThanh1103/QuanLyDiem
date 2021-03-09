using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace QuanLyDiem.Models
{
    [Table("HOSSINHS")]
    public class HOCSINH
    {
        [Key]
        public int MaHS { get; set; }
        public String TenHS { get; set; }
        public int NamSinh { get; set; }
        public String Lop { get; set; }

    }
}