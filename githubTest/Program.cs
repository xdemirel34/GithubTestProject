using System;

namespace githubTest
{

    enum typicalType {
        Monday,
        Saturday,
        Wednesday
        }

    class Program
    {
        
        static void Main(string[] args)
        {
            var result = typicalType.Monday;

            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
