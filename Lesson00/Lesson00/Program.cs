using Lesson00.Controllers;
using System;

namespace Lesson00
{
    class Program
    {
        static void Main(string[] args)
        {
            OneController oneController = new OneController();
            oneController.Form();
            oneController.Index();
        }
    }
}
