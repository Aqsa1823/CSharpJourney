/*//VAriables or data types
using System.Runtime.Serialization.Formatters;

int agr = 12;
string name = "abc";
//char FirstName = 'Aqsa';
double  height = 6.2;
var city = "KArachi";
System.Console.WriteLine($"{name}, {agr}, {city}, {height}");
//Conditions & Loops

int marks = 60;
if (marks >= 80) System.Console.WriteLine("Pass");
else if (marks <= 40) System.Console.WriteLine("Fail");
else System.Console.WriteLine("Promoted");

int i = 5;
for (; i==5 ; i++) {Console.WriteLine(i);}
//Foreacbh loop 
string [] fruits = {"apple" , "Banana" , "Orange"};
foreach (var f in fruits) System.Console.WriteLine(f);
int[] arr = {1,2,3,4,5};
 int j=0;
while ( j < 4)
{
    System.Console.WriteLine(fruits[j]);
    j++;
}
// Methods

using System.Numerics;
using System.Runtime;

static void Student(string name, int age)
{
System.Console.WriteLine($"{name} , {age}");    
}
Student ("Ashar",4);

static void Student1(string name, int age)=> System.Console.WriteLine($"Name: {name},Age: {age}");

Student1("HAdi" , 14);

static int Sum(int Num1, int Num2)
{
    int total =  Num1 + Num2;
    return total;
}

System.Console.WriteLine(Sum(33,88));

List<int> marks = new List<int> { 78, 85, 92, 67, 55 };

Console.WriteLine("Marks: " + string.Join(", ", marks));

int total = 0;
double avg = 0;
foreach (int mark in marks)
{
    total += mark;
}
System.Console.WriteLine("Total:" + total);
int ValuesCount = marks.Count;
 avg = (double)(total) /ValuesCount;
System.Console.WriteLine("Average:" + avg);
System.Console.WriteLine("Grade:" + GetGrade((double) avg));

static string GetGrade(double marks)
{
    if (marks >= 90) return "A+";
     if (marks >= 80) return "A";
      if (marks >= 70) return "B";
      else return "F"; 
}*/
       Console.Write("Enter a number: ");
int ValueA = int.Parse (Console.ReadLine());
       Console.Write("Enter a number: ");
int ValueB = int.Parse (Console.ReadLine());
string[]  operations = ["+", "-" , "*", "/"];
Console.Write("Operation to be performed: +, -,*,/ ");
string operation = (Console.ReadLine());

// Program.cs
var calc = new Calculator();
Console.WriteLine(calc.Add(ValueA, ValueB));

