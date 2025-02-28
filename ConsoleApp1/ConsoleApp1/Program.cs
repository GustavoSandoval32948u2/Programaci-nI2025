namespace ConsoleApp1{}

class Program
{
    static void CalculaIngresos()
    {
        Console.Write("Ingrese su nombre: ");
        string nombre = Console.ReadLine();

        double[] ingresos = new double[3];

        for (int i = 0; i < 3; i++)
        {
            Console.Write($"Ingrese sus ingresos del mes {i + 1}: ");
            ingresos[i] = Convert.ToDouble(Console.ReadLine()); 
        }

        double suma = ingresos[0] + ingresos[1] + ingresos[2];

        double promedio = suma / 3;

        Console.WriteLine($"\nHola {nombre}, en total ganaste {suma} y el promedio es {promedio:F2}.");
    }

    static void Main()
    {
        CalculaIngresos(); 
    }
}
