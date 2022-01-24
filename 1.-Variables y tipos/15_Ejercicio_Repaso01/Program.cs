/*
 * Escribe un programa que pida dos números al usuario y muestre el resultado de sumarlos, multiplicarlos, restarlos, dividirlos y el resto de la división
 */
using System;

namespace _15_Ejercicio_Repaso01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("dame el primer número entero");
                string num1text;
            num1text = Console.ReadLine();

            int num1;
                num1 = Convert.ToInt32(num1text);
            Console.WriteLine("dame el segundo número entero");
            string num2text;
            num2text = Console.ReadLine();

            int num2;
                num2 = Convert.ToInt32(num2text);
            float division;
            int resto;
            resto = num1 % num2;
            //division =(float)num1 / num2;
            Console.WriteLine("la suma es " + (num1 + num2));
            Console.WriteLine("la resta es " + (num1 - num2));
            Console.WriteLine("la division es " + (float)num1 / num2);
            Console.WriteLine("la multiplicación es " + (num1 * num2));
            Console.WriteLine("el resto es " + resto);
        }
    }
}
