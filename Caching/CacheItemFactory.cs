using System;

namespace LightestNight.System.Caching
{
    public class CacheItemFactory : ICacheItemFactory
    {
        /// <inheritdoc cref="ICacheItemFactory.Create" />
        public CacheItem Create(string key, params string[]? tags)
            => new CacheItem
            {
                Key = key,
                Tags = tags
            };

        /// <inheritdoc cref="ICacheItemFactory.Create{T}" />
        public CacheItem<T> Create<T>(string key, T value, DateTime? expiry = null, params string[]? tags)
            where T : notnull
            => new CacheItem<T>
            {
                Key = key,
                Tags = tags,
                Expiry = expiry,
                Value = value
            };
    }
}