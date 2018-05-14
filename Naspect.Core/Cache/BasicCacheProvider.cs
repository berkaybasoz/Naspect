using System;
using System.Collections.Concurrent;

namespace Naspect.Core.Cache
{
    public class BasicCacheProvider : ICacheProvider
    {
        private static ConcurrentDictionary<string, object> cacheData = new ConcurrentDictionary<string, object>();

        public bool TryGetData(string cacheKey, out object data)
        {
            bool exists = cacheData.TryGetValue(cacheKey, out data);
            if (exists)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("{0} key ile cache'ten geliyorum...", cacheKey);
                Console.ResetColor();
            }
            return exists;
        }

        public void SetData(string cacheKey, object data)
        {
            cacheData.TryAdd(cacheKey, data);
        }
    }
}
