using FabricaPersonajes;
using Personajes;
using PersonajesEnJson;

internal class Program
{
    private static void Main(string[] args)
    {
        var fPersonajesJson = new PersonajesJson(); //guardarPersonaje, leerP, existe
        var fabrica = new FabricaDePersonajes(); //crear personajes
        var listaPersonajes = new List<Personaje>(); //listaPersonajes
        string path = "Personajes.json";


        //A
        if (fPersonajesJson.Existe(path) && new FileInfo(path).Length != 0)
        {
            Console.WriteLine("El archivo exite y tiene elementos");
            listaPersonajes = fPersonajesJson.LeerPersonajes(path);
        }
        else
        {//B
            for (int i = 0; i < 10; i++)
            {
                listaPersonajes.Add(fabrica.CrearPersonajeAleatorio()); 
            }
            //guardo la lista de personajes en un json.
            fPersonajesJson.GuardarPersonajes(listaPersonajes,path);
        }

        //mostrar Personajes 
        foreach (var personaje in listaPersonajes)
        {
            MostrarPersonaje(personaje);
            System.Console.WriteLine("\n");
        }
    }

    public static void MostrarPersonaje(Personaje personaje)
    {
        string personajeDatos = $"Nombre:{personaje.Datos.Nombre}\nTipo:{personaje.Datos.Tipo}\nApodo:{personaje.Datos.Apodo}\nFechaNacimiento:{personaje.Datos.FechaNacimiento.ToShortDateString()}\nEdad:{personaje.Datos.Edad}";
        System.Console.WriteLine(personajeDatos);
    }
}

//ToShortDateString() quita la hora en la impresion de la fecha.
