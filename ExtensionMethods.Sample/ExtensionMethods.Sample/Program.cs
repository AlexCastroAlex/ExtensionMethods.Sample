// See https://aka.ms/new-console-template for more information

using ExtensionMethods.Sample;

//int extension
var i = 10;
var result = i.IsGreaterThan(100);

Console.WriteLine(result);
//person class extension
var person = new Person { Age = 30, FirstName = "John", LastName = "Doe" };
Console.WriteLine(person.SayMyName());

//record extension 
var personrecord = new PersonRecord("John", "Doe", 30);  
Console.WriteLine(personrecord.SayMyName());

