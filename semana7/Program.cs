class Program
{
    static void Main(string[] args)

    {
        Console.WriteLine("Mi segundo Programa");

        Console.WriteLine("Ingrese su Nombre");
        string sNombre = Console.ReadLine();


        Console.WriteLine("Ingrese su edad");
        string sEdad = Console.ReadLine();

        Console.WriteLine("Ingrese su carrera");
        string sCarrera = Console.ReadLine();

        Console.WriteLine("Ingrese su carné");
        string sCarné = Console.ReadLine();

        Console.WriteLine("soy " + sNombre + "tengo " + sEdad + "años y estudio la carrera de" + sCarrera + "Mi numero de carné es" + sCarné);
        Console.ReadKey();
    }

}

//* segundo programa *//

class Program2
{
    static void Main(string[] args)

    {
        Console.WriteLine("Operaciones aritméticas");
            Console.WriteLine("Luis Andrade - 1135724");

        // Solicitar la cantidad en quetzales
        Console.Write("Ingrese una cantidad entre 0 y 999.99:");
        double cantidad = double.Parse(Console.ReadLine());

        // Convertir la cantidad ingresada a centavos para facilitar los cálculos
        int cantidadCentavos = (int)(cantidad * 100);

        // Calcular billetes y monedas
        int billete100 = cantidadCentavos / 10000;
        cantidadCentavos %= 10000;

        int billete50 = cantidadCentavos / 5000;
        cantidadCentavos %= 5000;

        int billete20 = cantidadCentavos / 2000;
        cantidadCentavos %= 2000;

        int billete10 = cantidadCentavos / 1000;
        cantidadCentavos %= 1000;

        int billete5 = cantidadCentavos / 500;
        cantidadCentavos %= 500;

        int moneda1Quetzal = cantidadCentavos / 100;
        cantidadCentavos %= 100;

        int moneda25Centavos = cantidadCentavos / 25;
        cantidadCentavos %= 25;

        int moneda1Centavo = cantidadCentavos;

        // Mostrar los resultados
        Console.WriteLine("\nBilletes y monedas equivalentes:");

        Console.WriteLine(billete100 + " de Q 100");
        Console.WriteLine(billete50 + " de Q 50");
        Console.WriteLine(billete20 + " de Q 20");
        Console.WriteLine(billete10 + " de Q 10");
        Console.WriteLine(billete5 + " de Q 5");
        Console.WriteLine(moneda1Quetzal + " de Q 1");
        Console.WriteLine(moneda25Centavos + " de 25 centavos");
        Console.WriteLine(moneda1Centavo + " de 1 centavo");

        Console.ReadLine(); // Esperar a que el usuario presione Enter para salir
    }

}
        


















}
