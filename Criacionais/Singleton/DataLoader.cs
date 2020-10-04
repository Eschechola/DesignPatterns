using System;
using System.Collections.Generic;

namespace Singleton
{
    public sealed class DataLoader
    {
        private static DataLoader _instance;

        public static DataLoader Instance
        {
            get
             {
                if (_instance == null)
                    _instance = new DataLoader();

                return _instance;
            }
        }

        public IList<string> Files = new List<string>();

        private DataLoader()
        {
            for (int i = 0; i < 25000; i++)
            {
                Files.Add(Guid.NewGuid().ToString());
            }
        }
    }
}
