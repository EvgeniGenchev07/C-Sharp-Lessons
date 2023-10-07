using StartUp;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Farm
{
    public class User :DbContext
    {
        public User() : base("name=Test") { }
        public IDbSet<Users> Users { get; set; }
    }
    public class Users
    {
        public int Id { get; set; }
    }

    public class StartUp
    {

        static void Main(string[] args)
        {
            var user = new User();
            Console.WriteLine( user.Users.Count());
            Dog dog = new Dog();
            dog.Eat();
            dog.Bark();
            Cat cat = new Cat();
            cat.Eat();
            cat.Meow();
        }
    }
}
