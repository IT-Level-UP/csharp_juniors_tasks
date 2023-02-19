namespace LevelUp.CsharpJuniors.Tasks.Lesson4.Caching;

public sealed class SimpleGenericCache<T>
{
    private readonly Dictionary<string, T?> _cache = new();

    public void Store(string key, T value)
    {
        _cache[key] = value;
    }

    internal T? Fetch(string key)
    {
        if (_cache.TryGetValue(key, out var value))
        {
            return value;
        }

        return default;
    }
}