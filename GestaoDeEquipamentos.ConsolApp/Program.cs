using System;

namespace GestaoDeEquipamentos.ConsolApp
{
    internal class Program
    {
        static string[] nomesEquipamentos = new string[1000];
        static decimal[] precosEquipamentos = new decimal[1000];
        static string[] numerosSerieEquipamentos = new string[1000];
        static string[] datasEquipamentos = new string[1000];
        static string[] fabricantesEquipamentos = new string[1000];
         
        static int posicaoEquipamento = 1;

        static string[] tituloChamado = new string[1000];
        static string[] descricaoChamado = new string[1000];
        static string[] equipamentoChamado = new string[nomesEquipamentos.Length];
        static string[] datasChamados = new string[1000];
        
        static int posicaoChamado = 1;

        static void Main(string[] args)
        {
            while (true)
            {
                string opcao = ApresentarMenuPrincipal();

                if (opcao == "s")
                    break;

                if (opcao == "1")
                {                    
                    string opcaoSubMenu = ApresentarMenuEquipamentos();

                    if (opcaoSubMenu == "s")
                        continue;

                    if (opcaoSubMenu == "1")                    
                        InserirNovoEquipamento();                        
                                       
                    else if (opcaoSubMenu == "2")                    
                        VisualizarEquipamentos();

                    else if (opcaoSubMenu == "3")
                        EditarEquipamentos();

                    else if (opcaoSubMenu == "4")
                        ExcluirEquipamentos();
                }
                else if (opcao == "2")
                {
                    string opcaoSubMenu = ApresentarMenuChamados();
                    
                    if (opcaoSubMenu == "s")
                        continue;

                    if (opcaoSubMenu == "1")
                        InserirNovoChamado();

                    else if (opcaoSubMenu == "2")
                        VisualizarChamados();

                    else if (opcaoSubMenu == "3")
                        EditarChamados();

                    else if (opcaoSubMenu == "4")
                        ExcluirChamados();
                }

                Console.ReadLine();
            }
        }

        static string ApresentarMenuPrincipal()
        {
            Console.Clear();
            Console.WriteLine("Manutenção de Equipamentos\n");

            Console.WriteLine("Digite 1 para CADASTRO DE EQUIPAMENTOS");
            Console.WriteLine("Digite 2 para CONTROLE DE CHAMADOS");
            Console.WriteLine("Digite S para SAIR");

            string opcao = Console.ReadLine().ToLower();

            return opcao;
        }

        #region EQUIPAMENTOS
        static string ApresentarMenuEquipamentos()
        {
            Console.Clear();
            Console.WriteLine("CADASTRO DE EQUIPAMENTOS\n");
            Console.WriteLine("Digite 1 para INSERIR NOVO EQUIPAMENTO");
            Console.WriteLine("Digite 2 para VISUALIZAR EQUIPAMENTOS");
            Console.WriteLine("Digite 3 para EDITAR UM EQUIPAMENTO");
            Console.WriteLine("Digite 4 para EXCLUIR UM EQUIPAMENTO");
            Console.WriteLine("Digite S para SAIR");

            string opcaoSubMenu = Console.ReadLine().ToLower();

            return opcaoSubMenu;
        }
        static void InserirNovoEquipamento()
        {
            Console.Clear();
            Console.WriteLine("CADASTRO DE EQUIPAMENTOS\n");
            Console.WriteLine("Inserindo um novo equipamento:\n");

            Console.Write("Digite o nome do equipamento: ");
            string nome = Console.ReadLine();
            nomesEquipamentos[posicaoEquipamento] = nome;

            Console.Write("Digite o preço do equipamento: ");
            decimal preco = Convert.ToDecimal(Console.ReadLine());
            precosEquipamentos[posicaoEquipamento] = preco;

            Console.Write("Digite o número de série do equipamento: ");
            string numeroSerie = Console.ReadLine();
            numerosSerieEquipamentos[posicaoEquipamento] = numeroSerie;

            Console.Write("Digite o data de fabricação do equipamento: ");
            string dataFabricacao = Console.ReadLine();
            datasEquipamentos[posicaoEquipamento] = dataFabricacao;

            Console.Write("Digite o fabricante do equipamento: ");
            string fabricante = Console.ReadLine();
            fabricantesEquipamentos[posicaoEquipamento] = fabricante;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nEquipamento cadastrado com sucesso.");
            Console.ResetColor();

            posicaoEquipamento++;
        }
        static void VisualizarEquipamentos()
        {
            Console.Clear();
            Console.WriteLine("Visualizando equipamentos");

            for (int posicao = 1; posicao < posicaoEquipamento; posicao++)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("\nNúmero no índice: " + posicao);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\nNome: " + nomesEquipamentos[posicao]);
                Console.WriteLine("Preço: " + precosEquipamentos[posicao]);
                Console.WriteLine("Número de Série: " + numerosSerieEquipamentos[posicao]);
                Console.WriteLine("Data de Fabricação: " + datasEquipamentos[posicao]);
                Console.WriteLine("Fabricante: " + fabricantesEquipamentos[posicao]);
                Console.ResetColor();
            }
        }
        static void EditarEquipamentos()
        {
            Console.Clear();
            Console.WriteLine("Editando equipamentos:\n");

            /*VisualizarEquipamentos();            

            Console.WriteLine("\nDigite o número do equipamento que você deseja editar: ");
            posicaoEquipamento = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nDigite o novo nome do produto: ");
            nomesEquipamentos[posicaoEquipamento] = Console.ReadLine();
            Console.Write("Digite o novo preço do produto: ");
            precosEquipamentos[posicaoEquipamento] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o novo número de série do produto: ");
            numerosSerieEquipamentos[posicaoEquipamento] = Console.ReadLine();
            Console.Write("Digite a nova data de fabricação do produto: ");
            datasEquipamentos[posicaoEquipamento] = Console.ReadLine();
            Console.Write("Digite o novo fabricante do produto: ");
            fabricantesEquipamentos[posicaoEquipamento] = Console.ReadLine();*/
        }
        static void ExcluirEquipamentos()
        {
            Console.WriteLine("Excluindo Equipamentos\n");

            Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nEquipamento excluído com sucesso.");
            Console.ResetColor();
        }
        #endregion

        #region CHAMADOS
        static string ApresentarMenuChamados()
        {
            Console.Clear();
            Console.WriteLine("CONTROLE DE CHAMADOS\n");
            Console.WriteLine("Digite 1 para INSERIR NOVO CHAMADO");
            Console.WriteLine("Digite 2 para VISUALIZAR CHAMADOS");
            Console.WriteLine("Digite 3 para EDITAR UM CHAMADO");
            Console.WriteLine("Digite 4 para EXCLUIR UM CHAMADO");
            Console.WriteLine("Digite S para SAIR");

            string opcaoSubMenu = Console.ReadLine().ToLower();

            return opcaoSubMenu;
        }
        static void InserirNovoChamado()
        {
            Console.Clear();
            Console.WriteLine("CONTROLE DE CHAMADOS\n");
            Console.WriteLine("Abrindo um novo chamado:\n");

            Console.Write("Digite o título do chamado: ");
            string titulo = Console.ReadLine();
            tituloChamado[posicaoChamado] = titulo;

            Console.Write("Digite a descrição do chamado: ");
            string descricao = Console.ReadLine();
            descricaoChamado[posicaoChamado] = descricao;

            Console.Write("Digite o número de série do equipamento: ");
            string equipamento = Console.ReadLine();
            equipamentoChamado[posicaoChamado] = equipamento;

            Console.Write("Digite o data de abertura do chamado: ");
            string dataAbertura = Console.ReadLine();
            datasChamados[posicaoChamado] = dataAbertura;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nChamado cadastrado com sucesso.");
            Console.ResetColor();

            posicaoChamado++;
        }
        static void VisualizarChamados()
        {
            Console.Clear();
            Console.WriteLine("Visualizando chamados\n");

            for (int posicao2 = 1; posicao2 < posicaoChamado; posicao2++)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("\nNúmero no índice: " + posicao2);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\nTítulo: " + tituloChamado[posicao2]);
                Console.WriteLine("Descrição: " + descricaoChamado[posicao2]);
                //Console.WriteLine("Equipamento: " + equipamentoChamado[posicao2]);
                Console.WriteLine("Data de abertura: " + datasChamados[posicao2]);
                Console.ResetColor();
            }
        }
        static void EditarChamados()
        {
            Console.Clear();
            Console.WriteLine("Editando equipamentos:\n");

            /*VisualizarEquipamentos();            

            Console.WriteLine("\nDigite o número do equipamento que você deseja editar: ");
            posicaoEquipamento = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nDigite o novo nome do produto: ");
            nomesEquipamentos[posicaoEquipamento] = Console.ReadLine();
            Console.Write("Digite o novo preço do produto: ");
            precosEquipamentos[posicaoEquipamento] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o novo número de série do produto: ");
            numerosSerieEquipamentos[posicaoEquipamento] = Console.ReadLine();
            Console.Write("Digite a nova data de fabricação do produto: ");
            datasEquipamentos[posicaoEquipamento] = Console.ReadLine();
            Console.Write("Digite o novo fabricante do produto: ");
            fabricantesEquipamentos[posicaoEquipamento] = Console.ReadLine();*/
        }
        static void ExcluirChamados()
        {
            Console.WriteLine("Excluindo Equipamentos\n");

            Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nEquipamento excluído com sucesso.");
            Console.ResetColor();
        }
        #endregion
    }
}