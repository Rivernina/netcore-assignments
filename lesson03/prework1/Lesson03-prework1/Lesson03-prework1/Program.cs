using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson03_prework1
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Starting");
            System.Threading.Tasks.Task.Run(() =>
            {
                System.Console.WriteLine("Hello World!");
                System.Threading.Tasks.Task.Delay(2000).Wait();
                System.Console.WriteLine("Hello Again!");
                
            }).Wait();
            System.Console.WriteLine("Ending");
            System.Console.ReadKey();
        }
    }
}
