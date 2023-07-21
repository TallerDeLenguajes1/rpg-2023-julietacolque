using DatosPersonaje;
using PokemonDatos;
using APIs;

namespace Personajes
{
    public class Personaje
    {
        //clases
        Datos datos;

        public Datos Datos { get => datos; set => datos = value; }

        public Personaje InicializarAtributos(Personaje personaje)
        {
            Random random = new Random();
            //incluye el min valor pero no el max valor.
            personaje.Datos.Velocidad = random.Next(1, 11);
            personaje.Datos.Destreza = random.Next(1, 6);
            personaje.Datos.Fuerza = random.Next(1, 11);
            personaje.Datos.Nivel = random.Next(1, 11);
            personaje.Datos.Armadura = random.Next(1, 11);
            return personaje;
        }

        public Personaje InicializarInfo(Personaje personaje)
        {
            //nombre, tipo ,peso y altura
            var listaNombres = new List<Pokemon>();
            var obtener = new API();
            listaNombres = obtener.ObtenerApi();
            
            Random rnd = new Random();
          
            personaje.Datos.Nombre = listaNombres[rnd.Next(listaNombres.Count)].name;

            var pokemonInfo = obtener.ObtenerInfo(personaje.datos.Nombre);
          

            personaje.Datos.Tipo = pokemonInfo.types[rnd.Next(pokemonInfo.types.Count)].type.name;
            
            personaje.datos.Peso = pokemonInfo.weight;
            personaje.datos.Altura = pokemonInfo.height;
            personaje.Datos.FechaNacimiento = personaje.Datos.GenerarFechaNacimiento();
            personaje.Datos.Edad = personaje.Datos.CalcularEdad(personaje.Datos.FechaNacimiento);
            return personaje;
        }

    }
}