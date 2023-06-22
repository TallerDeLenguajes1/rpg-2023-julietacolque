//plural espacio de nombre 
//singular clase
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
    }
}