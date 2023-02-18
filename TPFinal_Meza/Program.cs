using System;

namespace TPFinal_Meza
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa que permita ingresar una lista de números que corta cuando se ingresa un cero. A partir de dichos datos informar:

            // a. El mayor de los números pares.
            // b. La cantidad de números impares.
            // c. El menor de los números primos.

            // Nota: evaluar el uso de una función que analice si un número dado es primo o no y que devuelva true o false según corresponda.
            //         
            
            int n,i,j,cont_impares=0,maxpar=0,minimo_primo=0;
            bool bpar=false,bpri=false;


            Console.WriteLine("Ingrese un número : ");
            n=int.Parse(Console.ReadLine());

            while (n!= 0)
            {
                i= par(n);             
                if (i == 1)
                {
                    if (!bpar)
                    {
                        maxpar = n;
                        bpar=true;
                    }
                    else if (n>maxpar)
                    {
                        maxpar=n;
                    }
                   
                }
                else
                {
                    cont_impares++;
                }

                j= primo(n);           
                
                if (j == 1)
                {
                    if (!bpri)
                    {
                        minimo_primo = n;
                        bpri=true;
                    }
                    else if (n<minimo_primo)
                    {
                        minimo_primo= n;
                    }
                }


                Console.WriteLine("Ingrese otro número : ");
                n=int.Parse(Console.ReadLine());
            }

            Console.WriteLine("el número Maximo par es de : " + maxpar );
            Console.WriteLine( "la cantidad de números impares es de : " + cont_impares);
            Console.WriteLine("la número minimo Primo es :" + minimo_primo);



        }

        static int par(int a)           // funcion par
        {
            if (a % 2== 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        static int primo(int b)             //funcion primo
        {
            int cont= 0;
            for (int x= 1; x <= b; x++)
            {
                if (b % x == 0)
                {
                    cont++;
                }
            }

            if (cont==2)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        
        
        
        }


    }
}
