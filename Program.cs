using FabricaPersonajes;
using Personajes;
internal class Program
{
    private static void Main(string[] args)
    {
        var person1 = new FabricaDePersonajes().CrearPersonajeAleatorio();

        var ListaPersonajes = new List<Personaje>();

        ListaPersonajes.Add(person1);
        //   
        foreach (var personaje in ListaPersonajes)
        {
            MostrarPersonaje(personaje);
        }
    }

    public static void MostrarPersonaje(Personaje personaje)
    {
        string personajeDatos = $"Nombre:{personaje.Datos.Nombre}\nTipo:{personaje.Datos.Tipo}\nApodo:{personaje.Datos.Apodo}\nFechaNacimiento:{personaje.Datos.FechaNacimiento.ToShortDateString()}\nEdad:{personaje.Datos.Edad}";
        System.Console.WriteLine(personajeDatos);
    }
}

//ToShortDateString() quita la hora en la impresion de la fecha.
