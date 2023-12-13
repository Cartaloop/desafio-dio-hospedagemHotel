using HospedagemDeHotel.Models;


List<Pessoa> pessoaList = [];
Suite suite = new();
Reserva reserva = new();


while (true)
{
    Console.WriteLine("SISTEMA DE HOSPEDAGEM DE HOTEL");
    Console.WriteLine("------------------------------\n");

    Console.WriteLine("OPÇÃO (2): CADASTRAR HOSPEDE");
    Console.WriteLine("OPÇÃO (2): CRIAR NOVA SUITE");
    Console.WriteLine("OPÇÃO (3): CRIAR NOVA RESERVA");
    Console.WriteLine("OPÇÃO (4): EXIBIR A QUANTIDADE DE HOSPEDES E VALOR DA DIÁRIA");
    Console.WriteLine("OPÇÃO (5): SAIR");
    int input;
    if(!int.TryParse(Console.ReadLine(), out input) || (input < 0 && input > 5))
    {
        Console.WriteLine("Digite uma opção válida");
        continue;
    }

    switch(input)
    {
        case 1:
            {
                Console.Write("Digite o nome da pessoa: ");
                string nome = Console.ReadLine()!;
                Console.Write("Digite o sobrenome da pessoa: ");
                string sobrenome = Console.ReadLine()!;
                Pessoa p = new(nome, sobrenome);
                pessoaList.Add(p);
                Console.WriteLine("Pessoa adicionada com sucesso. Aperte qualquer tecla para continuar...");
                Console.ReadKey();
                Console.Clear();
                break;
            }
        case 2:
            {
                Console.Write("Digite o tipo da suite: ");
                string tipo = Console.ReadLine()!;
                Console.Write("Digite a capacidade da suíte: ");
                int capacidade = int.Parse(Console.ReadLine()!);
                Console.Write("Digite o valor da diária para esta suíte: ");
                decimal valorDiaria = decimal.Parse(Console.ReadLine()!);
                suite.DefineParameters(tipo, capacidade, valorDiaria);
                Console.WriteLine("Suíte cadastrada com sucesso. Aperte qualquer tecla para continuar...");
                Console.ReadKey();
                Console.Clear();
                break;
            }
        case 3:
            {
                Console.Write("Digite a quantidade de dias para esta reserva: ");
                int quantidadeDiasReserva = int.Parse(Console.ReadLine()!);
                reserva.AtribuirDias(quantidadeDiasReserva);
                reserva.CadastrarSuite(suite);
                reserva.CadastrarHospedes(pessoaList);
                Console.WriteLine("Reserva efetuada com sucesso. Aperte qualquer tecla para continuar...");
                Console.ReadKey();
                Console.Clear();
                break;

            }
        case 4:
            {
                
                Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()!}");
                Console.WriteLine($"Valor da diária: {reserva.CalcularValorDiaria()}");
                Console.WriteLine("Aperte qualquer tecla para continuar...");
                Console.ReadKey();
                Console.Clear();
                break;
            }
        case 5:
            {
                Console.WriteLine("Você tem certeza que deseja fechar o programa? S/N");
                char inputExit;
                if (!char.TryParse(Console.ReadLine(), out inputExit) || (inputExit != 'S' && inputExit != 's' && inputExit != 'N' && inputExit != 'n'))
                {
                    Console.WriteLine("Digite uma opção válida!");
                    continue;
                }


                Console.WriteLine("Saindo do programa...");
                int tempoEmMilissegundos = 60000; 

                Console.WriteLine($"O programa será encerrado em {tempoEmMilissegundos / 1000} segundos.");

                Timer timer = new Timer(EncerrarPrograma, null, tempoEmMilissegundos, Timeout.Infinite);

                Console.WriteLine("Pressione qualquer tecla para sair antes do tempo terminar...");
                Console.ReadKey();

                timer.Change(Timeout.Infinite, Timeout.Infinite);
                Console.WriteLine("Programa encerrado manualmente.");

       
                Console.ReadKey();
            }

            return;
            }
    }



static void EncerrarPrograma(object state)
{
    Console.WriteLine("Tempo esgotado. Encerrando o programa...");
    Environment.Exit(0);
}