using System.Diagnostics.CodeAnalysis;

namespace LevelUp.CsharpJuniors.Tasks.Lesson5.Linq
{
    [SuppressMessage("ReSharper", "PossibleMultipleEnumeration")]
    public sealed class LinqExamples
    {
        public void DealWithLinq()
        {
            var examples = new LinqExamples();

            examples.DealWithExtensions();
            examples.DealWithLazyCalculation();
            examples.DealWithSqlLikeNotation();
        }
        
        private void DealWithExtensions()
        {
            var students = GetStudentsList();
            var scores = GetAverageScores();

            // Select surnames
            var surnames = students.Select(st => st.Surname);

            Console.WriteLine("Surnames:");
            foreach (var surname in surnames)
            {
                Console.WriteLine($"\t{surname}");
            }

            // Order surnames alphabetically by ascending
            surnames = surnames.OrderBy(sn => sn);

            Console.WriteLine("\nOrdered by ascending surnames:");
            foreach (var surname in surnames)
            {
                Console.WriteLine($"\t{surname}");
            }

            // Order surnames alphabetically by descending
            surnames = surnames.OrderByDescending(sn => sn);

            Console.WriteLine("\nOrdered by descending surnames:");
            foreach (var surname in surnames)
            {
                Console.WriteLine($"\t{surname}");
            }

            // Select students only from 3rd course
            var thirdCourceStudents = students.Where(st => st.Cource == 3);

            Console.WriteLine("\nStudents of 3rd cource:");
            foreach (var student in thirdCourceStudents)
            {
                Console.WriteLine($"\t{student.Surname}");
            }

            // Select surnames of the students who study at ETF faculty
            var etfStudents = students
                .Where(st => st.Faculty == "ETF")
                .Select(st => st.Surname);

            Console.WriteLine("\nStudents of ETF:");
            foreach (var student in etfStudents)
            {
                Console.WriteLine($"\t{student}");
            }

            // Join students and scores info
            var studentsWithScores = students.Join(
                scores,
                st => st.Id,
                sc => sc.StudentId,
                (st, sc) => new { Student = st, sc.Score });

            Console.WriteLine("\nStudents with scores:");
            foreach (var student in studentsWithScores)
            {
                Console.WriteLine($"\tName: {student.Student.Name} {student.Student.Surname}, Score: {student.Score}");
            }

            // Get the min score student
            var minScoreStudent = studentsWithScores.OrderBy(st => st.Score).First();

            // Get the max score student
            var maxScoreStudent = studentsWithScores.OrderByDescending(st => st.Score).First();

            Console.WriteLine($"Min score is {minScoreStudent.Score}, {minScoreStudent.Student.Name} {minScoreStudent.Student.Surname}");
            Console.WriteLine($"Max score is {maxScoreStudent.Score}, {maxScoreStudent.Student.Name} {maxScoreStudent.Student.Surname}");

            // Get the average score
            var averageScore = studentsWithScores.Average(st => st.Score);
            Console.WriteLine($"Average score is {averageScore}");

            // Get the min score
            var minScore = studentsWithScores.Min(st => st.Score);
            Console.WriteLine($"Min score is {minScore}");

            // Get the max score
            var maxScore = studentsWithScores.Max(st => st.Score);
            Console.WriteLine($"Max score is {maxScore}");

            var arrayOne = new[] { 0, 1, 2, 3 };
            var arrayTwo = new[] { 2, 3, 4, 5 };

            // Intersect two collections
            var intersection = arrayOne.Intersect(arrayTwo);
            Console.WriteLine("Intersection: " + string.Join(',', intersection));

            // Get only unique elements from collection one
            var exception = arrayOne.Except(arrayTwo);
            Console.WriteLine("Exception: " + string.Join(',', exception));

            // "Pair" two collections
            var zip = arrayOne.Zip(arrayTwo);
            Console.WriteLine("Zip: " + string.Join(',', zip));

            // Concatenate two collections
            var concatenation = arrayOne.Concat(arrayTwo);
            Console.WriteLine("Concatenation: " + string.Join(',', concatenation));

            // Get the unique values
            var distinct = concatenation.Distinct();
            Console.WriteLine("Distinct: " + string.Join(',', distinct));
        }

        private void DealWithSqlLikeNotation()
        {
            var students = GetStudentsList();
            var scores = GetAverageScores();

            var studentsWithScores = from student in students
                                     join scoreInfo in scores.OrderByDescending(sc => sc.Score)
                                     on student.Id equals scoreInfo.StudentId
                                     select new { Student = student, scoreInfo.Score };

            Console.WriteLine("\nStudents with scores:");
            foreach (var student in studentsWithScores)
            {
                Console.WriteLine($"\tName: {student.Student.Name} {student.Student.Surname}, Score: {student.Score}");
            }
        }

        private void DealWithLazyCalculation()
        {
            var ints = new List<int> { 1, 2, 3, 4, 5 };
            
            var evens = ints.Where(i => i % 2 == 0);

            ints.Add(6);

            var evensSum = evens.Sum();

            Console.WriteLine(evensSum);
        }

        private IEnumerable<Student> GetStudentsList()
        {
            return new List<Student>
            {
                new() { Id = 1, Name = "Aleksandr", Surname = "Ivanov", Cource = 4, Faculty = "ETF" },
                new() { Id = 2, Name = "Vladimir", Surname = "Smetanin", Cource = 3, Faculty = "IEF" },
                new() { Id = 3, Name = "Elena", Surname = "Fedorova", Cource = 2, Faculty = "MTF" },
                new() { Id = 4, Name = "Stepan", Surname = "Botanikov", Cource = 5, Faculty = "MTF" },
                new() { Id = 5, Name = "Olga", Surname = "Karpatova", Cource = 3, Faculty = "IEF" },
                new() { Id = 6, Name = "Tatyana", Surname = "Simonyak", Cource = 1, Faculty = "ETF" },
            };
        }

        private IEnumerable<AverageScore> GetAverageScores()
        {
            return new List<AverageScore>
            {
                new() { StudentId = 1, Score = 96 },
                new() { StudentId = 2, Score = 79 },
                new() { StudentId = 3, Score = 75 },
                new() { StudentId = 4, Score = 84 },
                new() { StudentId = 5, Score = 92 },
                new() { StudentId = 6, Score = 86 },
            };
        }

        record Student
        {
            public int Id { get; init; }
            
            public string? Name { get; init; }

            public string? Surname { get; init; }

            public string? Faculty { get; init; }

            public int? Cource { get; init; }
        }

        record AverageScore
        {
            public int? StudentId { get; init; }

            public int? Score { get; init; }
        }
    }
}
