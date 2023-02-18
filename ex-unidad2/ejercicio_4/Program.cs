using System;

namespace ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {

         //4. Una casa de computación paga a sus empleados un sueldo fijo de ARS15000 más una
         // comisión del 5% sobre el total facturado por cada empleado. Hacer un programa para ingresar el total facturado por un
         // empleado y que luego calcule y emita por pantalla el sueldo total a cobrar por el mismo.

            float sueldo_fijo = 15000;
            float total_facturado , comision= 0.05F;
            float Sueldo_Total;
            
            

            Console.WriteLine("ingrese el total facturado : ");
            total_facturado = float.Parse(Console.ReadLine());

            Sueldo_Total = (total_facturado * comision ) + sueldo_fijo ;
            Console.WriteLine("su sueldo total a cobrar es de : " + Sueldo_Total) ;

     




















            

            



        }
    }
}
