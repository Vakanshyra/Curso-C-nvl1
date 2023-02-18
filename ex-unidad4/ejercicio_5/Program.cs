using System;

namespace ejercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
           //5. Hacer un programa para ingresar 4 números. Luego analizar e informar por pantalla si los mismos se encuentran ordenados de forma decreciente .


      

           int a,b,c,d;

           Console.WriteLine("Ingrese los 4 números"); 
            a= int.Parse(Console.ReadLine());
            b= int.Parse(Console.ReadLine());
            c= int.Parse(Console.ReadLine());
            d= int.Parse(Console.ReadLine());


            if (a>b && b>c && c>d)
            Console.WriteLine("se encuentran ordenados de manera decreciente!.");
                
            else
            
            Console.WriteLine("No se encuentran ordenados de manera decreciente!.");
            




        }
    }
}
