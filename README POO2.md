# unidad-4

hola mundo!  buen comienzo lo se 
este programa  hace calculos básicos, en el incluí  POO, HERENCIA, INSTANCIAS 

PROGRAM.CS
using System;

namespace calculoss
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CALCULOS: ");
            Console.WriteLine("1. SUMA");
            Console.WriteLine("2. RESTA");
            Console.WriteLine("3. MULTIPLICACION");
            Console.WriteLine("4. DIVISION");
            Console.WriteLine("5. SALIR");

            Console.WriteLine("Elija una opción");

           int x = int.Parse(Console.ReadLine());

            operaciones calcu = new operaciones();


           

            while (x<5)
            {
                if (x == 1)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Ingrese sus valores:");

                    try
                    {
                        Console.WriteLine(calcu.suma(float.Parse(Console.ReadLine()), float.Parse(Console.ReadLine())));
                    }
                    catch
                    {
                        Console.WriteLine("¡ERROR! ingrese sus valores de nuevo");
                        Console.WriteLine(calcu.suma(float.Parse(Console.ReadLine()), float.Parse(Console.ReadLine())));
                    }

                }

                if (x == 2)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Ingrese sus valores:");

                    try
                    {
                        Console.WriteLine(calcu.resta(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine())));
                    }
                    catch
                    {
                        Console.WriteLine("¡ERROR! ingrese sus valores de nuevo");
                        Console.WriteLine(calcu.resta(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine())));
                    }
                }
                if (x == 3)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Ingrese sus valores:");

                    try
                    {
                        Console.WriteLine(calcu.multi(float.Parse(Console.ReadLine()), float.Parse(Console.ReadLine())));
                    }
                    catch
                    {
                        Console.WriteLine("¡ERROR! ingrese sus valores de nuevo");
                        Console.WriteLine(calcu.multi(float.Parse(Console.ReadLine()), float.Parse(Console.ReadLine())));
                    }
                }
                if (x == 4)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Ingrese sus valores:");

                    try
                    {
                        Console.WriteLine(calcu.div(float.Parse(Console.ReadLine()), float.Parse(Console.ReadLine())));
                    }
                    catch
                    {
                        Console.WriteLine("¡ERROR! ingrese sus valores de nuevo");
                        Console.WriteLine(calcu.div(float.Parse(Console.ReadLine()), float.Parse(Console.ReadLine())));
                    }
                }
            }
        }
    }
}

OPERACIONES.CS

using System;
using System.Collections.Generic;
using System.Text;

namespace calculoss
{
    class operaciones
    {
        public float suma(float a, float b)
        {
           
            return a + b;
        }

        public double resta(double a, double b)
        {
            return a - b;
        }

        public float multi(float a, float b)
        {
            return a * b;
        }

        public float div(float a, float b)
        {
            return a / b;
        }

    }
}



