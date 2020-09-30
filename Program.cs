using System;
using System.Net.Sockets;

namespace IVA
{
    class Program
    {
        static void Main(string[] args)
        {
            operaciones impuesto = new operaciones();
            muchoteexto menu = new muchoteexto();
            Console.WriteLine("la aplicación consiste en que usted ingrese su valor neto del producto");
            Console.WriteLine("y se le retorna el total con IVA a pagar");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("(solo aplicable a Guatemala con el 12% del impuesto a valor agregado)");

            menu.muchotexto();
            int x;

            Console.WriteLine("Elija su opción");
            x = int.Parse(Console.ReadLine());



            if (x == 1)
            { 
            try
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Ingrese su valor de venta:");
                Console.WriteLine(impuesto.Iva(float.Parse(Console.ReadLine()), 0.12f));


            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("ERROR! ingrese su valor de venta correctamente:");
                Console.WriteLine(impuesto.Iva(float.Parse(Console.ReadLine()), 0.12f));
            }
           
            }

            else if (x==2)
            {
                Console.ReadKey();
            }
            
        }
    }
}
