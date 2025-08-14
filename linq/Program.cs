// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

/*
LINQ
Language integrated query
It is used to queries data expressed in
 simple strings or ways 

 Ex: 
 
*/
List<int> scores = [95, 94, 92, 75, 86];

for (int i = 0; i < scores.Count; i++)
{

    if (scores[i] > 93)
    {
        Console.Write($"Found a score  {scores[i]}");
    }

}
/* to just check scores >93 in list and print 
we need to use for , if 
and so on to over come this and write in
 simple C# has one concept called 
 LINQ (Language integrated query)
 It is declerative programming 
 if , while loop is we are giving formula
 // Define the query
*/
// select * from books  // from , in , where , 
// select are keywords in LINQ
IEnumerable<int> scoreQuery =
from score in scores
where score > 80
select score;

foreach (var item in scoreQuery)
{
    Console.Write(item);
}

/*


list has sort capability 

same we can achieve in LINQ
*/

IEnumerable<int> scoreQuery1 =
from score in scores
where score > 80
orderby score descending
select score;

foreach (var item in scoreQuery1)
{
    Console.Write(item);
}

//We can use string interpolation

IEnumerable<String> scoreQuery2 = //Query variable
from score in scores // required
where score > 80 // otional 
orderby score descending // optional 
select $"The score is {score}"; // must end with select or group 

foreach (var item in scoreQuery1)
{
    Console.Write(item);
}

int highScoreCount = (
    from score in scores
    where score > 80
    select score
).Count();

 Console.Write(highScoreCount);

 /*
 extract some data from list 
 */

 IEnumerable<int> scoreQuery3 = //Query variable
from score in scores // required
where score > 80 // otional 
orderby score descending // optional 
select score; // must end with select or group 

List<int> myScore = scoreQuery3.ToList();

/*instead of above long query
we can optimise using lambda
here is an exaple */

var scoreQuery4 = scores.Where(score => score > 80).
OrderByDescending(score => score);