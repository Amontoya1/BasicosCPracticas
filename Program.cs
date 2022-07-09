internal class Program
{
    private static void Main(string[] args)
    {
        //Console.WriteLine("Hello, World!");
        //string miNombre;
        //Console.WriteLine("Por favor, escriba su nombre");
        //miNombre = Console.ReadLine();
        //Console.WriteLine("Hola {0}", miNombre);

        //Fecha actual exemplo

        Console.WriteLine("Hora y Fecha: {0}\n", DateTime.Now);
        Console.WriteLine("Solo la hora: {0}\n", DateTime.Now.ToString("h:mm:ss"));
        Console.WriteLine("Solo la Fecha: {0}\n", DateTime.Now.ToString("dd/MM/yyyy"));

        Console.ReadKey();

        //Exemplo con salida e interaccion 

        //byte CANB, CANH, CANP;
        //double APAGAR;
        //string linea;
        //const double PRECIOB = 0.8;
        //const double PRECIOH = 2;
        //const double PRECIOP = 1.2;
        //Console.Write("Cantidad de Hamburguesas :"); linea = Console.ReadLine();
        //CANH = byte.Parse(linea);
        //Console.Write("Cantidad de Papas:"); linea = Console.ReadLine();
        //CANP = byte.Parse(linea);
        //Console.Write("Cantidad de Bebidas :"); linea = Console.ReadLine();
        //CANB = byte.Parse(linea);
        //Console.WriteLine();
        //APAGAR = CANH * PRECIOH + CANP * PRECIOP + CANB * PRECIOB;
        //Console.WriteLine("Valor a Pagar: " + APAGAR);
        //Console.Write("Pulse una Tecla:"); Console.ReadLine();

        //Tipos de variables
        //int i = 0;
        //long l = 1;
        //float f = 1.5555f;
        //double d = 2.777777777d;

        //char c = 'c';
        //string str = "string";

        //Console.Write(" int: " + i);
        //Console.WriteLine(" long: " + l);

        //Console.Write(" float: " + f);
        //Console.WriteLine(" double: " + d);

        //Console.Write(" char: " + c);
        //Console.WriteLine(" string: " + str);

        int NUM1, NUM2, RESUL;
        string linea;
        Console.Write("PRIMER NÚMERO :");
        linea = Console.ReadLine();
        NUM1 = int.Parse(linea);
        Console.Write("SEGUNDO NÚMERO :");
        linea = Console.ReadLine();
        NUM2 = int.Parse(linea);
        Console.WriteLine();
        RESUL = NUM1 + NUM2;
        Console.WriteLine("LA SUMA ES {0}: ", RESUL);
        RESUL = NUM1 - NUM2;
        Console.WriteLine("LA RESTA ES: {0} - {1} = {2} ", NUM1, NUM2, RESUL);
        RESUL = NUM1 * NUM2;
        Console.WriteLine("LA MULTIPLICACIÓN ES: " + RESUL);
        RESUL = NUM1 / NUM2;
        Console.WriteLine("LA DIVISIÓN ES: " + RESUL);
        RESUL = NUM1 % NUM2;
        Console.WriteLine("EL RESIDUO ES: " + RESUL);
        Console.Write("Pulse una Tecla:"); Console.ReadLine();

    }
}