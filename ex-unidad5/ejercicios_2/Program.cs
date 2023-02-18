using System;

namespace ejercicios_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //2. Hacer un programa que solicite el ingreso de 10 números y que muestre el mayor de ellos por pantalla. Solo se debe emitir UN valor por pantalla.
            int n , mayor=0;
            int b = 0;
            

            for (int x = 0; x < 10; x++)
            {   Console.WriteLine("ingrese el número : ");
                n = int.Parse(Console.ReadLine());

                if (b == 0)
                {  mayor = n ;
                   b = 1;
                    
                }else if (n > mayor)
                {  mayor = n;
                    
                }
                
            }

            Console.WriteLine("el mayor de todos los números ingresados es : " + mayor);









        }
    }
}
