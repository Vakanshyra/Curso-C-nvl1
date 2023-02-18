using System;

namespace ejercicios_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //3. Hacer un programa que solicite 20 edades y luego calcule el promedio de edad de aquellas personas mayores a 18 años.


            int edad,promedio ;
            int acu = 0,contador =0 ;
            

            for (int x = 0; x < 20; x++)
            {   Console.WriteLine ("ingrese la edad: ");
                edad = int.Parse(Console.ReadLine());
              

                if (edad > 18)
                {
                    acu =+ edad;
                    contador++;   
                }

            }
            promedio = acu / contador ;

            Console.WriteLine("el promedio de  las personas que son mayores a 18 es de : " + promedio);


        }
    }
}
