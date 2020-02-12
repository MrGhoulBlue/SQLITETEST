using SQLite;
using SQLITETEST.Interfaces;
using SQLITETEST.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace SQLITETEST.Bds
{
    public class UserDb
    {
        private SQLiteConnection conn;
        public UserDb() {
            conn = DependencyService.Get<ISQLite>().GetConnection();
            conn.CreateTable<Users>();
            conn.CreateTable<Visitas>();
        }

        public IEnumerable<Visitas> GetMembers_visitas()
        {
            var members = (from mem in conn.Table<Visitas>() select mem);
            return members.ToList();
        }

        public string AddMember_visitas(Visitas member)
        {
            try
            {
                conn.Insert(member);
                return "success baby bluye ;*";
            }
            catch (Exception ex)
            {

                return ex.ToString();
            }

        }

        public void DeleteMember_visitas(int ID)
        {
            conn.Delete<Visitas>(ID);
        }

        public void DropTbMember_visitas()
        {
            conn.DropTable<Visitas>();
        }


        // ------------
        public IEnumerable<Users> GetMembers()
        {
            var members = (from mem in conn.Table<Users>() select mem);
            return members.ToList();
        }

        public string AddMember(Users member)
        {
            try
            {
                conn.Insert(member);
                return "success baby bluye ;*";
            }
            catch (Exception ex)
            {

                return ex.ToString();
            }

        }

        public void DeleteMember(int ID)
        {
            conn.Delete<Users>(ID);
        }

        public void DropTbMember()
        {
            conn.DropTable<Users>();
        }
    }
}
