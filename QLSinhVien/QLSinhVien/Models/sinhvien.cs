using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace QLSinhVien.Models
{
    public class sinhvien
    {
        [PrimaryKey, AutoIncrement]
        public int id { get; set; }
        public string hoten { get; set; }
        public DateTime ngaysinh { get; set; }
        public string gioitinh { get; set; }
        public string sdt { get; set; }

        public float d1 { get; set; }
        public float d2 { get; set; }
        public float d3 { get; set; }
        public float d4 { get; set; }

        public float d5 { get; set; }

    }
}
