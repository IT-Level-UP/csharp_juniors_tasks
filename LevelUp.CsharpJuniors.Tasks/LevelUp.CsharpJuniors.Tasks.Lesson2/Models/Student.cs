namespace LevelUp.CsharpJuniors.Tasks.Lesson2.Models;

public sealed class Student
{
    public string Name { get; }

    public int GroupNumber { get; set; }

    public int CourseNumber { get; set; }

    public Student(string name, int groupNumber, int courseNumber)
    {
        Name = name;
        GroupNumber = groupNumber;
        CourseNumber = courseNumber;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Name: {Name}, Group: {GroupNumber}, Cource: {CourseNumber}");
    }

    public override string ToString()
    {
        return $"Name: {Name}, Group: {GroupNumber}, Cource: {CourseNumber}";
    }
}