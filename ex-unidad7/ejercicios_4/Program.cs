using System;

namespace ejercicios_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //4. Una empresa comercializa 15 tipos de artículos y por cada venta realizada genera un registro con los siguientes datos:
            // - Número de Artículo (1 a 15)
            // - Cantidad Vendida 

            // Puede haber varios registros para el mismo artículo y el último se indica con número de artículo igual a 0.
            // Se pide determinar e informar:
            // a) El número de artículo que más se vendió en total.
            // b) Los números de artículos que no registraron ventas.
            // c) Cuantas unidades se vendieron del número de artículo 10.

            
            int cantMax, art_max,numart_min;
  
            int [] acu = new int [15];           //Acumulador

            for (int x = 0; x < 15; x++)
            {
                acu[x] = 0;
            }

            int num,c;

            Console.WriteLine("ingrese su articulo: ");
            num = int.Parse(Console.ReadLine());
             Console.WriteLine("ingrese su cantidad vendida : ");
            c = int.Parse(Console.ReadLine());
            
            

           while (num!=0)
           {
            
          

            acu[num-1]+=c;

            
            Console.WriteLine("ingrese su articulo: ");
            num = int.Parse(Console.ReadLine());
            
            if (num!=0)
            {
                Console.WriteLine("ingrese su cantidad vendida : ");
                c = int.Parse(Console.ReadLine());
            }
           
           }
           

           cantMax = acu[0];
           art_max=1;
           

           for (int x = 0; x < 15; x++)
           {
                if (acu[x]> cantMax)
                {
                    cantMax = acu[x];
                    art_max = x+1;
                }
           }

           Console.WriteLine("el articulo que mas vendió es : " + art_max);


           Console.WriteLine("los articulos que no se vendieron son : " );
           
           for (int x = 0; x < 15; x++)
           {
                if (acu[x] == 0)
                {
                    numart_min = x+1;
                    Console.WriteLine(numart_min);         
                }
           }

           Console.WriteLine("las unidades vendidas del aritulo 10 es de : " + acu[9]);














        }
    }
}
