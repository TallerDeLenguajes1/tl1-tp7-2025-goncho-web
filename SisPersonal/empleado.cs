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
        
        public int anioJubilarse{
            get => Math.Max(0,65 - (DateTime.Now.Year - Fingreso.Year));  // compara cual de los dos es mayor y lo devuelve
        }
        public double Salario
        {
            get
            {
                int antiguedad = DateTime.Now.Year - Fingreso.Year;
                if(DateTime.Now<Fingreso.AddYears(antiguedad)) antiguedad --;

                double adicional = 0;
                if (antiguedad <= 20) 
                {
                    adicional += Sueldo * (antiguedad * 0.01);
                }
                else
                {
                    adicional += Sueldo * 0.25;
                }
                if (cargo == Cargos.Especialista || cargo == Cargos.Ingeniero) 
                {
                    adicional += adicional * 1.5;
                }
                if (Estadocivil == 'C')     
                {
                    adicional *= 150000;
                }
                return Sueldo + adicional;
            }
        }
        public void MostrarDetalles() // Mostrar Datos
        {
            // Calcular Antiguedad
            int antiguedad = DateTime.Now.Year - Fingreso.Year;
            if(DateTime.Now<Fingreso.AddYears(antiguedad)) antiguedad --; //AddYears añade años
            // Calcular Edad
            int edad = DateTime.Now.Year - Fnacimiento.Year;
            if(DateTime.Now<Fingreso.AddYears(edad)) edad --; 

            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Apellido: {Apellido}");
            Console.WriteLine($"Fecha de Nacimiento: {Fnacimiento.ToShortDateString()} (Edad: {edad} Años)"); //formato de fecha "26/06/2025"
            Console.WriteLine($"Estado Civil: {Estadocivil}");
            Console.WriteLine($"Fecha de Ingreso: {Fingreso.ToShortDateString()} (Antiguedad: {antiguedad} Años)");
            Console.WriteLine($"Cargo: {cargo}");
            Console.WriteLine($"Sueldo Basico: ${Sueldo}");
            Console.WriteLine($"Años Para Jubilarse: {AniosJubilarse} años");
            Console.WriteLine($"Sueldo Total: ${Salario}");
            Console.WriteLine(new string('-', 40));
        }
    }


    }
    
