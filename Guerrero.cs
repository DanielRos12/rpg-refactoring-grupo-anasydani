using System;

namespace CIFPCarlosIII.ED.UT04.Grupo5
{
    public class Guerrero : Personaje
    {
    public int fuerza;
    public string arma;

    public Guerrero(string nombre) : base(nombre)
    {
        fuerza = 15;
        arma = "Espada";
    }

    public void AtaquePoderoso()
    {
        Console.WriteLine(Nombre + " usa su " + arma + " para realizar un ataque poderoso!");
        Console.WriteLine("Daño infligido: " + (fuerza * 2));
    }

    public void DefenderseConEscudo()
    {
        Console.WriteLine(Nombre + " se defiende con su escudo, reduciendo el daño recibido.");
    }
    }
}