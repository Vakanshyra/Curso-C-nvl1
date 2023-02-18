using System;

namespace ejercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //5. Hacer un programa para ingresar cuatro número y luego mostrar por pantalla cuáles son mayores a 100.


            int a,b,c,d;

            Console.WriteLine("ingrese su número");
            a=int.Parse(Console.ReadLine());

            Console.WriteLine("ingrese su número");
            b=int.Parse(Console.ReadLine());
            
            Console.WriteLine("ingrese su número");
            c=int.Parse(Console.ReadLine());
            
            Console.WriteLine("ingrese su número");
            d=int.Parse(Console.ReadLine());

            Console.WriteLine("Estos son mayores a 100 : ");
            if (a>100)
            {Console.WriteLine("a");
                
            }

            if (b>100)
            {Console.WriteLine("b");
                
            }
            
            if (c>100)
            {Console.WriteLine("c");
                
            }
            
            if (d>100)
            {Console.WriteLine("d");
                
            }

            Console.WriteLine("Fin del Programa");





        }
    }
}
