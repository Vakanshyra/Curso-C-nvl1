using System;

namespace ejercicios_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //2. Se dispone de una lista de 5 listas de números enteros separados entre ellos por ceros. Se pide determinar e informar:
            // El número de grupo con mayor porcentaje de números impares respecto al total de números que forman el grupo.
            // Informar cuántos grupos están formados por todos números ordenados de mayor a menor.
            int n, max, bandera = 0, contadorgrupoordenado = 0, numImpare, cont, maxgrupo;
            double porcentaje, Maxporcentaje;
            Maxporcentaje = 0;
            maxgrupo = 0;
            for (int i = 0; i < 5; i++)
            {
                cont = 0;
                numImpare = 0;
                Console.WriteLine("Ingrese su número");
                n = int.Parse(Console.ReadLine());
                max = n;
                while (n != 0)
                {
                    cont++;
                    if (n % 2 != 0)
                        numImpare++;
                    if (n > max)
                        bandera = 1;
                    Console.WriteLine("Ingrese su número");
                    n = int.Parse(Console.ReadLine());
                }//------------------------------------------------------------

                if (bandera == 0)
                    contadorgrupoordenado++;
                else
                    Console.WriteLine("el grupo numero  : " + i + 1 + " no esta ordenado ");

                porcentaje = numImpare * 100 / cont;

                if (porcentaje > Maxporcentaje)
                {
                    Maxporcentaje = porcentaje;
                    maxgrupo = i + 1;
                }
            }
            Console.WriteLine("el grupo maximo con mayor porcentaje es : " + maxgrupo + " con un porcentaje de : " + Maxporcentaje);
        }
    }
}
