using LevelUp.CsharpJuniors.Tasks.Lesson2;

Console.WriteLine("Let's play with C#");

// 1. Sum two numbers from user input
/*
var firstNumberString = Console.ReadLine() ?? string.Empty;
var secondNumberString = Console.ReadLine() ?? string.Empty;

var firstNumber = int.Parse(firstNumberString);
var secondNumber = int.Parse(secondNumberString);

var thirdNumberString = Console.ReadLine() ?? string.Empty;
if (int.TryParse(thirdNumberString, out var thirdNumber))
{
    Console.WriteLine(thirdNumber);
}

Console.WriteLine(firstNumber + secondNumber);

// 2. Print string from input
var str1 = Console.ReadLine();
var str2 = Console.ReadLine();
Console.WriteLine(str1 + str2);

// 3. Concatenate strings
Console.WriteLine("Hello, " + "C#");
Console.WriteLine(string.Format("Current date/time is {0}", DateTime.Now));

// 4. Print interpolated string
var weather = "+15 degrees";
Console.WriteLine($"Current dt: {DateTime.Now}, weather is {weather}");

// 5. Print interpolated string with input

// 6. Print current date and time
Console.WriteLine(DateTime.Now);

// 7. Create a class Student
var name = "Ivan Petrov";
var groupNumber = 101;
var courseNumber = 1;

var student = new Student(name, groupNumber, courseNumber);

// 8. Print student's info
Console.WriteLine($"Name: {student.Name}, Group: {student.GroupNumber}, Cource: {student.CourseNumber}");
student.PrintInfo();
Console.WriteLine(student);
*/

// 9. Create a record Engineer

// 10. Modify record Engineer

// 11. Let's practice
// Create a class Store with properties Name and Address.
// These properties should be set by constructor.
// Create a method PrintInfo to print store's name and address in one row.
// Create Store class instance. Use Console to fill Name and Address.
// Call PrintInfo method to print store's card.

// 12. Try Garbage Collector
// var gcTest = new GarbageCollector();
// gcTest.TryCollect();

// new Strings().PlayWithStrings();
// new Exceptions().PlayWithExceptions(100, 0);

new Debugging().PlayWithDebugging();