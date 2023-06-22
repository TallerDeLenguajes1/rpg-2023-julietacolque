using Caracteristicas;
using Datos;

namespace Personajes
{
    public class Personaje
    {
        //clases
        Dato datos;
        Caracteristica caracteristicas;

        public Dato Datos { get => datos; set => datos = value; }
        public Caracteristica Caracteristicas { get => caracteristicas; set => caracteristicas = value; }


        public Personaje InicializarCaracteristicas(Personaje personaje)
        {
            Random random = new Random();
            //incluye el min valor pero no el max valor.
            personaje.Caracteristicas.Velocidad = random.Next(1, 11);
            personaje.Caracteristicas.Destreza = random.Next(1, 6);
            personaje.Caracteristicas.Fuerza = random.Next(1, 11);
            personaje.Caracteristicas.Nivel = random.Next(1, 11);
            personaje.Caracteristicas.Armadura = random.Next(1, 11);
            return personaje;
        }

        public Personaje InicializarDatos(Personaje personaje)
        {
            string[] nombres = { "Perri", "gorda", "ragnar", "panchi", "huguito" };
            string[] Apodos = { "Invencible", "perdedor", "ganador" };
            string[] Tipos = { "Alien", "Ninja", "Robot", "Boxeador" };
            Random rnd = new Random();
            personaje.Datos.Tipo = Tipos[rnd.Next(Tipos.Length)];
            personaje.Datos.Nombre = nombres[rnd.Next(nombres.Length)];
            personaje.Datos.Apodo = Apodos[rnd.Next(Apodos.Length)];
            personaje.datos.FechaNacimiento = personaje.datos.GenerarFechaNacimiento();
            personaje.datos.Edad = personaje.datos.CalcularEdad(personaje.datos.FechaNacimiento);
            return personaje;
        }

    }
}