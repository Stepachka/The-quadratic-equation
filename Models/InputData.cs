using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1.Models
{
    public class InputData
    {
        public double a;
        public double b;
        public double c;
        public InputData() {

           while (true)
            {
                try
                {
                    Console.WriteLine("Введите значение а : ");
                    a = Convert.ToDouble(Console.ReadLine());
                    break;
                }
                catch
                {

                }
            }

            while (true)
            {
                try
                {
                    Console.WriteLine("Введите значение b : ");
                    b = Convert.ToDouble(Console.ReadLine());
                    break;
                }
                catch
                {

                }
            }

            while (true)
            {
                try
                {
                    Console.WriteLine("Введите значение c : ");
                    c = Convert.ToDouble(Console.ReadLine());
                    break;
                }
                catch
                {

                }
            }

            Console.WriteLine($"Ваши данные a = {a}, b = {b}, c = {c}");
        }
    }
}
