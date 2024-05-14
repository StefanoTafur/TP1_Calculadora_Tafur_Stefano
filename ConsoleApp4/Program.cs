using System;
using System.Net.Http.Headers;

namespace Calculadora
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("-----------CALCULADORA-----------");
            Console.WriteLine("¿Necesitas trabajar con enteros o decimales?");
            Console.WriteLine("1- Enteros\n2- Decimales(Utilizar comas ',')");
            int tiponumero = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduzca el primer número:");
            object a;
            if (tiponumero == 1)
            {
                a = Convert.ToInt32(Console.ReadLine());
            }
            else
            {
                a = Convert.ToDouble(Console.ReadLine());
            }
            Console.WriteLine("Introduzca el segundo número:");
            object b;
            if (tiponumero == 1)
            {
                b = Convert.ToInt32(Console.ReadLine());
            }
            else
            {
                b = Convert.ToDouble(Console.ReadLine());
            }
            Console.WriteLine("Elija una opción:");
            Console.WriteLine("1 - Sumar\n2- Restar\n3-Multiplicar\n4-Dividir");
            int opcion = Convert.ToInt32(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    Console.WriteLine("El resultado de la suma es:\n");
                    Console.WriteLine(suma((double)a, (double)b));
                    break;
                case 2:
                    Console.WriteLine("El resultado de la resta es:\n");
                    Console.WriteLine(resta((double)a, (double)b));
                    break;
                case 3:
                    Console.WriteLine("El resultado de la multiplicacion es:\n");
                    Console.WriteLine(multiplicacion((double)a, (double)b));
                    break;
                case 4:
                    Console.WriteLine("El resultado de la division es:\n");
                    if ((int)b == 0)
                    {
                        Console.WriteLine("No se puede dividir entre cero");
                    }
                    else
                    {
                        if (tiponumero == 1)
                        {
                            Console.WriteLine(division_int((int)a, (int)b));

                        }
                        else
                        {
                            Console.WriteLine(division((double)a, (double)b));
                        }

                    }
                    break;
                default:
                    Console.WriteLine("Opción inválida.");
                    Console.ReadLine();
                    break;
            }
        }

        private static double division(double a, double b)
        {

            return a / b;
        }
        private static int division_int(int a, int b)
        {

            return a / b;
        }

        private static double multiplicacion(double a, double b)
        {
            return a * b;
        }

        private static double resta(double a, double b)
        {
            return a - b;
        }

        private static double suma(double a, double b)
        {
            return a + b;
        }
    }
}