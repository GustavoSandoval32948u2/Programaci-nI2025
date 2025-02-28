namespace ConsoleApp2
{
    class Calculadora
    {
        public static int Suma(int a, int b)
        {
            return a + b;
        }

        public static int Resta(int a, int b)
        {
            return a - b;
        }

        public static int Multiplicar(int a, int b)
        {
            return a * b;
        }

        public static int Dividir(int a, int b)
        {
            return a / b;
        }
    }

    class Program
    {
        static void Main()
        {
            Console.Write("Ingrese el primer número: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese el segundo número: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"\nSuma: {Calculadora.Suma(num1, num2)}");
            Console.WriteLine($"Resta: {Calculadora.Resta(num1, num2)}");
            Console.WriteLine($"Multiplicación: {Calculadora.Multiplicar(num1, num2)}");
            Console.WriteLine($"División: {Calculadora.Dividir(num1, num2)}");
        }
    }

}

