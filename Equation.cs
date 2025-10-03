using lab1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    public class Equation
    {
        
        public double Discriminant(double a, double b, double c) => b * b - 4 * a * c;
        public Answer SolveEquationDiscriminant ()
        {

            var InputData = new InputData();
            var discriminant = Discriminant(InputData.a, InputData.b, InputData.c);

            if (discriminant < 0)
            {
                return new Answer { decision = false};
            }
            else if (discriminant == 0)
            {
                return new Answer {
                    x1 = ((-(InputData.b)) / 2 * InputData.a),
                    x2 = ((-(InputData.b)) / 2 * InputData.a),
                    decision = true,
                    };
            }
            else
            {
                return new Answer
                {
                    x1 = (((-(InputData.b)) + Math.Sqrt(discriminant)) / 2 * InputData.a),
                    x2 = (((-(InputData.b)) - Math.Sqrt(discriminant)) / 2 * InputData.a),
                    decision = true,

                };
            }
            
        }
       

        
    }
}
