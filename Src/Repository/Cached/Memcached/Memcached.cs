using Enyim.Caching;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Caching;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Cached.Memcached
{
    public class Memcache : ICache
    {
        readonly MemcachedClient cache = new MemcachedClient();
        public void Add(string key, object value, string fullFileNameOfFileDependency)
        {
            Add(key, value, null);
        }

        public void Add(string key, object value, TimeSpan timeSpan)
        {
            cache.Store(Enyim.Caching.Memcached.StoreMode.Set, key, value, DateTime.Now.Add(timeSpan));
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public object Get(string cacheKey)
        {
            return cache.Get(cacheKey);
        }

        public T Get<T>(string cacheKey)
        {
            return cache.Get<T>(cacheKey);
        }

        public bool Remove(string cacheKey)
        {
            return cache.Remove(cacheKey);
        }

        public void Set(string key, object value, TimeSpan timeSpan)
        {
            cache.Store(Enyim.Caching.Memcached.StoreMode.Set, key, value, DateTime.Now.Add(timeSpan));
        }
    }
}
