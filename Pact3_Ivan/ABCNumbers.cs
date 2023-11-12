using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pact3_Ivan
{
    public class ABCNumbers
    {
        private int numberA;
        private int numberB;
        private int numberC;

        public int NumberA { get => numberA; set => numberA = value; }
        public int NumberB { get => numberB; set => numberB = value; }
        public int NumberC { get => numberC; set => numberC = value; }

        public ABCNumbers()
        {
            NumberA = 0;
            NumberB = 0;
            NumberC = 0;
        }

        public ABCNumbers(int numberA, int numberB, int numberC)
        {
            NumberA = numberA;
            NumberB = numberB;
            NumberC = numberC;
        }

        public double GetResult()
        {
            if (NumberA < 15 || NumberB < 15 || NumberC < 15)
            {
                return (NumberA + NumberB + NumberC) / 3d;
            }
            else
            {
                return NumberA + NumberB + NumberC;
            }
        }
    }
}
