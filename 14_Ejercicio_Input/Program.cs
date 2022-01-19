/*
 * Siguiendo los dos ejemplos anteriores, escribe un programa
 * que pregunte el nombre y una vez el usuario introduzca el
 * nombre pregunte la edad. Una vez el usuario introduce la
 * edad, mostrar un saludo del formato
 *      Hola Nombre, tienes XX años.
 * en pantalla.
 */

using System;

namespace _14_Ejercicio_Input
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¿Cómo te llamas torpedo ?");
            string name;
            name = Console.ReadLine();
            Console.WriteLine("torpedo, ¿Cuantos años tienes?");
            string oldtext;
                oldtext = Console.ReadLine();
            int old;
                old = Convert.ToInt32(oldtext);
            Console.WriteLine("hola " + name + "," + " tienes " + old + " años");

        }
    }
}
