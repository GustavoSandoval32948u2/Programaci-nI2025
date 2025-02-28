namespace ConsoleApp4
{
    class Program
    {
        static string usuarioRegistrado = "";
        static string contraseñaRegistrada = "";

        static void RegistrarUsuario()
        {
            Console.WriteLine("REGISTRO DE USUARIO");
            Console.Write("Ingrese un nombre de usuario: ");
            usuarioRegistrado = Console.ReadLine();

            Console.Write("Ingrese una contraseña: ");
            contraseñaRegistrada = Console.ReadLine();

            Console.WriteLine("Registro exitoso. Ahora puede iniciar sesión.\n");
        }

        static void IniciarSesion()
        {
            Console.WriteLine("INICIO DE SESIÓN");
            Console.Write("Ingrese su nombre de usuario: ");
            string usuarioIngresado = Console.ReadLine();

            Console.Write("Ingrese su contraseña: ");
            string contrasenaIngresada = Console.ReadLine();

            if (usuarioIngresado == usuarioRegistrado && contrasenaIngresada == contraseñaRegistrada)
            {
                Console.WriteLine("Inicio de sesión exitoso. ¡Bienvenido!");
            }
            else
            {
                Console.WriteLine("Error: El nombre de usuario o contraseña son incorrectos.");
            }
        }

        static void Main()
        {
            RegistrarUsuario();

            IniciarSesion();
        }
    }

}
