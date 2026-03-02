using System;

namespace CIFPCarlosIII.ED.UT04.Grupo5
{
    /// <summary>
    /// Representa un personaje base del juego.
    /// Contiene atributos y comportamientos comunes a todas las clases.
    /// </summary>
    public class Personaje
    {
        /// <summary>
        /// Nombre del personaje.
        /// </summary>
        public string Nombre { get; set; }

        /// <summary>
        /// Vida actual del personaje.
        /// </summary>
        public int vida;

        /// <summary>
        /// Nivel actual del personaje.
        /// </summary>
        public int nivel;

        /// <summary>
        /// Inicializa un nuevo personaje con nombre.
        /// </summary>
        /// <param name="nombre">Nombre del personaje.</param>
        public Personaje(string nombre)
        {
            Nombre = nombre;
            vida = 100;
            nivel = 1;
        }

        /// <summary>
        /// Realiza un ataque básico.
        /// </summary>
        public void Atacar()
        {
            Console.WriteLine(Nombre + " realiza un ataque básico!");
        }

        /// <summary>
        /// Reduce la vida del personaje según el daño recibido.
        /// </summary>
        /// <param name="danio">Cantidad de daño recibido.</param>
        public void RecibirDanio(int danio)
        {
            vida -= danio;
            Console.WriteLine(Nombre + " recibe " + danio + " de daño. Vida restante: " + vida);
        }

        /// <summary>
        /// Incrementa el nivel del personaje y aumenta su vida.
        /// </summary>
        public void SubirNivel()
        {
            nivel++;
            vida += 20;
            Console.WriteLine(Nombre + " ha subido al nivel " + nivel + "!");
        }
    }
}