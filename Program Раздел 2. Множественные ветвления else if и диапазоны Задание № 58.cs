using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program58
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("ИМТ: ");
            if (double.TryParse(Console.ReadLine(), out double bmi))
            {
                string category;
                if (bmi < 18.5) category = "Дефицит веса";
                else if (bmi < 25) category = "Норма";
                else if (bmi < 30) category = "Избыток";
                else category = "Ожирение";

                Console.WriteLine(category);
            }
            else
            {
                Console.WriteLine("Ошибка ввода.");
            }
        }
    }
}
