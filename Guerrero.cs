using System;

namespace CIFPCarlosIII.ED.UT04.Grupo5
{
    /// <summary>
    /// Representa un personaje de tipo Guerrero.
    /// Especializado en combate físico.
    /// </summary>
    public class Guerrero : Personaje
    {
        /// <summary>
        /// Fuerza del guerrero.
        /// </summary>
        public int fuerza;

        /// <summary>
        /// Arma equipada por el guerrero.
        /// </summary>
        public string arma;

        /// <summary>
        /// Inicializa un nuevo guerrero con nombre.
        /// </summary>
        /// <param name="nombre">Nombre del guerrero.</param>
        public Guerrero(string nombre) : base(nombre)
        {
            fuerza = 15;
            arma = "Espada";
        }

        /// <summary>
        /// Ejecuta un ataque más potente que el básico.
        /// </summary>
        public void AtaquePoderoso()
        {
            Console.WriteLine(Nombre + " usa su " + arma + " para realizar un ataque poderoso!");
            Console.WriteLine("Daño infligido: " + (fuerza * 2));
        }

        /// <summary>
        /// Permite al guerrero defenderse reduciendo el daño recibido.
        /// </summary>
        public void DefenderseConEscudo()
        {
            Console.WriteLine(Nombre + " se defiende con su escudo, reduciendo el daño recibido.");
        }
    }
}