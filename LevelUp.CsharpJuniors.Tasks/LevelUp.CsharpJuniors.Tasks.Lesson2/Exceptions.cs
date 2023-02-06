using System;
namespace LevelUp.CsharpJuniors.Tasks.Lesson2
{
	public class Exceptions
	{
		public void PlayWithExceptions(int distance, int time)
		{
			var speed = 0;
			bool tryToCatchDivideByZero = true;
			try
			{
				speed = distance / time;
				Console.WriteLine(speed);
			}
			catch(NullReferenceException)
			{
				Console.WriteLine("NRE!");
			}
			catch(DivideByZeroException ex) when (tryToCatchDivideByZero)
			{
				Console.WriteLine($"{ex.StackTrace}, {ex.Message}");
			}
			catch(ExampleException eex) when (eex.ExceptionDateTime <= DateTime.Now)
            {

            }
			finally
            {
				Console.WriteLine("Finally has been called");
            }
		}

		public class ExampleException : Exception
		{
			public DateTime ExceptionDateTime { get; }

			public ExampleException(string message) : base(message)
			{
				ExceptionDateTime = DateTime.Now;
			}
		}
	}
}

