using Personajes;
using Caracteristicas;
using Datos;

namespace FabricaPersonajes
{
    public class FabricaDePersonajes
    {
        private Personaje personaje;

        public Personaje Personaje { get => personaje; set => personaje = value; }

        private Personaje InicializarPersonaje()
        {
            Personaje personaje = new Personaje();
            personaje.Caracteristicas = new Caracteristica();
            personaje.Datos = new Dato();
            return personaje;
        }  

       public Personaje CrearPersonajeAleatorio()
        {
            Personaje personaje = InicializarPersonaje();
            personaje.InicializarDatos(personaje);
            personaje.InicializarCaracteristicas(personaje);

            return personaje;
        }

    
    }
}

// //Debe tener un método que retorne un personaje con sus respetivos
// datos y características cargadas.
