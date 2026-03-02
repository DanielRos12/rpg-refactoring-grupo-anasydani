using System;

namespace CIFPCarlosIII.ED.UT04.Grupo5
{
    public class Mago : Personaje
    {
        public int Mana { get; set; }
        public string hechizo;

        public Mago(string nombre) : base(nombre)
        {
            Mana = 100;
            hechizo = "Bola de fuego";
        }

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

        public void Meditar()
        {
            Mana += 30;
            if (Mana > 100) Mana = 100;
            Console.WriteLine(Nombre + " medita y recupera mana. Mana actual: " + Mana);
        }
    }
}
