using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;

namespace LevelUp.CsharpJuniors.Tasks.Lesson4.Attributes;

[Warmup]
public sealed class SomeService
{
    [NonSerialized]
    private string _someField = "SomeData";

    [JsonPropertyName("Data")]
    public string SomeProp { get; } = "SomeData";

    [Warmup(WarmupLevel.Sync)]
    public void DoSomethingUseful()
    {
        Console.WriteLine($"{nameof(DoSomethingUseful)}");
    }

    [Warmup(WarmupLevel.Ready)]
    public void DoSomethingElse()
    {
        Console.WriteLine($"{nameof(DoSomethingElse)}");
    }

    [Warmup(WarmupLevel.Sync)]
    public void DoSomethingAgain([CallerMemberName] string caller = "")
    {
        Console.WriteLine($"{nameof(DoSomethingAgain)}, called from {caller}");
    }
}