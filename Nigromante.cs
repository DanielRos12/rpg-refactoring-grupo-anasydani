using System;

namespace CIFPCarlosIII.ED.UT04.Grupo5
{
    /// <summary>
    /// Representa un mago especializado en magia oscura.
    /// Puede capturar almas e invocar no-muertos.
    /// </summary>
    public class Nigromante : Mago
    {
        /// <summary>
        /// Número de almas capturadas.
        /// </summary>
        public int almasCapturadas;

        /// <summary>
        /// Inicializa un nuevo nigromante con nombre.
        /// </summary>
        /// <param name="nombre">Nombre del nigromante.</param>
        public Nigromante(string nombre) : base(nombre)
        {
            this.almasCapturadas = 0;
            this.hechizo = "Drenar vida";
            this.Mana = 120;
        }

        /// <summary>
        /// Invoca un no-muerto consumiendo maná y un alma capturada.
        /// </summary>
        public void InvocarNoMuerto()
        {
            if (Mana >= 40 && almasCapturadas >= 1)
            {
                Console.WriteLine(Nombre + " invoca un no-muerto usando un alma capturada!");
                Mana -= 40;
                almasCapturadas--;
                Console.WriteLine("Almas restantes: " + almasCapturadas);
            }
            else
            {
                Console.WriteLine("No hay suficiente mana o almas para invocar.");
            }
        }

        /// <summary>
        /// Captura el alma de un enemigo derrotado.
        /// </summary>
        public void CapturarAlma()
        {
            almasCapturadas++;
            Console.WriteLine(Nombre + " ha capturado un alma. Total: " + almasCapturadas);
        }

        /// <summary>
        /// Drena vida del enemigo para recuperarse.
        /// </summary>
        public void DrenarVida()
        {
            if (Mana >= 25)
            {
                Console.WriteLine(Nombre + " drena la vida de su enemigo!");
                Mana -= 25;
                vida += 15;
                Console.WriteLine("Vida recuperada. Vida actual: " + vida);
            }
        }
    }
}