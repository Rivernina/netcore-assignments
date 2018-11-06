using Lesson00.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson00.Views.One
{
    class Form
    {
        public static SingleModel singleModel = new SingleModel();

        public static SingleModel EnterChar()
        {
            Console.WriteLine("\n\t\t\t\tPlease enter any character:");
            singleModel.Character = Console.ReadLine();

            Console.WriteLine("\t\tHow many times do you want me to repeat this character?");
            singleModel.AmountTimes = Convert.ToInt32(Console.ReadLine());

            return singleModel;
        }
    }
}
