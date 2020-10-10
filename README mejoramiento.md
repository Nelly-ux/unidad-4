# unidad-4


PROGRAM.CS
using System;

namespace notas
{
    class Program
    {
        static void Main(string[] args)
        {

            operaciones promedio = new operaciones();

            Console.WriteLine("Buen día estudiante!");
            Console.WriteLine("ingrese sus 4 notas para saber su promedio final");

            Console.WriteLine(promedio.suma(float.Parse(Console.ReadLine()), float.Parse(Console.ReadLine()), float.Parse(Console.ReadLine()), float.Parse(Console.ReadLine())));


            Console.ReadKey();
        }

    }
}

CLASE ÚNICA
OPERACIONES.CS
sing System;
using System.Collections.Generic;
using System.Text;

namespace notas
{
    class operaciones
    {

      public float suma(float a, float b, float c, float d )
        {

            Console.WriteLine("PROMEDIO FINAL;");
            return (a + b + c + d) / 4;

        }
    }
}



el otro año si entenderé como utilizar repositorios uwu

