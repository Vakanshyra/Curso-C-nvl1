using System;

namespace ejercicios_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //3. Hacer una función llamada “primo” que reciba un número entero y devuelva 1 si el número es primo o cero si no lo es. Hacer un programa para ingresar números. El lote corta cuando se ingresa un número cero. Informar el promedio teniendo en cuenta sólo los números primos.
            
         int n,acu=0,cantidad_primo=0,i;

         Console.WriteLine("ingrese el número : ");
         n = int.Parse(Console.ReadLine());
            
            while (n!=0)
            {
                i = primo(n);
                if (i==1)
                {
                    acu+=n;
                    cantidad_primo++;
                   
                }
                
                Console.WriteLine("ingrese el número : ");
                n = int.Parse(Console.ReadLine());
            }
        
            int promedio= acu/cantidad_primo;

            Console.WriteLine("el promedio de los números primos es de " + promedio);
            Console.WriteLine("Fin del programa.");

        }
        static int primo(int a)
        {
            int cont = 0;

            for (int x = 1; x <= a; x++)            
            {
                if (a % x == 0)
                {
                    cont++;
                }
            }
            if (cont==2)
                return 1;
            
            else

               return 0;
            



        }
    }
}
