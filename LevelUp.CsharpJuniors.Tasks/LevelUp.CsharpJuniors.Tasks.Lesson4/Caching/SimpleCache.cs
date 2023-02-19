using System.Text.Json;

namespace LevelUp.CsharpJuniors.Tasks.Lesson4.Caching;

public sealed class SimpleCache
{
    private readonly Dictionary<string, string> _cache = new ();
        
    public void Store<T>(string key, T value)
    {
        var serializedValue = JsonSerializer.Serialize(value);
        _cache[key] = serializedValue;
    }

    internal T? Fetch<T>(string key)
    {
        if (_cache.TryGetValue(key, out var value))
        {
            var deserializedValue = JsonSerializer.Deserialize<T>(value);
            return deserializedValue;
        }

        return default;
    }
}