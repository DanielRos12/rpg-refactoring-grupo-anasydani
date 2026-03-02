using System;

namespace CIFPCarlosIII.ED.UT04.Grupo5
{
    /// <summary>
    /// Representa un personaje de tipo Mago.
    /// Especializado en el uso de hechizos.
    /// </summary>
    public class Mago : Personaje
    {
        /// <summary>
        /// Cantidad actual de maná disponible.
        /// </summary>
        public int Mana { get; set; }

        /// <summary>
        /// Hechizo principal del mago.
        /// </summary>
        public string hechizo;

        /// <summary>
        /// Inicializa un nuevo mago con nombre.
        /// </summary>
        /// <param name="nombre">Nombre del mago.</param>
        public Mago(string nombre) : base(nombre)
        {
            this.Mana = 100;
            this.hechizo = "Bola de fuego";
        }

        /// <summary>
        /// Lanza un hechizo si dispone de suficiente maná.
        /// </summary>
        public void LanzarHechizo()
        {
            if (Mana >= 20)
            {
                Console.WriteLine(Nombre + " lanza " + hechizo + "!");
                Mana -= 20;
                Console.WriteLine("Mana restante: " + Mana);
            }
            else
            {
                Console.WriteLine("Mana insuficiente para lanzar el hechizo.");
            }
        }

        /// <summary>
        /// Recupera maná mediante meditación.
        /// </summary>
        public void Meditar()
        {
            Mana += 30;
            if (Mana > 100) Mana = 100;
            Console.WriteLine(Nombre + " medita y recupera mana. Mana actual: " + Mana);
        }
    }
}