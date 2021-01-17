using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pool._1
{
    class Program
    {
       
            static void Main(string[] args)
            {
                problema1();
                problema2();
                problema3();
                problema4();
                problema5();
                problema6();
                problema7();
                problema8();
                problema9();
                problema10();
                problema11();
                problema12();
                problema13();
                problema15();
                problema18();
            }
            private static void problema1()
            {
                float a, b, x;
                Console.Write("Introduceti a = ");
                a = float.Parse(Console.ReadLine());
                Console.Write("Introduceti b = ");
                b = float.Parse(Console.ReadLine());
                if (a == 0 && b != 0)

                    Console.WriteLine("Ecuatie nedet. ");
                if (a == 0 && b == 0)
                    Console.WriteLine("Ecuatie imposibila");
                else
                {
                    x = -b / a;
                    Console.WriteLine("Solutia este x = {0}", x);
                }
                Console.ReadKey();
            }
            private static void problema2()
            {
                float a, b, c, dt;
                double x1, x2;
                Console.Write("a = ");
                a = float.Parse(Console.ReadLine());
                Console.Write("b = ");
                b = float.Parse(Console.ReadLine());
                Console.Write("c = ");
                c = float.Parse(Console.ReadLine());
                if (a == 0)
                    if (b == 0)
                        if (c == 0) Console.WriteLine("Ec. nedeterminat.");
                        else Console.WriteLine("Ec. imposibila");
                    else
                    {
                        x1 = -c / b;
                        Console.WriteLine("Ec. de gr. 1 cu x1 = {0}", x1);
                    }
                else
                {
                    dt = b * b - 4 * a * c;
                    if (dt < 0)
                        Console.WriteLine("Ec. are solutii complxe");
                    else
                    {
                        if (dt == 0)
                        {
                            x1 = x2 = -b / (2 * a);
                            Console.WriteLine("x1 = x2 = {0}", x1);
                        }
                        else
                        {
                            x1 = (-b + Math.Sqrt(dt)) / (2 * a);
                            x2 = (-b - Math.Sqrt(dt)) / (2 * a);
                            Console.WriteLine("Solutiile sunt x1 = {0}, x2 = {1}", x1, x2);
                        }
                    }
                }
            }
            private static void problema3()
            {
                int n, k;
                Console.Write("n = ");
                n = int.Parse(Console.ReadLine());
                Console.Write("k = ");
                k = int.Parse(Console.ReadLine());
                if (n % k == 0)
                    Console.WriteLine("n divide pe k");

                else Console.WriteLine("n nu divide pe k");
            }
            private static void problema4()
            {
                int n;
                Console.Write("n = ");
                n = int.Parse(Console.ReadLine());

                if (n % 4 == 0)
                    Console.WriteLine("an bisect");

                else Console.WriteLine("nu i bisect ");
            }
            private static void problema5()
            {
                float n;
                Console.Write("n = ");
                n = float.Parse(Console.ReadLine());

                if (n != 0)
                {
                    n %= 10;
                    Console.WriteLine("ultima cifra este n={0}", n);
                }
            }
            private static void problema6()
            {
                int a, b, c;
                Console.Write("a = ");
                a = int.Parse(Console.ReadLine());
                Console.Write("b = ");
                b = int.Parse(Console.ReadLine());
                Console.Write("c = ");
                c = int.Parse(Console.ReadLine());
                if (a + b >= c & a + c >= b & b + c >= a)
                {
                    Console.WriteLine("este tr");
                }
                else Console.WriteLine("nu e tr ");
            }
            private static void problema7()
            {
                int a, b, aux;
                Console.Write("a =");
                a = int.Parse(Console.ReadLine());
                Console.Write("b =");
                b = int.Parse(Console.ReadLine());
                aux = a;
                a = b;
                b = aux;
                Console.WriteLine("a={0}", a);
                Console.WriteLine("b={0}", b);
            }
            private static void problema8()
            {
                int a, b;
                Console.Write("a =");
                a = int.Parse(Console.ReadLine());
                Console.Write("b =");
                b = int.Parse(Console.ReadLine());

                a = b;
                b = a;
                Console.WriteLine("a={0}", a);
                Console.WriteLine("b={0}", b);
            }
            private static void problema9()
            {
                int n;
                Console.Write("n = ");
                n = int.Parse(Console.ReadLine());
                for (int d = 1; d * d <= n; d++)
                    if (n % d == 0)
                    {
                        Console.WriteLine("d={0}", d);
                    }
            }
            private static void problema10()
            { }
            private static void problema11()
            {
                int n, ogl;
                Console.Write("n= ");
                n = int.Parse(Console.ReadLine());
                ogl = 0;
                while (n > 0)
                {
                    ogl = ogl * 10 + n % 10;
                    n = n / 10;

                }
                Console.WriteLine("inversul numarul este ={0}", ogl);
            }
            private static void problema12()
            {
                int n, a, b;
                Console.Write("n= ");
                n = int.Parse(Console.ReadLine());
                Console.Write("a= ");
                a = int.Parse(Console.ReadLine());
                Console.Write("b= ");
                b = int.Parse(Console.ReadLine());


                for (int i = a; i <= b; i++)
                {
                    if (i % n == 0)
                        Console.WriteLine("numerele divizibile din intervalul [a,b] cu n sunt ={0}", i);
                }
            }
            private static void problema13()
            {
                int y1, y2;
                Console.Write("y1 = ");
                y1 = int.Parse(Console.ReadLine());
                Console.Write("y2 = ");
                y2 = int.Parse(Console.ReadLine());
                for (int i = y1; i <= y2; i++)
                {
                    if (i % 4 == 0 && i % 100 != 0)
                        Console.WriteLine(i);

                }
            }
            private static void problema15()
            {
                int a, b, c, aux;
                Console.Write("a= ");
                a = int.Parse(Console.ReadLine());
                Console.Write("b= ");
                b = int.Parse(Console.ReadLine());
                Console.Write("c= ");
                c = int.Parse(Console.ReadLine());

                if (a > b)
                {
                    aux = a;
                    a = b;
                    b = aux;
                }
                if (a > c)
                {
                    aux = a;
                    a = c;
                    c = aux;
                }
                if (b > c)
                {
                    aux = b;
                    b = c;
                    c = aux;
                }
                Console.WriteLine("{0} {1} {2}", a, b, c);
            }
            private static void problema18()
            {
                int n, d, p;
                Console.Write("n= ");
                n = int.Parse(Console.ReadLine());
                d = 2;
                while (n > 1)
                {
                    p = 0;
                    while (n % d == 0)
                    {
                        n /= d;
                        p++;
                    }
                    if (n > 0)
                        Console.WriteLine("{0}^{1}*", d, p);
                    d++;

                }
            }

        }

    }


    