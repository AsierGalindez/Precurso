/*
 * Escribe un programa que pida tres números al usuario y que calcule y muestre su media.
 */
using System;

namespace _17_Ejercicio_Repaso03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("escribe un número");
            string num1text;
            string num2text;
            string num3text;
            
            int num1;
            int num2;
            int num3;
            num1text = Console.ReadLine();
            Console.WriteLine("escribe otro número");
            num2text = Console.ReadLine();
            Console.WriteLine("escribe otro número");
            num3text = Console.ReadLine();
            num1 = Convert.ToInt32(num1text);
            num2 = Convert.ToInt32(num2text);
            num3 = Convert.ToInt32(num3text);

            float media = (float) (num1 + num2 + num3) / 3;

            Console.WriteLine("la media es " + media);
        }
    }
}
