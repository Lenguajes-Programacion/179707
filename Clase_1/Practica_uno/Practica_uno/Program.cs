using System;

namespace Practica_uno
{
    class Program
    {
        //Variable de la clase
        static string nombre = "Daniela";

        static void Main(string[] args)

        {

            //Respondemos con el primer argumento.
            //Condición se debe cumplir todas las sentencias si utilizamos &&.
            //Condición se debe cumplir cualquiera de las sentencias si utilizamos ||.
            //Tipos de comparaciones > < == >= <= != diferente que.
            if (args[0].Length > 0 && args[0] == nombre)// true or false
            {
                Console.WriteLine($"Hello{args[0]}{args[1]}");
            }
            else
            {
                Console.WriteLine("User unauthorized");
            }
        }
    }
}
