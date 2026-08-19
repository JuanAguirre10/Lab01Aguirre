namespace Lab01Aguirre
{
    internal class Empleado : Usuario
    {
        public double Sueldo { get; set; }

        public Empleado(string nombre, double saldo, double sueldo)
            : base(nombre, saldo)
        {
            Sueldo = sueldo;
        }

        public override void MostrarInformacion()
        {
            Console.WriteLine("Tipo: Empleado");
            base.MostrarInformacion();
            Console.WriteLine("Sueldo: " + Sueldo);
        }
    }
}