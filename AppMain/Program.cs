using System;

namespace AppMain
{
    class Program
    {
        static void Main(string[] args)
        {
            string result = SharedLib.StringHelper.Reverse("Hello");
            Console.WriteLine(result);
        }
    }
}
