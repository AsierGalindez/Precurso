/*
 * Escribe un programa que pida un número de minutos y muestre cuantos años y días son.
 */
using System;

namespace _20_Ejercicio_Repaso06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("dime minutos");
            string minText;
            int min, horas, días, días2, años;
            minText = Console.ReadLine();
            min = Convert.ToInt32(minText);
            horas = min / 60;
            días = horas / 24;
            años = días / 365;
            días2 = días % 365;
            Console.WriteLine(años + " años y " + días2 + " días");
        }
    }
}
