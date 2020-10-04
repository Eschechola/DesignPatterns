using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gerando lista de arquivos...");

            var dataLoaderInstance = DataLoader.Instance;
            var dataList = dataLoaderInstance.Files;

            Console.WriteLine(string.Join("\n", dataList));

            var dataLoaderAnotherInstance = DataLoader.Instance;
            var dataListAnother = dataLoaderAnotherInstance.Files;

            Console.WriteLine(string.Join("\n", dataList) == string.Join("\n", dataListAnother));
        }
    }
}
