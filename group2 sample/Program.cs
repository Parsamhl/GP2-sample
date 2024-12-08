// See https://aka.ms/new-console-template for more information
using group2_sample.Contract;
using group2_sample.Data;
using group2_sample.Entity;
using group2_sample.Service;


Authentication auth = new Authentication();

Console.WriteLine("Enter your name  :");
var name = Console.ReadLine();
Console.WriteLine("enter your Last name  :");
var lastName = Console.ReadLine();
Console.WriteLine("enter your Age");
int age = int.Parse(Console.ReadLine());
Console.WriteLine("enter a user Name :");
var userName = Console.ReadLine();
Console.WriteLine("enter a password :");
var password = Console.ReadLine();

User u = new User() { Age = age  , LastName = lastName , Name = name , Password = password , UserName = userName};

auth.Register(u);   



