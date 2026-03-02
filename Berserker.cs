using System;

namespace CIFPCarlosIII.ED.UT04.Grupo5
{
    /// <summary>
    /// Representa un guerrero especializado en ataques de furia.
    /// </summary>
    public class Berserker : Guerrero
    {
        /// <summary>
        /// Nivel de furia acumulada.
        /// </summary>
        public int furia;

        /// <summary>
        /// Inicializa un nuevo berserker con nombre.
        /// </summary>
        /// <param name="nombre">Nombre del berserker.</param>
        public Berserker(string nombre) : base(nombre)
        {
            furia = 0;
            arma = "Hacha de batalla";
            fuerza = 20;
        }

        /// <summary>
        /// Incrementa el nivel de furia del personaje.
        /// </summary>
        public void EntrarEnFuria()
        {
            furia += 30;
            Console.WriteLine(Nombre + " entra en estado de furia! Furia actual: " + furia);
        }

        /// <summary>
        /// Ejecuta un ataque devastador si tiene suficiente furia.
        /// </summary>
        public void AtaqueFurioso()
        {
            if (furia >= 50)
            {
                Console.WriteLine(Nombre + " desata un ataque furioso devastador!");
                Console.WriteLine("Daño masivo: " + (fuerza * 3 + furia));
                furia = 0;
            }
            else
            {
                Console.WriteLine("Furia insuficiente para realizar ataque furioso.");
            }
        }

        /// <summary>
        /// Muestra la información completa del personaje.
        /// </summary>
        /// <returns>Cadena con todos los datos del berserker.</returns>
        public override string MostrarInfo()
        {
            return base.MostrarInfo();
        }
    }
}