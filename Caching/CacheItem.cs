using System;
// ReSharper disable RedundantDefaultMemberInitializer

namespace LightestNight.System.Caching
{
    [Serializable]
    public class CacheItem
    {
        /// <summary>
        /// The key to store the item under
        /// </summary>
        public string Key { get; set; } = string.Empty;
        
        /// <summary>
        /// Any tags to attach to the item
        /// </summary>
        public string[]? Tags { get; set; }
        
        /// <summary>
        /// The date and time the item will expire and be removed from the cache
        /// </summary>
        public DateTime? Expiry { get; set; }
    }

    [Serializable]
    public class CacheItem<T> : CacheItem
    {
        /// <summary>
        /// The value to store in the item
        /// </summary>
        public T Value { get; set; } = default!;     // Can't declare nullable generic in C# 8 so this value has to be nullable (default of a reference type if null)
    }
}