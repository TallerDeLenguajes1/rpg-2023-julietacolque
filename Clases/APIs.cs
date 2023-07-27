using System.Net;
using PokemonDatos;
using System.Text.Json;
namespace APIs
{
    public class API
    {

        public List<Pokemon> ObtenerApi()
        {
            var pokemon = new Pokemon();
            var lista = new List<Pokemon>();
            var url = $"https://pokeapi.co/api/v2/pokemon/?limit=20";
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.ContentType = "application/json";
            request.Accept = "application/json";

            try
            {
                using (WebResponse response = request.GetResponse())
                {

                    using (Stream strReader = response.GetResponseStream())
                    {
                        if (strReader == null) return lista;
                        using (StreamReader objReader = new StreamReader(strReader))
                        {
                            string responseBody = objReader.ReadToEnd();

                            //convierto la respuesta en una clase PokemonApi
                            var convertir = JsonSerializer.Deserialize<PokemonApi>(responseBody);

                            //la parte que tiene el nombre de los pokemones esta en results
                            // System.Console.WriteLine(convertir.next);
                            // System.Console.WriteLine(convertir.count);
                            //  System.Console.WriteLine(convertir.previous);
                            //  foreach (var item in convertir.results)
                            //  {
                            //   System.Console.WriteLine(item.name);  
                            //  }
                            //  System.Console.WriteLine(convertir.results);

                            return convertir.results;


                        }
                    }
                }
            }
            catch (WebException)
            {
                Console.WriteLine("Problemas de acceso a la API");
                return lista;
            }
        }


        public PokemonInfo ObtenerInfo(string nombre)
        {
            var info = new PokemonInfo();
            var url = $"https://pokeapi.co/api/v2/pokemon/{nombre}/";
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.ContentType = "application/json";
            request.Accept = "application/json";

            try
            {
                using (WebResponse response = request.GetResponse())
                {

                    using (Stream strReader = response.GetResponseStream())
                    {
                        if (strReader == null) return info;
                        using (StreamReader objReader = new StreamReader(strReader))
                        {
                            string responseBody = objReader.ReadToEnd();

                            //convierto la respuesta en una clase
                            info = JsonSerializer.Deserialize<PokemonInfo>(responseBody);
                            return info;


                        }
                    }
                }
            }
            catch (WebException)
            {
                Console.WriteLine("Problemas de acceso a la API");
                return info;
            }
        }
    }


}
