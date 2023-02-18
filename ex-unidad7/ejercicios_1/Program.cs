using System;

namespace ejercicios_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Hacer un programa que solicite 10 números enteros y los guarde en un vector. Luego recorrer los elementos y determinar e informar cuál es el valor máximo y su posición dentro del vector.

            int [] vector_numero = new int [10];
            int n ,max,pos;

            for (int x = 0; x < 10; x++)
            {
                Console.WriteLine("ingrese el número : ");
                n= int.Parse(Console.ReadLine());

                
                vector_numero[x] = n;
                
            }

            max = vector_numero[0];
            pos=1;

            for (int x = 0; x < 10; x++)
            {
                if (vector_numero[x] > max)
                {
                    max = vector_numero[x];
                    pos = x+1;
                }    
            }

            Console.WriteLine("su numero maximo  es : "+ max + " y posicion maxima es : " + pos);





            
        }
    }
}
