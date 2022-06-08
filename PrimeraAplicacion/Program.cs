using System;

namespace PrimeraAplicacion{
    class Program
    {
        static void Main(string[] args)
        {
            const double PI = 3.1416;
            Console.WriteLine("Introduce la medida del radio");
            double radio = double.Parse(Console.ReadLine());
            double area = Math.Pow(radio, 2)*PI;

            Console.WriteLine($"El área del circulo es: {area}");

        }

        int sumaNumeros()
        {
            int num1 = 7;
            int num2 = 9;

            int result = num1 + num2;

            return result;
        }

        int sumarNumeros(int num1, int num2)
        {
            int resultado = num1 + num2;
            return resultado;
        }

        void sumarNumeros()
        {
            int num1 = 7;
            int num2 = 9;

            int resultado = num1 + num2;

            Console.WriteLine(resultado);
        }
    }
}
