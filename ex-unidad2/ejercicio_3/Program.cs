using System;

namespace ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
           //3. Hacer un programa que permita ingresar los kilómetros existentes entre dos ciudades y la velocidad promedio de un vehículo.
           // Calcular y emitir por pantalla el tiempo aproximado que demandará llegar de un punto a otro teniendo en cuenta los datos ingresados.


            int km , vp, tiempo ;

            Console.WriteLine("ingrese los kilometros: ");
            km = int.Parse(Console.ReadLine());

            Console.WriteLine("ingrese los velocidad promedio de un vehiculo: ");
            vp = int.Parse(Console.ReadLine());

            tiempo = km / vp;

            Console.WriteLine("el tiempo aproximado es de : " + tiempo + " horas. " );



























        }
    }
}
