using System;

namespace ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //4. Hacer un programa para ingresar cuatro números distintos y luego mostrar por pantalla el menor de ellos.

            int a,b,c,d,min;
        

            Console.WriteLine("ingrese sus 4 números : ");
            a=int.Parse(Console.ReadLine());
            b=int.Parse(Console.ReadLine());
            c=int.Parse(Console.ReadLine());
            d=int.Parse(Console.ReadLine());


            if (a<b)
            {min = a;
                
                }else
                {min = b;
                
            }
            
            if (c<min)
            {min = c;
                
                }else if(d<min)
                {min = d;
                
            }

            Console.WriteLine("el menor de todos es : " + min); 




























        }
    }
}
