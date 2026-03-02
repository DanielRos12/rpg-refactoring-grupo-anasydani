using System;
    namespace CIFPCarlosIII.ED.UT04.Grupo5
    {
        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("=== BIENVENIDO AL REINO DE LOS HÉROES ===\n");

                // Personaje genérico
                Personaje personaje = new Personaje("Héroe Genérico");
                Console.WriteLine("Se ha creado un personaje: " + personaje.Nombre);
                personaje.Atacar();
                personaje.SubirNivel();

                Console.WriteLine("\n--- Guerrero ---");
                Guerrero guerrero = new Guerrero("Guerrero Valiente");
                Console.WriteLine("Se ha creado un guerrero: " + guerrero.Nombre);
                guerrero.Atacar();
                guerrero.AtaquePoderoso();
                guerrero.DefenderseConEscudo();

                Console.WriteLine("\n--- Berserker ---");
                Berserker bers = new Berserker("Destructor");
                Console.WriteLine("Se ha creado un berserker: " + bers.Nombre);
                bers.EntrarEnFuria();
                bers.EntrarEnFuria();
                bers.AtaqueFurioso();
                Console.WriteLine("\n" + bers.MostrarInfo());

                Console.WriteLine("\n--- Mago ---");
                Mago magi = new Mago("Merlín");
                Console.WriteLine("Se ha creado un mago: " + magi.Nombre);
                magi.LanzarHechizo();
                magi.LanzarHechizo();
                magi.Meditar();
                magi.LanzarHechizo();

                Console.WriteLine("\n--- Nigromante ---");
                Nigromante nigro = new Nigromante("Señor Oscuro");
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

