using System;
using System.Linq;
using CSharptoSQLProjectLibrary;
namespace LINQTWorkProject {
    

    class Program {

        void Run() {

            var conn = new Connection(@"localhost\sqlexpress", "PRS");
            conn.Open();
            Users.Connection = conn;

            

            var user = from u in Users.GetAll()
                         where u.IsReviewer
                         select u;

            foreach(var u in user) {
                Console.WriteLine($"{u} ");
            }

            conn.Close();

        }

        static void Main(string[] args) {
            var pgm = new Program();
            pgm.Run();
            
            
            
            #region Prior work
            //var users = new User[] {
            //    new User() {Name = "Adam", IsAdmin = false}, 
            //    new User() {Name = "Barb", IsAdmin = true},
            //    new User() {Name = "Chris", IsAdmin = false},
            //    new User() {Name = "Donna", IsAdmin = true},
            //    new User() {Name = "Ed", IsAdmin = false},
            //    new User() {Name = "Faith", IsAdmin = true},

            //};

            //var admins = users.Where(usr => usr.IsAdmin).OrderByDescending(usr => usr.Name);

            ////var admins = from usr in users
            ////             where usr.IsAdmin == true
            ////             orderby usr.Name descending
            ////             select usr;

            //foreach(var user in admins) {
            //    Console.WriteLine($"Name is {user.Name} is an admin.");
            //}


            //int[] ints = { 2, 4, 6, 8, 7, 5, 3, 1 };

            ////Get List in ascending order

            ////Query Executed when this variable is used
            //var ascInts = (from i in ints
            //              where i % 2 == 1 && i < 7//Get all the odd numbers "%" = mod
            //              orderby i descending //descending to sort by desc, defaults to asc
            //              select i); //"i => i"= foreach (var i in x) Give value of integer. i=> i.Firstname == "greg" Give me x such that x is this specifically
            //var avg = ascInts.Average(i => i);
            //Console.WriteLine($"Average of odds LT 7 is {avg}");
            //foreach (var i in ascInts) {
            //    Console.Write($"{i} ");
            //}
            #endregion
        }
    }
}
