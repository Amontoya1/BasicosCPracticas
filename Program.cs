internal class Program


{
    struct Cliente
    {
        public int cod_cli;
        public string nome, endereco, telefone;
    }

    struct Recebimento
    {
        public decimal valorDoc;
        public DateTime dataEmissao, dataVencimento;
    }
    private static void Main(string[] args)
    {
        //Console.WriteLine("Hello, World!");
        //string miNombre;
        //Console.WriteLine("Por favor, escriba su nombre");
        //miNombre = Console.ReadLine();
        //Console.WriteLine("Hola {0}", miNombre);

        //Fecha actual exemplo

        //Console.WriteLine("Hora y Fecha: {0}\n", DateTime.Now);
        //Console.WriteLine("Solo la hora: {0}\n", DateTime.Now.ToString("h:mm:ss"));
        //Console.WriteLine("Solo la Fecha: {0}\n", DateTime.Now.ToString("dd/MM/yyyy"));

        //Console.ReadKey();

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

        //int NUM1, NUM2, RESUL;
        //string linea;
        //Console.Write("PRIMER NÚMERO :");
        //linea = Console.ReadLine();
        //NUM1 = int.Parse(linea);
        //Console.Write("SEGUNDO NÚMERO :");
        //linea = Console.ReadLine();
        //NUM2 = int.Parse(linea);
        //Console.WriteLine();
        //RESUL = NUM1 + NUM2;
        //Console.WriteLine("LA SUMA ES {0}: ", RESUL);
        //RESUL = NUM1 - NUM2;
        //Console.WriteLine("LA RESTA ES: {0} - {1} = {2} ", NUM1, NUM2, RESUL);
        //RESUL = NUM1 * NUM2;
        //Console.WriteLine("LA MULTIPLICACIÓN ES: " + RESUL);
        //RESUL = NUM1 / NUM2;
        //Console.WriteLine("LA DIVISIÓN ES: " + RESUL);
        //RESUL = NUM1 % NUM2;
        //Console.WriteLine("EL RESIDUO ES: " + RESUL);
        //Console.Write("Pulse una Tecla:"); Console.ReadLine();

        //double SUELDO, ARECIBIR;
        //int NHIJO, BONO;
        //string NOM, linea;
        //Console.Write("NOMBRE EMPLEADO :"); NOM = Console.ReadLine();
        //Console.Write("SUELDO EMPLEADO :"); linea = Console.ReadLine();
        //SUELDO = double.Parse(linea);
        //Console.Write("NÚMERO DE HIJOS :"); linea = Console.ReadLine();
        //NHIJO = int.Parse(linea);
        //if (NHIJO >= 3) { BONO = NHIJO * 10; } else { BONO = NHIJO * 20; }
        //ARECIBIR = SUELDO + BONO;
        //Console.WriteLine("RECIBE :" + String.Format("{0:c}", ARECIBIR));
        //Console.Write("Pulse una Tecla:"); Console.ReadLine();

        Cliente[] clientes = new Cliente[5];
        Recebimento[] recebimentos = new Recebimento[15];

        int qtdCliente = 0;
        int qtdRecebimento = 0;
        int opcao = -1;

        do
        {
            Console.Title = " * SISTEMA DE RECEBIMENTOS * ";
            Console.BackgroundColor = ConsoleColor.White;// Muda a cor da tela.
            Console.ForegroundColor = ConsoleColor.DarkBlue;// Muda a cor da letra.
            Console.Clear(); //limpa a tela

            //Imprime na tela as opções do Menu:
            Console.WriteLine("-------------------------");
            Console.WriteLine("     MENU DE OPÇÕES      ");
            Console.WriteLine("-------------------------");
            Console.WriteLine(" Informe a opção deseja: \n");
            Console.WriteLine("1. Cadastrar Cliente");
            Console.WriteLine("2. Alterar Cliente");
            Console.WriteLine("3. Cadastrar Recebimento");
            Console.WriteLine("4. Sair");
            Console.SetCursorPosition(25, 3); //Move o cursor para o fim da 4a linha

            //lê a opção escolhida pelo usuário
            opcao = Convert.ToInt32(Console.ReadLine());

            //limpa a tela
            Console.Clear();


            //direciona o programa para a opção escolhida pelo usuário:
            switch (opcao)
            {
                case 1:
                    //Testa se já chegou ao limite de clientes cadastrados
                    //onde o limite é o tamanho (Length) do vetor:
                    if (qtdCliente < clientes.Length)
                    {
                        //Preenche os dados do cliente
                        Console.WriteLine("Digite os dados do cliente \n");
                        Console.Write("Código: ");
                        clientes[qtdCliente].cod_cli = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Nome: ");
                        clientes[qtdCliente].nome = Console.ReadLine();
                        Console.Write("Endereço: ");
                        clientes[qtdCliente].endereco = Console.ReadLine();
                        Console.Write("Telefone: ");
                        clientes[qtdCliente].telefone = Console.ReadLine();

                        //incrementa o número de clientes
                        qtdCliente++;

                        Console.WriteLine("\nCliente Cadastrado com sucesso!");
                    }
                    else
                    {
                        Console.WriteLine("Número máximo alcançado: " + qtdCliente);
                    }

                    Console.Write("\nPressione qualquer tecla para voltar ao menu.");

                    //Aguarda o usuário pressionar qualquer tecla para continuar:
                    Console.ReadKey();
                    break;
                case 2:
                    Console.WriteLine(" vazio ");
                    Console.ReadKey();
                    break;
                case 3:
                    //Testa se já chegou ao limite de Recebimentos cadastrados
                    //onde o limite é o tamanho (Length) do vetor:
                    if (qtdRecebimento < recebimentos.Length)
                    {
                        //Preenche os dados dos Recebimentos
                        Console.WriteLine("Digite os dados dos Recebimentos \n");
                        Console.WriteLine("Número do documento: " + (qtdRecebimento + 1));
                        Console.Write("Valor R$: ");
                        recebimentos[qtdRecebimento].valorDoc = Convert.ToDecimal(Console.ReadLine());
                        Console.Write("Data de emissão: ");
                        recebimentos[qtdRecebimento].dataEmissao = Convert.ToDateTime(Console.ReadLine());
                        Console.Write("Data de vencimento: ");
                        recebimentos[qtdRecebimento].dataVencimento = Convert.ToDateTime(Console.ReadLine());

                        qtdRecebimento++;

                        Console.WriteLine("\nRecebimento cadastrado com sucesso!");
                    }
                    else
                    {
                        Console.WriteLine("Número máximo já alcançado: " + qtdRecebimento);
                    }

                    Console.Write("\nPressione qualquer tecla para voltar ao menu.");

                    //Aguarda o usuário pressionar qualquer tecla para continuar:
                    Console.ReadKey();
                    break;
                case 4:
                    Console.Title = " * SAIR * ";
                    Console.WriteLine("------------------");
                    Console.WriteLine("Saindo do Sistema");
                    Console.WriteLine("------------------");
                    Console.ReadKey();
                    break;

                default: //executado quando o usuário escolhe uma opção que não existe
                    Console.Title = " * INVALIDO * ";
                    Console.WriteLine("---------------");
                    Console.WriteLine("Opção inválida!");
                    Console.WriteLine("---------------");
                    Console.Write("\nPressione qualquer tecla para voltar ao menu.");
                    //Aguarda o usuário pressionar qualquer tecla para continuar:
                    Console.ReadKey();
                    break;
            }
        } while (opcao != 4);
    }
}
