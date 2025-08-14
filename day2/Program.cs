// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

/*
List 

List<T>

Cup<T>

what is var it is local variable type 
var a= 3;
var know the type based on right side value
we can declear list as List<Type> {}

List<String> a =new  List<String> {"a","b"}

var a = new List<String> {"a","b"}
*/
var names = new List<String> { "a", "b","c","d","e","f" };
 foreach (var item in names)
{
    Console.WriteLine(item.Length);
}

names.Add("sree");

Console.WriteLine(names[0]);
/*
^ it is an operator which will
 take last item from list and print it 
Ex: names[names.count-1]
instead of this names[^1] // 
*/
Console.WriteLine(names[^1]);

// range operator  name[2..3]

//[] will not change 
// to add items to array

names = [.. names, "s"];

/*


*/

names.Sort();

//Language integrated Query 