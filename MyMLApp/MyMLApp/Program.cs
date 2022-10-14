using MyMLApp.Helper;

namespace MyMLApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ML Process started!");

            TestRunner.RunTest();

            Console.WriteLine("=============== End of process, hit any key to finish ===============");
            Console.ReadKey();

        }
    }
}