using System;

namespace ejercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
           //5. Hacer un programa para ingresar por teclado las tres notas de exámenes de un alumno y luego calcule y emita por pantalla el promedio final.

                float n1,n2,n3,promedio;


                Console.WriteLine("ingrese sus 3 notas de alumno: ");
                n1= float.Parse(Console.ReadLine());
                n2= float.Parse(Console.ReadLine());
                n3= float.Parse(Console.ReadLine());

                promedio = (n1+n2+n3) / 3; 

                Console.WriteLine("su promedio es de : " + promedio);

        
        
        
        }       


    }
}
