using System;

namespace series
{
    class Program
    {
        static repositorioSerie repositorio = new repositorioSerie ();
        static void Main(string[] args)
        {
            serie meuObjeto = new serie();

           string opcaoUsuario = ObterOpcaoUsuario();

           while(opcaoUsuario.ToUpper() != "X")
           {
               switch (opcaoUsuario)
               {
                   case "1":
                    ListarSeries();
                    break;
                   case "2":
                    InserirSeries();
                    break;
                   case "3":
                    AtualizarSeries();
                    break;
                   case "4":
                    ExcluiSerie();
                    break;
                   case "5":
                    VisualizarSerie();
                    break;
                   case "C":
                    Console.Clear();
                    break;
                   default:
                    throw new ArgumentOutOfRangeException();
               }
           }
        }

        private static void ListarSeries()
        {
            Console.WriteLine("Listar Séries");

            var lista = repositorio.Lista();

            if(lista.Count == 0)
            {
                Console.WriteLine("Nenhuma série cadastrada.");
                return;
            }

            foreach (var serie in lista)
            {
                Console.WriteLine('#ID {0}: - {1}') serie retornaId() serie retornaTitulo;
            }
            
            Console.Write("Digite o gênero entre as opções acima: ");
            int entradaGenero = int.Parse (Console.ReadLine());
            
            Console.Write("Digite o título da Série: ");
            string entradaTitulo = Console.ReadLine();

            Console.Write("Digite o ano de início da Série: ");
            int entradaAno = int.Parse(Console.ReadLine());
            
            Console.Write("Digite a descrição  da Série: ");
            int entradaDescricao = Console.ReadLine();

            serie novaSerie = new serie (id: repositorio.ProximoId(),
                                         genero: (Genero)entradaGenero,
                                         titulo: entradaTitulo,
                                         ano: entradaAno,
                                         descricao: entradaDescricao);
            
            repositorio.Insere(novaSerie);
        }

        private static void Inserir Serie()
        {
            Console.WriteLine("Inserir nova série");

            foreach (int i in Enum.GetName(typeof(Genero), i));

            Console.Write("Digite o título da série: ");
            string entradaTitulo = 

            Console.Write("Digite o título da série: ");
        }

        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine("Bem vindo ao Banco de Séries!!!");
            Console.Write("Informe a opção desejada: ");
            Console.WriteLine("1 - Listar séries");
            Console.WriteLine("2 - Inserir nova série");
            Console.WriteLine("3 - Atualizar série");
            Console.WriteLine("4 - Excluir série");
            Console.WriteLine("5 - Visualizar série");
            Console.WriteLine("C - Limpar Tela");
            Console.WriteLine("X - Sair");

            string opcaoUsuario = Console.ReadLine().ToUpper();
            return opcaoUsuario;
        }
    }
}
