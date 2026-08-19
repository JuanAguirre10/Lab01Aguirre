using System.Collections.Generic;

namespace Lab01Aguirre
{
    internal class Grifo
    {
        public List<Usuario> Usuarios { get; set; }

        public Grifo()
        {
            Usuarios = new List<Usuario>();
        }

        public void AgregarUsuario(Usuario usuario)
        {
            Usuarios.Add(usuario);
        }

        public void MostrarUsuarios()
        {
            if (Usuarios.Count == 0)
            {
                Console.WriteLine("No hay usuarios registrados.");
                return;
            }

            Console.WriteLine("===== LISTA DE USUARIOS =====");

            for (int i = 0; i < Usuarios.Count; i++)
            {
                Console.WriteLine("--- Usuario #" + (i + 1) + " ---");
                Usuarios[i].MostrarInformacion();
                Console.WriteLine();
            }
        }
    }
}