using System;

namespace ejercicios_1
{
    class Program
    {
        static void Main(string[] args)
        { 
            //1. Hacer un programa para ingresar 10 números. El mismo debe analizar y mostrar por pantalla cuántos de esos números son primos.
           int n, primo=0,contador;

            for (int x = 0; x < 10; x++)
            {   
                Console.WriteLine("Ingrese su número : ");
                n = int.Parse(Console.ReadLine());
                


                contador=0;
                for (int y = 1; y <= n; y++) 
                {
                    
                    if (n % y == 0)
                        contador++;
                    
                }
                if (contador == 2)
                   primo++;
                    
                    
                

                
            }

            Console.WriteLine("la cantidad de números primos es de : " + primo);
            Console.WriteLine("Fin del Programa");



        




































        }
    }
}
