using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasycodaCubeMaschineTest
{
    class Program
    {
        public static void Main(string[] args)
        {
            int a = 3;

           int AC = a;

           int CE = 2 * a;

            // shortest distance 
            double shortestDistace = Math.Sqrt(AC * AC + CE * CE);

            Console.WriteLine(shortestDistace);


            float x1 =1, y1=1, z1=10;
            float x2 = 2, y2 = 1, z2 = 10;
            float x3 = 0, y3 = 5, z3 = 9;

            double d = Math.Pow((Math.Pow(x2 - x1, 2) +
                         Math.Pow(y2 - y1, 2) +
                         Math.Pow(z2 - z1, 2) *
                                   1.0), 0.5);
            //Console.WriteLine(d);

            //eqaution for surface 

           
            double DistancePt2 = Math.Sqrt(Math.Sqrt(x2 - x1) + Math.Sqrt(y2 - y1) + Math.Sqrt(z2 - z1));
            Console.WriteLine(DistancePt2);

           // double DistancePt3 = Math.Sqrt(Math.Sqrt(x3 - x2) + Math.Sqrt(y3 - y2) + Math.Sqrt(z3 - z2));
           // Console.WriteLine(DistancePt3);
            



        }
    }
}
