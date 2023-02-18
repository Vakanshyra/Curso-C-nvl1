using System;

namespace ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
                    //3. Una importante marca de computadoras permite elegir cierta configuración del equipo a comprar. Para ello existe la siguiente escala de precios:

                    //               i5 (1)	  i7 (2)	i9 (3)
                    //8 RAM  (1)	USD 800	 USD 900	USD 1200
                    //16 RAM (2)	USD 900	 USD 1000	USD 1400
                    //32 RAM (3)	USD 1000 USD 1400	USD 2000
                    //Además, el equipo viene con un disco que permite almacenar 500 GB de información 
                    //y que se puede ampliar a 1 TB si así lo desea, lo cual tiene un costo  adicional de USD 300. 
                    //Hacer un programa que solicite la opción de procesador, la opción de memoria  RAM,
            
            int procesador , RAM, ampliar;
            float Precio = 0;
            

            Console.WriteLine("Ingrese el procesador : ");
            procesador = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Ingrese la Ram : ");
            RAM = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese 1 si amplia a 1TB o 0 para no ampliar ");
            ampliar = int.Parse(Console.ReadLine());
            
            
            switch(procesador){
                case 1:
                    switch (RAM){
                    case 1 :
                     Precio = 800;
                     break;
                    case 2 :
                     Precio = 900;
                     break;
                    case 3 :
                     Precio = 1000;      
                     break;

                    default:
                     Console.WriteLine ("Error al ingresar datos , intente de nuevo.");
                     break;
             
                    }
                    break;
                
                case 2:
                    switch (RAM){
                    case 1 :
                     Precio = 900;
                     break;
                    case 2 :
                     Precio = 1000;
                     break;
                    case 3 :
                     Precio = 1400;      
                     break;

                    default:
                     Console.WriteLine ("Error al ingresar datos , intente de nuevo.");
                     break;            
                    }
                    break;
                case 3:
                    switch (RAM){
                    case 1 :
                     Precio = 1000;
                     break;
                    case 2 :
                     Precio = 1400;
                     break;
                    case 3 :
                     Precio = 2000;      
                     break;

                    default:
                     Console.WriteLine ("Error al ingresar datos , intente de nuevo.");
                     break;
                    }
                    break;
            }
           
            
            if (ampliar == 1 )
             Precio+= 300;
                
            
           


            Console.WriteLine("Pago es de : " + Precio);
                
            

                
            


















        }
    }
}
