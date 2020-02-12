using SQLite;
using SQLITETEST.Bds;
using SQLITETEST.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SQLITETEST
{
 
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public Users user;
        public UserDb userDb;
 
        //public SQLiteConnection conn;
        public MainPage()
        {
            InitializeComponent();
            userDb = new UserDb();
            var users = userDb.GetMembers();
            userView.ItemsSource = users;

           
            var visits = userDb.GetMembers_visitas();
            visitsView.ItemsSource = visits;  

        }
        /*
        public async Task btnAddUser_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(email_.Text))
            {
                await DisplayAlert("Error","Ingrese un mail","ok");
                email_.Focus();
            }
            if (string.IsNullOrEmpty(pass_.Text))
            {
                await DisplayAlert("Error", "Ingrese una password", "ok");
                pass_.Focus();
            }
            else {

                try
                {
                    user = new Users();
                    user.email = email_.Text;
                    user.pass = pass_.Text;
                    Random rnd = new Random();
                    user.id = rnd.Next(20); 
                    userDb.AddMember(user);
                    var usersX = userDb.GetMembers();
                    userView.ItemsSource = usersX;

                }
                catch (Exception ex)
                {

                    await DisplayAlert("Error", "Error : "+ex.ToString(), "ok");
                }                                  
            }
        }*/

        private async void btnAddUser_Clicked_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(email_.Text))
            {
                await DisplayAlert("Error", "Ingrese un mail", "ok");
                email_.Focus();
            }
            if (string.IsNullOrEmpty(pass_.Text))

            {
                await DisplayAlert("Error", "Ingrese una password", "ok");
                pass_.Focus();
            }
            else
            {

                try
                {
                    user = new Users();
                    user.email = email_.Text;
                    user.pass = pass_.Text;
                    Random rnd = new Random();
                    user.id = rnd.Next(20);
                    userDb.AddMember(user);
                    var users = userDb.GetMembers();
                    userView.ItemsSource = users;

                }
                catch (Exception ex)
                {

                    await DisplayAlert("Error", "Error : " + ex.ToString(), "ok");
                }
            }
        }
        public Visitas v;
         private async  void btnAddVisit_Clicked(object sender, EventArgs e)
        {


            if (string.IsNullOrEmpty(data1_.Text))
            {
                await DisplayAlert("Error", "Ingrese un mail", "ok");
                data1_.Focus();
            }
            if (string.IsNullOrEmpty(data2_.Text))

            {
                await DisplayAlert("Error", "Ingrese una password", "ok");
                data2_.Focus();
            }
            else
            {
                try
                {
                    v = new Visitas();
                    v.dato1 = data1_.Text;
                    v.dato2 = data2_.Text;
                    v.dato3 = data2_.Text;
                    Random rnd = new Random();
                    v.id = rnd.Next(20);
                    userDb.AddMember_visitas(v);
                    var vis = userDb.GetMembers_visitas();
                    visitsView.ItemsSource = vis;

                }
                catch (Exception ex)
                {
                    Console.WriteLine("ERROR!!____________---------------------" + ex.ToString());
                    await DisplayAlert("Error", "Error : " + ex.ToString(), "ok");
                }
            }
        }
    }
}
