using System;

namespace CIFPCarlosIII.ED.UT04.Grupo5
{
    
public class Personaje
{
    public string Nombre { get; set; }  // encapsulado
    public int vida;
    public int nivel;

    public Personaje(string nombre)
    {
        Nombre = nombre;
        vida = 100;
        nivel = 1;
    }

    public void Atacar()
    {
        Console.WriteLine(Nombre + " realiza un ataque básico!");
    }

    public void RecibirDanio(int danio)
    {
        vida -= danio;
        Console.WriteLine(Nombre + " recibe " + danio + " de daño. Vida restante: " + vida);
    }

    public void SubirNivel()
    {
        nivel++;
        vida += 20;
        Console.WriteLine(Nombre + " ha subido al nivel " + nivel + "!");
    }
}
}