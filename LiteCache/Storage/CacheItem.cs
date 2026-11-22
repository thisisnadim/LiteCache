namespace LiteCache.Storage;

public class CacheItem
{
    public string Value {get;}

    public DateTime? ExpiresAt {get;}

    public CacheItem(string value, int? ttlSeconds = null)
    {
        Value = value ; 

        ExpiresAt = ttlSeconds.HasValue ? DateTime.UtcNow.AddSeconds(ttlSeconds.Value) : null ;

    }

   public bool IsExpired()
    {
        return ExpiresAt.HasValue && DateTime.UtcNow >= ExpiresAt.Value;
    }
}