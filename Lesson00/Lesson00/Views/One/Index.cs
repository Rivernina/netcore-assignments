using Lesson00.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson00.Views.One
{
    class Index
    {
        static string result = "" + new string(' ', 43);
        public static void Result(SingleModel singleModel)
        {
            for (int i = 0; i < singleModel.AmountTimes; i++)
            {
                result = result + singleModel.Character;
            }

            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
