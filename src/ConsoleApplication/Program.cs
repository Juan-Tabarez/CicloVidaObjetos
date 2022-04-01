//--------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

using System;
using ClassLibrary;

namespace ConsoleApplication
{
    /// <summary>
    /// Programa de consola de demostración.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// Punto de entrada al programa principal.
        /// </summary>
        public static void Main()
        {   for (int i = 1 ; i <= 10000000; i++) 
            {
            var train = new Train(Convert.ToString(i));
            }
            Console.WriteLine(Train.count);
            
            //Cuando creamos 10.000.000 de instancias se empeizan a liberar automaticamente ya que son muchas y el sistema detecta que no se van a usar

            var t1 = new Train("Last Train To London");
            var t2 = new Train("Last Train To London");
            var t3 = new Train("Runaway Train");

            Console.WriteLine($"{t1==t2} {t2 == t3}"); 
            
            //Ninguno de los tres es igual a otro ya que aunque tengan el mismo id, son instancias diferentes           
        }
    }
}