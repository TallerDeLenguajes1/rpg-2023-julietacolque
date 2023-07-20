using Personajes;
using DatosPersonaje;
namespace FabricaPersonajes
{
    public class FabricaDePersonajes
    {
       

        private Personaje InicializarPersonaje()
        {
            Personaje personaje = new Personaje();
            personaje.Datos = new Datos();
            return personaje;
        }  

       public Personaje CrearPersonajeAleatorio()
        {
            Personaje personaje = InicializarPersonaje();
            personaje.InicializarInfo(personaje);
            personaje.InicializarAtributos(personaje);

            return personaje;
        }

    
    }
}

// //Debe tener un método que retorne un personaje con sus respetivos
// datos y características cargadas.
