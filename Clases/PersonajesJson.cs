using Personajes;
using System.Text.Json;


namespace PersonajesEnJson
{
    public class PersonajesJson
    {


        public void GuardarPersonajes(List<Personaje> ListaPersonajes, string path)
        {

            string personajesJson = JsonSerializer.Serialize(ListaPersonajes);

            using (FileStream file = new FileStream(path, FileMode.Create))
            {
                using (var streamW = new StreamWriter(file))
                {
                    streamW.WriteLine(personajesJson);
                    streamW.Close();
                    file.Close();
                }
            }




        }

        public List<Personaje> LeerPersonajes(string path)
        {
            //deserealizo lo guardo en un string
            string personajes;

            using (FileStream aperturaDArchivo = new FileStream(path,FileMode.Open))
            {
                using (StreamReader lecturaDArchivo= new StreamReader(aperturaDArchivo))
                {
                    personajes = lecturaDArchivo.ReadToEnd();
                    aperturaDArchivo.Close();
                }
            }
            //deserealizo el string personajes, y lo coloco en una lista
            var ListadoPersonajes = JsonSerializer.Deserialize<List<Personaje>>(personajes);
            return ListadoPersonajes;
            
        }

        private Boolean Existe(string path)
        {
            return (File.Exists(path));

        }
    }
}

/* FUNCION GUARDAR PERSONAJES
serializar la lista en json.
Poner el listado de personajes en un string con formato json
A ese string en formato json debo colocarlo en un archivo.
*/
/*FUNCION LEER PERSONAJES:
recibe un archivo json,
abrir rl archivo
uso streamReader para leer hasta el final
eso lo guardo en un string lo cierro al archivo
 
 luego a eso 
convertirlo en una lista
var listadoAlumnosRecuperado = JsonSerializer.Deserialize<List<Alumno>>(jsonDocument);

*/