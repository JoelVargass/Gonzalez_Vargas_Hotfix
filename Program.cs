Personaje personaje = new Personaje
{
    Nombre = "Eon",
    Vida = 67,
    Ataque = 3,
    Defensa = 10,
    Nivel = 2
};

Console.WriteLine(personaje);

public class Personaje
{
    public string Nombre {get; set;}
    public int Vida {get; set;}
    public int Ataque {get; set;}
    public int Defensa {get; set;}
    public int Nivel {get; set;}

    public override string ToString()
    {
        return $"Nombre: {Nombre}, Vida: {Vida}, Ataque: {Ataque}, Defensa: {Defensa}, Nivel: {Nivel}";
    }
}
