using System;

namespace TRIANGULODEPASCAL
{
    class Program
    {
        static void Main(string[] args)
        {
            int pi = 0;
            int[] arg = new int[1];
            //Se muestra un mensaje y se captura el dato ingresado desde la consola
            Console.WriteLine("Ingrese el numero de pisos: ");
            pi = Convert.ToInt16(Console.ReadLine());
            //Se declarara el primero for que va a recorrer dependiendo el dtao que se ingrese que se 
            //almacenara en pisos

            for (int i = 1; i < pi; i++)
            {
               
                //Se coloca un arreglo y una varibale i del ciclo for
                //que sera el tamaño que tendra el arreglo cada vez que 
                //el ciclo for se repita 

                int[] pal = new int[i];
                //Ciclo for que se decrementa para formar el triangulo 
                for (int j = pi; j < i; j--)
                {
                    Console.Write(" ");
                }
                //Ciclo for que genera las sumas de las cifras 
                for (int k = 0; k < pi; k++)
                {
                    //Condicion que evalua la variable del ciclo for
                    if(k == 0 || k == (i - 1))
                    {
                        pal[k] = 1;
                    }
                    else
                    {
                        //Sumamos los numeros que estan en cada pocion
                        //del arreglo para fromar el triangulo
                        pal[k] = arg[k] + arg[k - 1];
                    }
                    Console.Write("[" + pal[k] + "]");
                }
                arg = pal;
                Console.WriteLine(" ");

            }
            Console.ReadLine();
        }
    }
}
