// See https://aka.ms/new-console-template for more information
using EntityFrameworkDemo.Context;
using EntityFrameworkDemo.Models;

Console.WriteLine("Hello, World!");

User user = new User("patate@pat.te", "papapapapatatatatatetetete");

using(myDbContext myContext = new myDbContext())
{
    myContext.Users.Add(user);
    myContext.SaveChanges();
}

Console.WriteLine("Done.");


