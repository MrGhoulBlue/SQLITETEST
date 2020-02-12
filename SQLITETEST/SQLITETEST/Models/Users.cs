using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace SQLITETEST.Models
{
    public class Users
    {
        [PrimaryKey]
        public int id { get; set; }
        public string email { set; get; }
        public string pass { set; get;  }
    }
}
