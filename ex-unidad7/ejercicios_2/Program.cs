using System;

namespace ejercicios_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //2. Hacer un programa que solicite 10  números enteros y los guarde en un vector. Luego recorrer ese vector para calcular el promedio. Mostrar por pantalla los valores que son mayores al promedio.

            int [] numeros = new int [10];

            int n,acumulador,promedio ;

            for (int x = 0; x < 10; x++)
            {
                Console.WriteLine("ingrese su número : ");
                n=int.Parse(Console.ReadLine());

                numeros[x]= n;

            }
            acumulador=0;

            for (int x = 0; x < 10; x++)
            {
                acumulador += numeros[x];
            }
            promedio = acumulador/ 10;

            Console.WriteLine("los valores que son mayores al promedio dentro del vector son : ");
            for (int x = 0; x < 10; x++)
            {
                if (numeros[x] > promedio)
                {
                    Console.WriteLine (numeros[x]);
                }
            }
            // ----------------------------------------------------------------------------------------------------------------


    
            


        }
    }
}
