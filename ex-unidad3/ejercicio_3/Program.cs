using System;

namespace ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {


            //3. Una casa de video juegos otorga un descuento dependiendo del importe de la compra realizada según los siguientes valores:

           // Si el importe es menor a ARS 1000, no hay descuento.
            //Si el importe es ARS 1000 o más pero menor a ARS 5000, aplica un descuento del 10%.
            //Si el importe es ARS 5000 o más, aplica un descuento del 18%.
            //Hacer un programa para ingresar un importe de venta y luego muestre por pantalla el importe final con el descuento que corresponda.


            float importe,Importe_Final;

            Console.WriteLine("Ingrese el Importe : ");

            importe = float.Parse(Console.ReadLine());

            if (importe > 5000)
            {Importe_Final = importe* 0.82F ;
                Console.WriteLine("su importe final es de :" + Importe_Final);
                
                }else if (importe> 1000)
                {Importe_Final = importe * 0.90F ;
                    Console.WriteLine("su importe final es de :" + Importe_Final);
                
                   }else
                   {Importe_Final = importe ;
                        Console.WriteLine("su importe final es de :" + Importe_Final);
                
            }

            Console.WriteLine("Fin del programa");



        


        }
    }
}
