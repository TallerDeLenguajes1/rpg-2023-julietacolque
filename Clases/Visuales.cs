using Personajes;
namespace Visuales
{
    public class Visual
    {

        public string Presentacion(Personaje per)
        {
            string titulo = $"---------{per.Datos.Nombre}---------";
            string des = $"| Destreza:{per.Datos.Destreza}    ";
            string fuer = $"| Fuerza:{per.Datos.Fuerza}    ";
            string nivel = $"| Nivel: {per.Datos.Nivel}    ";
            string arm = $"| Armadura:{per.Datos.Armadura}    ";
            string salud = $"| Salud: {per.Datos.Salud}    ";

            string carta = $"\n{titulo}\n{des}\n{fuer}\n{nivel}\n{arm}\n{salud}\n";
            return carta;
        }

        public void Versus(Personaje per1, Personaje per2)
        {
            string versus = Presentacion(per1) + "<<<<<<<<<<VERSUS>>>>>>>>>" + Presentacion(per2);
            System.Console.WriteLine(versus);
        }


        public void Ganador()
        {
            string c1 = @"\*) \*)  \*/  (*/ (*/";
            string c2 = @" \*\_\*\_|O|_/*/_/*/";
            string c3 = @"  \_______________/";
            string corona = $"{c1}\n{c2}\n{c3}\n";
            System.Console.WriteLine(corona);
        }
        public void Menu(){
                System.Console.WriteLine($"********MENU********\n1-Simulacion de pelea\n2-Crear tu Personaje\n3-Listar Personajes\n4-Salir");
        }
    }
}