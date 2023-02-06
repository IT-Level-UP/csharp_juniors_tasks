using System;
using static System.Formats.Asn1.AsnWriter;
using System.ComponentModel;
using System.Numerics;
using System.Runtime.ConstrainedExecution;
using System.Text;
namespace LevelUp.CsharpJuniors.Tasks.Lesson2
{
    // ... are objects
    // ... store char arrays inside
    // ... can be interned(deduplicated by CLR)
    // ... can be formatted
    // ... can be interpolated
    // Core aspects... are very complex thing(encoding, equality, regional aspects etc.)
    public class Strings
	{
		public void PlayWithStrings()
        {
            var str1 = "str1";
            var str2 = str1;
            Console.WriteLine(object.ReferenceEquals(str1, str2));

            str2 += "123";
            Console.WriteLine(object.ReferenceEquals(str1, str2));

            Console.WriteLine(string.Intern(str1));
            Console.WriteLine(string.IsInterned(str1));

            var charArrayString = "One more test string";
            foreach(var ch in charArrayString)
            {
                Console.WriteLine(ch);
            }

            var now = DateTime.Now.ToString("f");
            Console.WriteLine(now);

            var interpolated = $"Now: {12}";
        }
	}
}

