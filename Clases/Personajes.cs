using DatosPersonaje;

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
            string[] nombres = { "Perri", "gorda", "ragnar", "panchi", "huguito" };
            string[] Apodos = { "Invencible", "perdedor", "ganador" };
            string[] Tipos = { "Alien", "Ninja", "Robot", "Boxeador" };
            Random rnd = new Random();
            personaje.Datos.Tipo = Tipos[rnd.Next(Tipos.Length)];
            personaje.Datos.Nombre = nombres[rnd.Next(nombres.Length)];
            personaje.Datos.Apodo = Apodos[rnd.Next(Apodos.Length)];
            personaje.Datos.FechaNacimiento = personaje.Datos.GenerarFechaNacimiento();
            personaje.Datos.Edad = personaje.Datos.CalcularEdad(personaje.Datos.FechaNacimiento);
            return personaje;
        }

    }
}