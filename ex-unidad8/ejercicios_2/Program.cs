using System;

namespace ejercicios_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //2. Hacer una función llamada “par” que reciba un número entero y devuelva 1 si es par o cero si no lo es. Hacer un programa para ingresar 20 números y mostrar por pantalla cuántos son pares.

            int n,i,cont=0;

            for (int x = 0; x < 20; x++)
            {
                Console.WriteLine("Ingrese el número : ");
                n = int.Parse(Console.ReadLine());
                
                i = par(n);
                if (i==1)
                {
                    cont++;
                }

            }
            Console.WriteLine("la cantidad de números pares es de : " + cont);


        }
        static int par (int a)
        {
            int r;

            if (a%2==0)
            {
                r= 1;
            }
            else
            {
                r=0;
            }

            return r;
        }

    }
}
