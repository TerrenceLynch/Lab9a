using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("TheTest");
    
    Employee unknown = new Employee();
    unknown.Intro();
    Employee john = new Employee("John", "Smith", "1234", 45);
    john.Intro();

     
  }
}