using System;
using CIFPCarlosIII.ED.UT04.Grupo5;

namespace CIFPCarlosIII.ED.UT04.Grupo5
{
    
public class Berserker : Guerrero
{
    public int furia;

    public Berserker(string nombre) : base(nombre)
    {
        furia = 0;
        arma = "Hacha de batalla";
        fuerza = 20;
    }

    public void EntrarEnFuria()
    {
        furia += 30;
        Console.WriteLine(Nombre + " entra en estado de furia! Furia actual: " + furia);
    }

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

    public string MostrarInfo()
    {
        return "=== INFORMACIÓN DEL PERSONAJE ===" +
               "\nNombre: " + Nombre +
               "\nClase: " + GetType().Name +
               "\nNivel: " + nivel +
               "\nVida: " + vida +
               "\nFuerza: " + fuerza +
               "\nArma: " + arma +
               "\nFuria: " + furia;
    }
}
}