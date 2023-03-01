using lab1.Models;

namespace lab1
{
    public class Program
    {
        
        public static void Main(string[] args)
        {
            
            var Equation = new Equation();
            var Answer = Equation.SolveEquationDiscriminant();
            
            if (Answer.decision)
            {
                Console.WriteLine($"Решение: х = {Answer.x1}, x = {Answer.x2}");
            }
            else
            {
                Console.WriteLine("Решения нет");
            }
        }

    }
}