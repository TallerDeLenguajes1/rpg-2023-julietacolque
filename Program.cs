using FabricaPersonajes;
using Personajes;
using PersonajesEnJson;
using Visuales;

internal class Program
{
    private static void Main(string[] args)
    {

        var listaPersonajes = new List<Personaje>(); //listaPersonajes
        var visuales = new Visual();
        string path = "Personajes.json";
        int entrada, bandera = 1;

        //carga
        listaPersonajes = CargaDePersonajes(path);
        System.Console.WriteLine("-------------BIENVENIDO---------");
        while (bandera == 1)
        {
            do
            {
                visuales.Menu();
                System.Console.WriteLine("Ingrese la opcion: ");
                 entrada = int.Parse(Console.ReadLine());
                
            } while (entrada < 1 || entrada > 4);

            switch (entrada)
            {
                case 1:
                    Batalla(listaPersonajes);
                    break;
                case 3:
                    System.Console.WriteLine(".......Listado Personajes......");
                    ListarPersonajes(listaPersonajes);
                    System.Console.WriteLine("...............................");
                    break;
                case 4:
                    bandera = 0;
                    System.Console.WriteLine("ADIOS :)");
                    break;

            }
        }






    }

    public static List<Personaje> CargaDePersonajes(string path)
    {
        var fPersonajesJson = new PersonajesJson(); //guardarPersonaje, leerP, existe
        var fabrica = new FabricaDePersonajes(); //crear personajes
        var listaPersonajes = new List<Personaje>();
        //A
        if (fPersonajesJson.Existe(path) && new FileInfo(path).Length != 0)
        {
            listaPersonajes = fPersonajesJson.LeerPersonajes(path);
        }
        else
        {//B
            for (int i = 0; i < 5; i++)
            {
                listaPersonajes.Add(fabrica.CrearPersonajeAleatorio());
            }
            //guardo la lista de personajes en un json.
            fPersonajesJson.GuardarPersonajes(listaPersonajes, path);
        }
        return listaPersonajes;
    }
    public static void MostrarPersonaje(Personaje personaje)
    {
        MostrarDatos(personaje);
        MostrarCaracteristicas(personaje);
    }
    public static void MostrarDatos(Personaje personaje)
    {
        string personajeDatos = $"Nombre:{personaje.Datos.Nombre}\nTipo:{personaje.Datos.Tipo}\nAltura:{personaje.Datos.Altura}\nPeso:{personaje.Datos.Peso}\nFechaNacimiento:{personaje.Datos.FechaNacimiento.ToShortDateString()}\nEdad:{personaje.Datos.Edad}";
        System.Console.WriteLine(personajeDatos);

    }
    public static void MostrarCaracteristicas(Personaje personaje)
    {
        string personajeCar = $"Destreza:{personaje.Datos.Destreza}\nVelocidad:{personaje.Datos.Velocidad}\nFuerza:{personaje.Datos.Fuerza}\nArmadura:{personaje.Datos.Armadura}\nNivel:{personaje.Datos.Nivel}";
        System.Console.WriteLine(personajeCar);

    }

    public static void ListarPersonajes(List<Personaje> listaPersonajes)
    {
        foreach (var personaje in listaPersonajes)
        {
            MostrarPersonaje(personaje);
            System.Console.WriteLine("\n");
        }

    }

    public static int CalculadoraDeDanio(Personaje pAtaca, Personaje pDefiende)
    {
        const int Ajuste = 500;
        var random = new Random();
        int danio;
        do
        {
            var efectividad = random.Next(1, 101);
            var ataque = pAtaca.Datos.Destreza * pAtaca.Datos.Fuerza * pAtaca.Datos.Nivel;
            var defensa = pDefiende.Datos.Armadura * pDefiende.Datos.Velocidad;
            danio = (((ataque * efectividad) - defensa) / Ajuste);

        } while (danio == 0);

        return danio;

    }


    public static int Pelea(Personaje personaje1, Personaje personaje2, int turno)
    {
        int danio;
        if (personaje1.Datos.Salud <= 0) return 2;
        if (personaje2.Datos.Salud <= 0) return 1;


        if (turno == 1)
        {
            danio = CalculadoraDeDanio(personaje1, personaje2);
            personaje2.Datos.Salud = personaje2.Datos.Salud - danio;
            turno = 2;
            return Pelea(personaje1, personaje2, turno);
        }
        else
        {
            danio = CalculadoraDeDanio(personaje2, personaje1);
            personaje1.Datos.Salud = personaje1.Datos.Salud - danio;
            turno = 1;
            return Pelea(personaje1, personaje2, turno);
        }

    }


    public static void Batalla(List<Personaje> lista)
    {

        var rnd = new Random();
        var visuales = new Visual();
        int aleatorio1, aleatorio2, ganador, round = 0;

        //dos personajes aleatorios,
        while (lista.Count() >= 2)
        {
            do
            {
                aleatorio1 = rnd.Next(lista.Count());
                aleatorio2 = rnd.Next(lista.Count());

            } while (aleatorio1 == aleatorio2);


            //presentacion de la pelea
            System.Console.WriteLine($"================ROUND {round}===============");
            visuales.Versus(lista[aleatorio1], lista[aleatorio2]);
            ganador = Pelea(lista[aleatorio1], lista[aleatorio2], 1);

            if (ganador == 2)
            {
                lista[aleatorio2].Datos.Armadura += 5;
                lista[aleatorio2].Datos.Salud = 100;
                System.Console.WriteLine("#### GANADOR ####\n");
                System.Console.WriteLine(visuales.Presentacion(lista[aleatorio2]));
                lista.Remove(lista[aleatorio1]);

            }
            else
            {
                lista[aleatorio1].Datos.Armadura += 5;
                lista[aleatorio1].Datos.Salud = 100;
                System.Console.WriteLine("#### GANADOR ####\n");
                System.Console.WriteLine(visuales.Presentacion(lista[aleatorio1]));
                lista.Remove(lista[aleatorio2]);

            }
            round += 1;
            

        }
        visuales.Ganador();
        MostrarPersonaje(lista[0]);
    }
}




//ToShortDateString() quita la hora en la impresion de la fecha.
