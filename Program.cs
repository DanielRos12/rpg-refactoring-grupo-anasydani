using System;

namespace CIFPCarlosIII.ED.UT04.Grupo5
{
    /// <summary>
    /// Clase principal del programa.
    /// Contiene el punto de entrada de la aplicación.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Método principal que ejecuta la demostración del sistema RPG.
        /// </summary>
        /// <param name="args">Argumentos pasados por línea de comandos.</param>
        static void Main(string[] args)
        {
            Console.WriteLine("=== BIENVENIDO AL REINO DE LOS HÉROES ===\n");

            Personaje personaje = new Personaje("Aldric el Errante");
            Console.WriteLine("Se ha creado un personaje: " + personaje.Nombre);
            personaje.Atacar();
            personaje.SubirNivel();

            Console.WriteLine("\n--- Guerrero ---");
            Guerrero guerrero = new Guerrero("Thorin Rompeescudos");
            Console.WriteLine("Se ha creado un guerrero: " + guerrero.Nombre);
            guerrero.Atacar();
            guerrero.AtaquePoderoso();
            guerrero.DefenderseConEscudo();

            Console.WriteLine("\n--- Berserker ---");
            Berserker bers = new Berserker("Kragnar el Salvaje");
            Console.WriteLine("Se ha creado un berserker: " + bers.Nombre);
            bers.EntrarEnFuria();
            bers.EntrarEnFuria();
            bers.AtaqueFurioso();
            Console.WriteLine("\n" + bers.MostrarInfo());

            Console.WriteLine("\n--- Mago ---");
            Mago magi = new Mago("Eldrin el Sabio");
            Console.WriteLine("Se ha creado un mago: " + magi.Nombre);
            magi.LanzarHechizo();
            magi.LanzarHechizo();
            magi.Meditar();
            magi.LanzarHechizo();

            Console.WriteLine("\n--- Nigromante ---");
            Nigromante nigro = new Nigromante("Morvath el Oscuro");
            Console.WriteLine("Se ha creado un nigromante: " + nigro.Nombre);
            nigro.CapturarAlma();
            nigro.CapturarAlma();
            nigro.InvocarNoMuerto();
            nigro.DrenarVida();

            Console.WriteLine("\n=== FIN DE LA DEMOSTRACIÓN ===");
            Console.ReadLine();
        }
    }
}