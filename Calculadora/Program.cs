using EspacioCalculadora;

Calculadora calc1 = new Calculadora();

int opcion;
string strOpcion;
double num = 0;
string strNum = "";
Console.WriteLine("-- Calculadora --");
do
{
    Console.WriteLine("Que operacion desea Realizar");
    Console.WriteLine("1. Sumar\n2. Resta\n3. Multiplicacion\n4. Dividir\n0. Salir");
    strOpcion = Console.ReadLine(); 
    int.TryParse(strOpcion, out opcion);
    switch (opcion)
    {
        case 1:
            Console.WriteLine("Escriba un numero para sumar: ");
            strNum = Console.ReadLine();
            double.TryParse(strNum, out num);
            calc1.Sumar(num);
            Console.WriteLine($"El numero es: {calc1.Resultado}");
        break;
        case 2:
            Console.WriteLine("Escriba un numero para Restar: ");
            strNum = Console.ReadLine();
            double.TryParse(strNum, out num);
            calc1.Restar(num);
            Console.WriteLine($"El numero es: {calc1.Resultado}");
        break;
        case 3:
            Console.WriteLine("Escriba un numero para Multiplicar: ");
            strNum = Console.ReadLine();
            double.TryParse(strNum, out num);
            calc1.Multiplicar(num);
            Console.WriteLine($"El numero es: {calc1.Resultado}");
        break;
        case 4:
            Console.WriteLine("Escriba un numero para Dividir: ");
            strNum = Console.ReadLine();
            double.TryParse(strNum, out num);
            calc1.Dividir(num);
            Console.WriteLine($"El numero es: {calc1.Resultado}");
        break;
        default:
            opcion = 0;
            calc1.Limpiar();
        break;
    }
} while (opcion != 0);

