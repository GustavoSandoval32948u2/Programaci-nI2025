namespace ConsoleApp3
{
    class Program
    {
        static void SumarNumeros()
        {
            try
            {
                Console.Write("Ingrese el primer número: ");
                int num1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Ingrese el segundo número: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                int resultado = num1 + num2;

                Console.WriteLine($"La suma de {num1} + {num2} es: {resultado}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Debe ingresar solo números enteros.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error inesperado: {ex.Message}");
            }
            finally
            {

                Console.WriteLine("Fin del intento de suma.");
            }
        }

        static void Main()
        {
            SumarNumeros();
        }
    }

}
