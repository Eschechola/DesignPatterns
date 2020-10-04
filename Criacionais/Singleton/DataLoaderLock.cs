using System;
using System.Collections.Generic;

namespace Singleton
{
    public sealed class DataLoaderLock
    {
        private static readonly object locker = new object();
        private static DataLoaderLock _instance;

        public static DataLoaderLock Instance
        {
            get
            {
                lock (locker)
                {
                    if (_instance == null)
                        _instance = new DataLoaderLock();

                    return _instance;
                }   
            }
        }

        public IList<string> Files = new List<string>();

        private DataLoaderLock()
        {
            for (int i = 0; i < 25000; i++)
            {
                Files.Add(Guid.NewGuid().ToString());
            }
        }
    }
}
