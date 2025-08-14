// See https://aka.ms/new-console-template for more information
using System.Reflection.Metadata.Ecma335;

Console.WriteLine("Hello, World!");

//Strings 
/*

String literals  define as ""
string text = "hi";
$ is interpolation  or concatination 
c# is 
*/
String firstName = "sree";
String secondName = "govindavaram.  ";
Console.WriteLine("hi" + firstName + secondName); // concatenate
Console.WriteLine($" hi {firstName} is {secondName.Trim()}"); // interpolation
//Search string 
/*
Base class libraries (BCL)
when we are searching we will get * * mense most of the likely methods on this object
Strings in .net are immutable 
*/
string friends = $" My friends are {firstName} and {secondName} ";
Console.WriteLine(friends);
friends = friends.Replace("sree", "Agastya");
Console.WriteLine(friends);
friends = friends.Replace("sree", "Agastya").ToUpper();
Console.WriteLine(friends);
// starts with 
// spaces maters 
/*

================Numbers integers, math===========


*/

int a = 18;
int b = 20;
int c = a + b;
Console.WriteLine(c);




int ba = 2100000000;
int bb = 2100000000;
//long bc = checked(ba + bb);
//Console.WriteLine(bc);

// checked() is a math function which will check and rise exception 
int bad = 2100000000;
int bbd = 2100000000;
long bcd = (long)bad + (long)bbd;
Console.WriteLine(bcd);

// precession

double i = 42.1;
float j = 32.8F;
double k = i + j;
Console.WriteLine(k);

decimal i1 = 42.1M;
decimal j1 = 32.8M;
decimal k1 = i1 + j1;
Console.WriteLine(k1);


if (k > 10)
{
    Console.WriteLine("HI");
}


if (k > 10 && j1 > 20)
{
    Console.WriteLine("HI");
}
else
{
    Console.WriteLine("Fine");
}

int counter = 0;

counter++;
Console.WriteLine(counter);

// loops 
// while (counter>5)
// {

//     Console.WriteLine(counter);
// }

for (int ik = 0; ik < 10; ik++)
{
    Console.WriteLine(ik);
}


