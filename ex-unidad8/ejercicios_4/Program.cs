using System;

namespace ejercicios_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //4. Hacer una función de tipo void (porque no va a devolver nada) llamada “positivoNegativoCero” que reciba un número por valor y una variable por referencia. Que analice el número y escriba variable recibida por referencia con:
            // a. 1 si el número es positivo.
            // b. -1 si el número es negativo.
            // c. 0 si el número es cero.


            // int n1,n2=0;
            // Console.WriteLine("ingrese su nùmero : ");
            // n1 = int.Parse(Console.ReadLine());

            // positivonegativocero(n1 ,ref n2);

            // Console.WriteLine("sunumero es : " + n2);

            int r, a=10,b= 5, c=5;

            r = a+b/c;
            Console.WriteLine(r);




        }
        static void positivonegativocero(int a , ref int b)
        {
            if (a>0)
            {
                b=1;
            }else if (a<0)
            {
                b=-1;
            }else
            {
                b=0;
            }
        }
    }
}
