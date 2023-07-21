namespace PokemonDatos
{
     public class Pokemon
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class PokemonApi
    {
        public int count { get; set; }
        public string next { get; set; }
        public object previous { get; set; }
        public List<Pokemon> results { get; set; }
    }

     public class PokemonInfo
    {
        public List<object> abilities { get; set; }
        public int base_experience { get; set; }
        public List<object> forms { get; set; }
        public List<object> game_indices { get; set; }
        public int height { get; set; }
        public List<object> held_items { get; set; }
        public int id { get; set; }
        public bool is_default { get; set; }
        public string location_area_encounters { get; set; }
        public List<object> moves { get; set; }
        public string name { get; set; }
        public int order { get; set; }
        public List<object> past_types { get; set; }
        public Species species { get; set; }
        public Sprites sprites { get; set; }
        public List<Stat> stats { get; set; }
        public List<Type> types { get; set; }
        public int weight { get; set; }
    }

    public class Species
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class Sprites
    {
    }

    public class Stat
    {
        public int base_stat { get; set; }
        public int effort { get; set; }
        public Stat stat { get; set; }
    }

    public class Stat2
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class Type
    {
        public int slot { get; set; }
        public Type2 type { get; set; }
    }

    public class Type2
    {
        public string name { get; set; }
        public string url { get; set; }
    }

}
   