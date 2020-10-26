using System;

class Employee {
  private string firstname;
  private string lastname;
  private string id;
  private int age;
  private string address;
  private string phonenumber;
  private string title;
  private double yearlysalary;
  private string employeestatus;

  public Employee()
  {
   firstname = "unknown";
   lastname = "unknown";
   id = "0";
   age = 0;
   employeestatus = "active";
  }

  public Employee(string myfirstname, string mylastname, string myid, int myage)
  {
    firstname = myfirstname;
    lastname = mylastname;
    id = myid;
    age = myage;
    employeestatus = "active";
   }

  public void Intro()
  {

    Console.WriteLine("Firstname: " + firstname);
    Console.WriteLine("Lastname: " + lastname);
    Console.WriteLine("Id: " + id);
    Console.WriteLine("Age:" + age);
    Console.WriteLine("Employeestatus:" + employeestatus);
  }
}