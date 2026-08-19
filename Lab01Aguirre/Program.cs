namespace Lab01Aguirre
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Grifo grifo = new Grifo();
            grifo.AgregarUsuario(new Cliente("Juan Perez", 50.0, 12.5));
            grifo.AgregarUsuario(new Cliente("Maria Lopez", 80.0, 30.0));
            grifo.AgregarUsuario(new Empleado("Ana Torres", 100.0, 2500.0));
            grifo.AgregarUsuario(new Empleado("Carlos Diaz", 60.0, 1800.0));
            bool salir = false;

            while (!salir)
            {
                Console.WriteLine("===== GRIFO - MENU =====");
                Console.WriteLine("1. Mostrar informacion de usuarios");
                Console.WriteLine("2. Agregar cliente");
                Console.WriteLine("3. Agregar empleado");
                Console.WriteLine("4. Salir");
                Console.Write("Seleccione una opcion: ");

                string opcion = Console.ReadLine() ?? "";
                Console.WriteLine();

                switch (opcion)
                {
                    case "1":
                        grifo.MostrarUsuarios();
                        break;

                    case "2":
                        Console.Write("Nombre del cliente: ");
                        string nombreCliente = Console.ReadLine() ?? "";

                        Console.Write("Saldo: ");
                        double saldoCliente = double.Parse(Console.ReadLine() ?? "0");

                        Console.Write("Litros cargados: ");
                        double litros = double.Parse(Console.ReadLine() ?? "0");

                        grifo.AgregarUsuario(new Cliente(nombreCliente, saldoCliente, litros));
                        Console.WriteLine("Cliente agregado correctamente.");
                        break;

                    case "3":
                        Console.Write("Nombre del empleado: ");
                        string nombreEmpleado = Console.ReadLine() ?? "";

                        Console.Write("Saldo: ");
                        double saldoEmpleado = double.Parse(Console.ReadLine() ?? "0");

                        Console.Write("Sueldo: ");
                        double sueldo = double.Parse(Console.ReadLine() ?? "0");

                        grifo.AgregarUsuario(new Empleado(nombreEmpleado, saldoEmpleado, sueldo));
                        Console.WriteLine("Empleado agregado correctamente.");
                        break;

                    case "4":
                        salir = true;
                        Console.WriteLine("Saliendo del sistema...");
                        break;

                    default:
                        Console.WriteLine("Opcion no valida. Intente nuevamente.");
                        break;
                }

                Console.WriteLine();
            }
        }
    }
}