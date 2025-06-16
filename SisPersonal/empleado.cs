namespace Empleados
{
    public class Empleado{
        private string nombre;
        private string apellido;
        private DateTime fNacimiento;
        private char eCivil;
        private DateTime fIngreso;
        private double sueldo;
        
         public string Nombre
        {
            get => nombre;
            set => nombre = value;
        }
        public string Apellido
        {
            get => apellido;
            set => apellido = value;
        }
        public DateTime Fnacimiento
        {
            get => fnacimiento;
            set => fnacimiento = value;
        }
        public DateTime Fingreso
        {
            get => fingreso;
            set => fingreso = value;
        }

        public double Sueldo
        {
            get => sueldo;
            set => sueldo = value;
        }
        public char? Estadocivil
        {
            get => estadocivil;
            set => estadocivil = value;
        }
        public Cargos Cargo
        {
            get => cargo;
            set => cargo = value;
        }
        public enum cargo{
            Auxiliar,
            Administrativo,
            Ingeniero,
            Especialista,
            Investigador
        }

        public Empleado(string nombre, string apellido, DateTime fNacimiento, char eCivil, DateTime fIngreso, double sueldo, cargo cargos){

            this.nombre = nombre;
            this.apellido = apellido;
            this.fNacimiento = fNacimiento;
            this.eCivil = eCivil;
            this.fIngreso = fIngreso;
            this.sueldo = sueldo;
            this.cargos = cargos;
        }


    }
    
}