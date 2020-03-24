namespace MirrorLayer.General.Helper.MemCache
{
    public class MemCacheFake
    {
        private static MemCacheFake instance;
        public static MemCacheFake GetInstance
        {
            get
            {
                if (instance == null)
                    instance = new MemCacheFake();
                return instance;
            }
        }

        public double CacheLimitFakeTable = 30;
        public string CacheNameFakeTable = "MemcacheCacheNameFakeTable";

       
    }
}