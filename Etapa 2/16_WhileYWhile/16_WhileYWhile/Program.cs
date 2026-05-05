using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_WhileYWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int while1;
            int while2;
            int while3;
            int while4;
            int while5;

            while1 = 100;
            while2 = 100;
            while3 = 100;
            while4 = 100;
            while5 = 100;
            Console.WriteLine("While 1 ");
            while (1 < while1  )
            {
              while1--;
              if (while1 %3 == 0 )
                {
                    Console.WriteLine(while1);
                    
                }
                 
               
            }
            Console.WriteLine("While 2");
            while ( 1 < while2)
            {
                while2--;
                if (while2 %2 == 0)
                {
                    Console.WriteLine(while2);
                }
            }
            Console.WriteLine("While 3");
            
            while (while3 > 1)
            {
                while3--;
                if (while3 % 2 == 0 && while3 %3 == 0)
                {
                    Console.WriteLine(while3);
                }
            }
            Console.WriteLine("While 4");
            while (while4 > 1)
            {
                while3--;
                if (while4 > 100)
                {
                    Console.WriteLine(while3);
                }
            }
            Console.ReadKey();
        }
    }
}
