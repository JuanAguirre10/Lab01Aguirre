namespace Lab01Aguirre
{
    internal class Usuario
    {
        public string Nombre { get; set; }
        public double Saldo { get; set; }

        public Usuario(string nombre, double saldo)
        {
            Nombre = nombre;
            Saldo = saldo;
        }

        public virtual void MostrarInformacion()
        {
            Console.WriteLine("Nombre: " + Nombre);
            Console.WriteLine("Saldo: " + Saldo);
        }
    }
}