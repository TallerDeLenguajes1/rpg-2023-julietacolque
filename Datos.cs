namespace Datos
{
    public class Dato{
        private string tipo;
        private string nombre;
        private string apodo;
        DateTime fechaNacimiento;
        int edad ;

        public string Tipo { get => tipo; set => tipo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apodo { get => apodo; set => apodo = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public int Edad { get => edad; set => edad = value; }
       
    }

    
}