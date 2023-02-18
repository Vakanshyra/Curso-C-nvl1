using System;

namespace ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //2. Un importante negocio de desinfectante líquido realiza descuentos dependiendo de la cantidad de litros vendidos según la siguiente escala:

            // vende menos de 100 litros, no hay descuento.
            // vende entre 101 y 300 litros, el descuento es del 10%.
            // vende entre 301 y 500 litros, el descuento es del 15%.
            //Finalmente, si la venta es de más de 500 litros, el descuento es del 25%.
            //Hacer un programa que solicite el ingreso del importe total de la venta y la cantidad de litros vendidos y calcule y emita el importe con el descuento  aplicado..





            float importe,fimporte ;
            int litros;

            Console.WriteLine("ingrese el importe ");
            importe = float.Parse(Console.ReadLine());

            Console.WriteLine("ingrese los litros ");
            litros = int.Parse(Console.ReadLine());

            if(litros > 500)
                fimporte = importe * 0.75F;

            if(litros > 300)
                fimporte = importe * 0.85F;
            
            if(litros > 100)
                fimporte = importe * 0.90F;
                
                else
                fimporte = importe;
            

            Console.WriteLine("su importe total es de :" + fimporte);
            







        }
    }
}
