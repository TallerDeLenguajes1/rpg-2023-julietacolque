using Personajes;
using Datos;
using Caracteristicas;
internal class Program
{
    private static void Main(string[] args)
    {
        Personaje personaje1 = new Personaje();
        
        personaje1.Datos = new Dato();
        personaje1.Caracteristicas = new Caracteristica();
        personaje1.Datos.Apodo = "pepito";
        personaje1.Caracteristicas.Destreza = 100;
        Console.WriteLine("Apodo: " + personaje1.Datos.Apodo);
        Console.WriteLine("Destreza: " + personaje1.Caracteristicas.Destreza);
    }
}