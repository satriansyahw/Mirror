using System; 
using System.Runtime.Caching;

namespace MirrorLayer.General.Helper.MemCache
{
    public class MemoryCacher
    {
        private static MemoryCacher instance;
        public static MemoryCacher GetInstance
        {
            get
            {
                if (instance == null)
                    instance = new MemoryCacher();
                return instance;
            }
        }

        public object GetValue(string key)
        {
            MemoryCache memoryCache = MemoryCache.Default;
            return memoryCache.Get(key);
        }

        public bool Add(string key, object value, DateTimeOffset absExpiration)
        {
            MemoryCache memoryCache = MemoryCache.Default;
            return memoryCache.Add(key, value, absExpiration);
        }

        public bool Add(string key, object value, double absMinuteExpiration)
        {
            MemoryCache memoryCache = MemoryCache.Default;
            return memoryCache.Add(key, value, this.GetMinutes(absMinuteExpiration));
        }

        public bool AddSeconds(string key, object value, double absSecondsExpiration)
        {
            MemoryCache memoryCache = MemoryCache.Default;
            absSecondsExpiration = absSecondsExpiration * 1000;
            DateTimeOffset timeSeconds = DateTimeOffset.Now.AddSeconds(absSecondsExpiration);
            return memoryCache.Add(key, value, timeSeconds);
        }

        private DateTimeOffset GetMinutes(double minutes)
        {
            return DateTimeOffset.Now.AddMinutes(minutes);
        }

        public void Delete(string key)
        {
            MemoryCache memoryCache = MemoryCache.Default;
            if (memoryCache.Contains(key))
            {
                memoryCache.Remove(key);
            }
        }
    }
}