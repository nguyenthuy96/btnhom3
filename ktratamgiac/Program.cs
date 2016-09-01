using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ktratamgiac
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            Console.Write(" a = ");
            string sa = Console.ReadLine();
            a = double.Parse(sa);
            Console.Write(" b = ");
            string sb = Console.ReadLine();
            b = double.Parse(sb);
            Console.Write(" c = ");
            string sc = Console.ReadLine();
            c = double.Parse(sc);

            if(a+b>c && a+c > b&& b+c > a)
            {
                Console.WriteLine(" day la tam giac");
                if (a * a == b * b + c * c || b * b == a * a + c * c || c * c == a * a + b * b)
                {
                    if(a==b|| b==c||c == a)
                    {
                        Console.WriteLine(" day la tam giac vuong can");
                    }
                    else
                    {
                        Console.WriteLine(" day la tam giac vuong thuong");
                    }

                }
                else
                {
                    if (a == b && b == c)
                    {
                        Console.WriteLine(" day la tam giac deu");
                    }
                    else
                    {
                        if (a == b || b == c || c == a)
                        {
                            Console.WriteLine(" day la tam giac can");
                        }
                        else
                        {
                            Console.WriteLine(" day la tam giac thuong");
                        }
                    }

                        
                }
            }
            else
            {
                Console.WriteLine(" day k phai la tam giac");
            }
            Console.ReadKey();

        }
    }
}
