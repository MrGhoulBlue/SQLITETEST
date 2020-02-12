using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace SQLITETEST.Interfaces
{
    public interface ISQLite
    {
        SQLite.SQLiteConnection GetConnection();
    }
}
