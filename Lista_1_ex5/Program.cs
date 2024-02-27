using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_1_ex5
{
    internal class Program
    {
        // oi
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("digite o primeiro numero");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("digite o segundo numero");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("digite o terceiro numero");
            c = int.Parse(Console.ReadLine());
            if(a == b  && b == c)
            {
                Console.WriteLine("é um triangulo equilatero");
            }
            else if( a == b && b != c && ((a + b) < c && (a + c) < b && (b + c) < a))
            {
                Console.WriteLine("é um triangulo isósceles");
            }
            else if ( a != b && a != c && b != c && ((a+b)<c && (a+c)<b && (b+c)<a))
            {
                Console.WriteLine("é um triangulo escaleno");
            }
            else { Console.WriteLine("não é um triangulo") ; }
        }
    }
}
