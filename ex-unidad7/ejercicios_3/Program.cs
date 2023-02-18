using System;

namespace ejercicios_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //3. Hacer un programa que solicite una cadena de caracteres y dos caracteres sueltos (tres ingresos). El programa deberá generar una cadena donde todas las ocurrencias del primer carácter dado hayan sido reemplazadas por el segundo. Mostrar el resultado en pantalla. Ejemplo:
            // CADENA FUENTE: “La mar estaba serena"
            // CARÁCTER 1: ‘a’ CARÁCTER 2: ‘i’
            // CADENA RESULTADO: “Li mir estibi sereni"

            char [] cadena_fuente = new char [26];
            char l;
            int j;
            
            Console.WriteLine("su primera letra : ");
            l = char.Parse(Console.ReadLine());
            j=0;

            while (l !='.' && j<25)
            {
                cadena_fuente[j]= l;
                l= char.Parse(Console.ReadLine());
                j++;
            }
            cadena_fuente[j]='\0';

            j=0;
            while (cadena_fuente[j]!='\0')
            {
                               
                if (cadena_fuente [j] == 'a')
                {
                    cadena_fuente[j] = 'i';
                }

                Console.WriteLine(cadena_fuente[j]);
                j++;
            }

            



            
        }
    }
}
