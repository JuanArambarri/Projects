using System;
using System.Diagnostics;
using System.Text;
using System.Threading.Channels;

namespace HelloWorld
{
 class Program
 {
  // www.dofactory.com/reference/csharp-coding-standards
  //variables created before Main will be a "Field", meaning it is usable in the whole program.
  static void Main(string[] args)
  {
   PrintStudents(); //calls Student function PrintStudents
   Dictionary<int, Employee> employees = new Dictionary<int, Employee>(); //instead of string, we save an object
   int indexKey = 0;

   employees.Add(indexKey, new Employee("John", 27, 1000));
   indexKey++;
   employees.Add(indexKey, new Employee("Martin", 35, 2500));
   indexKey++;
   employees.Add(indexKey, new Employee("Ceasar", 55, 4000));
   /*
    * Debug.WriteLine("Hi programmer!"); //writes to output in IDE, does not display to console.
    */

   int age;
   string ageString = Console.ReadLine();
   if (!int.TryParse(ageString, out age))
   {
    throw new Exception("What are you doing mate?");//program crashes but a message is displayed.
   }
   

   foreach (var item in employees)
   {
    Console.WriteLine(
     $"ID: {item.Key} named: {item.Value.Name}, {item.Value.Age} years old. Earns U$D {item.Value.Salary}");
   }

   var codes = new Dictionary<string, string>
   {
    ["NY"] = "New York", //Key has to be between squared brackets
    ["CA"] = "California",
    ["TX"] = "Texas"
   };
   //how to not crash your app when there's no value
   if (codes.TryGetValue("IN", out string state)) //we are getting the second string for Key "NY"
   {
    Console.WriteLine(state);
   }

   foreach (var item in codes)
   {
    Console.WriteLine("The state code for " + item.Value + " is " + item.Key);
   }
  }
  //Nested class
  public class Student
  {
   public int ID { get; set; }
   public string Name { get; set; }
   public int Grade { get; set; }

   public Student(int id, string name, int grade)
   {
    ID = id;
    Name = name;
    Grade = grade;
   }
  }
  static void PrintStudents()
  {
   Dictionary<string, Student> studentDictionary = new Dictionary<string, Student>();
   studentDictionary.Add("John", new Student(1, "John", 85));
   studentDictionary.Add("Alice", new Student(2, "Alice", 90));
   studentDictionary.Add("Bob", new Student(3, "Bob", 78));

   foreach (var student in studentDictionary)
   {
    Console.WriteLine("Name: " + student.Value.Name + ", Id: " + student.Value.ID + ", Grade: " + student.Value.Grade);
   }
  }
 }
}