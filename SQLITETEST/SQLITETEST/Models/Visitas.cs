using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace SQLITETEST.Models
{
    public class Visitas
    {
        [PrimaryKey]
        public int id { get; set; }
        public string dato1 { set; get; }
        public string dato2 { set; get; }
        public string dato3 { set; get; }
    }
}
