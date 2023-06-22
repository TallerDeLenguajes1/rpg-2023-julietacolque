namespace Datos
{
    public class Dato
    {
        private string tipo;
        private string nombre;
        private string apodo;
        DateTime fechaNacimiento;
        int edad;



        public string Tipo { get => tipo; set => tipo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apodo { get => apodo; set => apodo = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public int Edad { get => edad; set => edad = value; }

        public DateTime GenerarFechaNacimiento()
        {

            DateTime fechaComienzo = new DateTime(1723, 1,1 );
            //edad de personaje de 0 a 300;
            Random diasAleatorios = new Random();
            // diferencia de dias entre la fecha ingresada como comienzo a la fecha de actual.
            int rango = (DateTime.Today - fechaComienzo).Days;
            //la fecha de nacimiento sera la fecha comienzo añadiendole dias aleatorios cuyo limite es la diferencia de las fechas
            DateTime fechaNacimiento = fechaComienzo.AddDays(diasAleatorios.Next(rango));

            return fechaNacimiento;
        }

        public int CalcularEdad(DateTime fechaDeNacimiento){

            //TimeSpan objeto restando dos DateTime objetos en C#.
            TimeSpan diferencia = DateTime.Today - fechaDeNacimiento;
            //convertimos a dias esa diferencia
            int diasTranscurridos = diferencia.Days;
            return (diasTranscurridos/365);

        }

    }


}

/*
¿Qué es un TimeSpan?
Un TimeSpan objeto representa un intervalo de tiempo (duración de tiempo o tiempo transcurrido) que se mide como un número positivo o negativo de días, horas, minutos, segundos y fracciones de un segundo
*/