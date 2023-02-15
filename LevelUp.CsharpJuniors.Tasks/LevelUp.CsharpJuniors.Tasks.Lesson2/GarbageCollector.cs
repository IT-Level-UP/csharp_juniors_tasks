using System;
namespace LevelUp.CsharpJuniors.Tasks.Lesson2;

public class GarbageCollector
{
	public GarbageCollector()
	{
	}

	public void TryCollect()
	{
		Console.WriteLine("\nPrint collection counts before some activity");
		PrintCollectionCount();
		PrintAllocatedBytes();

		var someSmallObject = new object();
		var bigArray = new int[90000];

		Console.WriteLine("Generation of small object: " + GC.GetGeneration(someSmallObject));
		Console.WriteLine("Generation of huge object: " + GC.GetGeneration(bigArray));

		PrintAllocatedBytes();

		GC.Collect();

		Console.WriteLine("Generation of small object: " + GC.GetGeneration(someSmallObject));
		Console.WriteLine("Generation of huge object: " + GC.GetGeneration(bigArray));

		Console.WriteLine("\nPrint collection counts after collection");
		PrintCollectionCount();
		PrintAllocatedBytes();
	}

	private void PrintAllocatedBytes()
	{
		Console.WriteLine("\tTotal allocated bytes: " + GC.GetTotalAllocatedBytes(true));
	}

	private void PrintCollectionCount()
	{
		Console.WriteLine("\tGen0 collections: " + GC.CollectionCount(0));
		Console.WriteLine("\tGen1 collections: " + GC.CollectionCount(1));
		Console.WriteLine("\tGen2 collections: " + GC.CollectionCount(2));
	}
}