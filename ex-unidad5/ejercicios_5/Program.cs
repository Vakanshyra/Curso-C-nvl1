using System;

namespace ejercicios_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //. Hacer un programa que solicite 20 números y luego emitir por pantalla el máximo de los números pares y el mínimo de los números impares.


            int n, bp=0 , bi = 0 ,Minimpar=0 ,Parmaximo=0;

            for (int x = 0; x < 20; x++)
            {Console.WriteLine("Ingrese su número : ");
             n=int.Parse(Console.ReadLine());

             if (n % 2 ==0)
             {if (bp==0)//es es cuando es par
                {Parmaximo= n;
                 bp=1;

                
                }else if(n> Parmaximo)
                    {Parmaximo = n;
                    
                    }
                
             }else if (bi==0)//aca cuando es impar
                {Minimpar = n;
                 bi=1;

                }else if(n<Minimpar)
                    {Minimpar = n;
                    
                    }
            }

            Console.WriteLine("su maximo par es de:" + Parmaximo);
            Console.WriteLine("su minimo impar es de:" + Minimpar);
            Console.WriteLine("Fin del Programa");

        }
    }
}
