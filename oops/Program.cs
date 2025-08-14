// using System;

// namespace MyNameSpace // it is like components 
// {
//     public class MyApp // name of class
//     {

//         public static void Main() // entry point
//         {
//             Console.WriteLine("Hello");
//             var p = new Person("","",new DateOnly(1970,1,11))
//             { 

//             };
//         }
//     }
// }

/*
C# is oops 

How to think in oops 


*/
var p1 = new Person("srikanth", "govindavaram", new DateOnly(1986, 12, 1));
var p2 = new Person("sree", "govindavaram", new DateOnly(1990, 12, 1));

List<Person> people = [p1, p2];

Console.WriteLine(people.Count);
public class Person(String firstName, string lastName, DateOnly dateOfBirth)
{

    public string first { get; set; } = firstName;
    public string last { get; set; } = lastName;
    public DateOnly dateOfBirth { get; set; } = dateOfBirth;
}



public class Cat(String firstname) { }