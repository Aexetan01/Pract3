using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pact3_Ivan
{
    public class ABNumbers
    {
        private int numberA;
        private int numberB;

        public int NumberA { get => numberA; set => numberA = value; }
        public int NumberB { get => numberB; set => numberB = value; }

        public ABNumbers()
        {
            NumberA = 0;
            NumberB = 0;
        }

        public ABNumbers(int numberA, int numberB)
        {
            NumberA = numberA;
            NumberB = numberB;
        }

        public int GetResult()
        {
            if (NumberA > NumberB)
            {
                throw new ArgumentException("A > B!");
            }

            int count = 0;

            for (int i = NumberA; i <= NumberB; i++)
            {
                if (i % 2 == 0 && i % 7 == 0) count++;
            }

            return count;
        }
    }
}
