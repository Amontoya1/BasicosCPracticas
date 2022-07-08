internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        string miNombre;
        Console.WriteLine("Por favor, escriba su nombre");
        miNombre = Console.ReadLine();
        Console.WriteLine("Hola {0}", miNombre);

        Console.WriteLine("Hora y Fecha: {0}\n", DateTime.Now);
        Console.WriteLine("Solo la hora: {0}\n", DateTime.Now.ToString("h:mm:ss"));
        Console.WriteLine("Solo la Fecha: {0}\n", DateTime.Now.ToString("dd/MM/yyyy"));

        Console.ReadKey();

        byte CANB, CANH, CANP;
        double APAGAR;
        string linea;
        const double PRECIOB = 0.8;
        const double PRECIOH = 2;
        const double PRECIOP = 1.2;
        Console.Write("Cantidad de Hamburguesas :"); linea = Console.ReadLine();
        CANH = byte.Parse(linea);
        Console.Write("Cantidad de Papas:"); linea = Console.ReadLine();
        CANP = byte.Parse(linea);
        Console.Write("Cantidad de Bebidas :"); linea = Console.ReadLine();
        CANB = byte.Parse(linea);
        Console.WriteLine();
        APAGAR = CANH * PRECIOH + CANP * PRECIOP + CANB * PRECIOB;
        Console.WriteLine("Valor a Pagar: " + APAGAR);
        Console.Write("Pulse una Tecla:"); Console.ReadLine();
    }
}