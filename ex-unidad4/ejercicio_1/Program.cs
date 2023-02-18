using System;

namespace ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Hacer un programa que solicite el ingreso de dos números y luego calcular:
            // La resta si el primero es mayor que el segundo.
            //La suma si son iguales.
            //El producto si el primero es menor.
            //Se deberá emitir un cartel por pantalla con el resultado correspondiente.


            int a,b;

            Console.WriteLine ("ingrese sus dos números : ");
            a= int.Parse(Console.ReadLine());
            b= int.Parse(Console.ReadLine());

            if (a>b)
            Console.WriteLine("su resta es de " + (a-b));
            
            if (a==b)
            Console.WriteLine("su suma es de " + (a+b));

            if (a<b)
            Console.WriteLine("su mult. es de " + (a*b));
            

            Console.WriteLine("Fin del Programa");

















        }
    }
}
