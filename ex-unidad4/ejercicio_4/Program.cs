using System;

namespace ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {


            //4. Hacer un programa para ingresar tres números y emitir un cartel aclaratorio si la suma de los dos primeros es mayor al producto del segundo con el tercero.

            int a,b,c,suma ,producto ;

            Console.WriteLine("ingrese sus números : ");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());


            suma= a + b ;
            producto = b * c ;

            if (suma> producto)
            Console.WriteLine("la suma es mayor al producto!.");
                
            else
            Console.WriteLine("no es mayor. ");
                

            Console.WriteLine("Fin del Programa. ");
            









        }
    }
}
