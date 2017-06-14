using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle_Formations
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int max = 0;
            bool isTriangle = false;
            bool isRightangle = false;
            string rightAngle = null;

            if (a>max)
            {
                max = a;
                if (a<=b+c)
                {
                    isTriangle = true;
                    if ((a*a)==(b*b)+(c*c))
                    {
                        isRightangle = true;
                        rightAngle = "Triangle has a right angle between sides b and c";
                    }
                }

            }

            if (b > max)
            {
                max = b;
                if (b <= a + c)
                {
                    isTriangle = true;
                    if ((b * b) == (a * a) + (c * c))
                    {
                        isRightangle = true;
                        rightAngle = "Triangle has a right angle between sides a and c";
                    }
                }
            }
            if (c > max)
            {
                max = c;
                if (c <= a + b)
                {
                    isTriangle = true;
                    if ((c * c) == (b * b) + (a * a))
                    {
                        isRightangle = true;
                        rightAngle = "Triangle has a right angle between sides a and b";

                    }
                }
            }
            else
            {
                // no bonus
            }

            Console.WriteLine("{0}", isTriangle ? "Triangle is valid.": "Invalid Triangle.");
            Console.WriteLine("{0}", isRightangle ? rightAngle:null);





        }
    }
}
