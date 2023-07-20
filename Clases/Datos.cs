namespace DatosPersonaje
{
    public class Datos
    {

        private string tipo;
        private string nombre;
        private string apodo;
        private DateTime fechaNacimiento;
        private int edad;
        private int velocidad;
        private int destreza;
        private int fuerza;
        private int nivel;
        private int armadura;
        private int salud = 100;

        public string Tipo { get => tipo; set => tipo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apodo { get => apodo; set => apodo = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public int Edad { get => edad; set => edad = value; }
        public int Velocidad { get => velocidad; set => velocidad = value; }
        public int Destreza { get => destreza; set => destreza = value; }
        public int Fuerza { get => fuerza; set => fuerza = value; }
        public int Nivel { get => nivel; set => nivel = value; }
        public int Armadura { get => armadura; set => armadura = value; }
        public int Salud { get => salud; set => salud = value; }

        public DateTime GenerarFechaNacimiento()
        {

            DateTime fechaComienzo = new DateTime(1723, 1, 1);
            //edad de personaje de 0 a 300;
            Random diasAleatorios = new Random();
            // diferencia de dias entre la fecha ingresada como comienzo a la fecha de actual.
            int rango = (DateTime.Today - fechaComienzo).Days;
            //la fecha de nacimiento sera la fecha comienzo añadiendole dias aleatorios cuyo limite es la diferencia de las fechas
            DateTime fechaNacimiento = fechaComienzo.AddDays(diasAleatorios.Next(rango));

            return fechaNacimiento;
        }

        public int CalcularEdad(DateTime fechaDeNacimiento)
        {

            //TimeSpan objeto restando dos DateTime objetos en C#.
            TimeSpan diferencia = DateTime.Today - fechaDeNacimiento;
            //convertimos a dias esa diferencia
            int diasTranscurridos = diferencia.Days;
            return (diasTranscurridos / 365);

        }
    }
}

/*
¿Qué es un TimeSpan?
Un TimeSpan objeto representa un intervalo de tiempo (duración de tiempo o tiempo transcurrido) que se mide como un número positivo o negativo de días, horas, minutos, segundos y fracciones de un segundo
*/