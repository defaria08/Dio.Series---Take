using System;

namespace Dio.Series
{
    class Program
    {
        static SerieRepositorio repositorio = new SerieRepositorio();
        static FilmeRepositorio repositoriof = new FilmeRepositorio();
        static void Main(string[] args)
        {
               string opcaoUsuario = ObterOpcaoUsuario();
               while(opcaoUsuario.ToUpper() != "X")
               {
                   switch(opcaoUsuario)
                   {
                       case "1": ListarSerie(); break;
                       case "2": ListarFilme(); break;
                       case "3": InserirSerie(); break;
                       case "4": InserirFilme(); break;
                       case "5": AtualizarSerie(); break;
                       case "6": AtualizarFilme(); break;
                       case "7": ExcluirSerie(); break;
                       case "8": ExcluirFilme(); break;
                       case "9": VisualizarSerie(); break;
                       case "10": VisualizarFilme(); break;
                       case "C": Console.Clear(); break;
                       
                       default:
                            throw new ArgumentOutOfRangeException{};
                    }
                
                opcaoUsuario = ObterOpcaoUsuario();
             
               }
               Console.WriteLine("Obrigado por tutilizar nossos serviços.");
               Console.ReadLine(); 
        }
        

        private static void ListarSerie()
        {
            Console.WriteLine("Listar Séries");
            var lista = repositorio.Lista();

            if(lista.Count == 0)
            {
                Console.WriteLine("Nenhuma Série Cadastrada.");
                return;
            }
            foreach (var serie in lista)
            {
                var excluido = serie.retornaExcluido();
                Console.WriteLine("#ID {0}: - {1} - {2}", serie.retornaId(), serie.retornaTitulo(), (excluido ? "*Excluido":""));
            }

        }

        private static void ListarFilme()
        {
            Console.WriteLine("Listar Filmes");
            var lista = repositoriof.Lista();

            if(lista.Count == 0)
            {
                Console.WriteLine("Nenhum Filme Cadastrada.");
                return;
            }
            foreach (var filme in lista)
            {
                var excluido = filme.retornaExcluido();
                Console.WriteLine("#ID {0}: - {1} - {2}", filme.retornaId(), filme.retornaTitulo(), (excluido ? "*Excluido":""));
            }

        }

        private static void InserirSerie()
        {
            Console.WriteLine("Inserir uma nova série");

            foreach(int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0} - {1}", i, Enum.GetName(typeof(Genero),i));        
            }
            Console.WriteLine("Digite o gênero entre as opções acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o titulo da série: ");
            string entradaTitulo = Console.ReadLine();

            Console.WriteLine("Digite o ano de início da série: ");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a descrição da série: ");
            string entradaDescricao = Console.ReadLine();

            Series novaSerie = new Series (id: repositorio.ProximoId(),
                                           genero: (Genero)entradaGenero,
                                           titulo: entradaTitulo,
                                           ano: entradaAno,
                                           descicao: entradaDescricao);
            repositorio.Insere(novaSerie);
        }

         private static void InserirFilme()
        {
            Console.WriteLine("Inserir um novo Filme");

            foreach(int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0} - {1}", i, Enum.GetName(typeof(Genero),i));        
            }
            Console.WriteLine("Digite o gênero entre as opções acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o titulo do Filme: ");
            string entradaTitulo = Console.ReadLine();

            Console.WriteLine("Digite o ano de lançamento do Filme: ");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a descrição do Filme: ");
            string entradaDescricao = Console.ReadLine();

            Filmes novoFilme = new Filmes (id: repositorio.ProximoId(),
                                           genero: (Genero)entradaGenero,
                                           titulo: entradaTitulo,
                                           ano: entradaAno,
                                           descicao: entradaDescricao);
            repositoriof.Insere(novoFilme);
        }

        public static void AtualizarSerie()
        {
            Console.Write("Digite o ID da Série: ");
            int indiceSerie = int.Parse(Console.ReadLine());

            foreach(int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0} - {1}", i, Enum.GetName(typeof(Genero),i));
            }
            Console.Write("Digite o gênero entre as opções acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.Write("Digite o titulo da série: ");
            string entradaTitulo = Console.ReadLine();

            Console.Write("Digite o ano de início da série: ");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.Write("Digite a descrição da série: ");
            string entradaDescricao = Console.ReadLine();

            Series atualizaSerie = new Series (id: indiceSerie,
                                           genero: (Genero)entradaGenero,
                                           titulo: entradaTitulo,
                                           ano: entradaAno,
                                           descicao: entradaDescricao);
            repositorio.Atualizar(indiceSerie,atualizaSerie);
        }
        public static void AtualizarFilme()
        {
            Console.Write("Digite o ID do Filme: ");
            int indiceFilme = int.Parse(Console.ReadLine());

            foreach(int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0} - {1}", i, Enum.GetName(typeof(Genero),i));
            }
            Console.Write("Digite o gênero entre as opções acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.Write("Digite o titulo do Filme: ");
            string entradaTitulo = Console.ReadLine();

            Console.Write("Digite o ano de lançamento do Filme: ");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.Write("Digite a descrição do Filme: ");
            string entradaDescricao = Console.ReadLine();

            Filmes atualizarFilmes = new Filmes (id: indiceFilme,
                                           genero: (Genero)entradaGenero,
                                           titulo: entradaTitulo,
                                           ano: entradaAno,
                                           descicao: entradaDescricao);
            repositoriof.Atualizar(indiceFilme,atualizarFilmes);
        }

        public static void ExcluirSerie()
        {
            Console.Write("Digite o id da Série: ");
            int indiceSerie = int.Parse(Console.ReadLine());

            repositorio.Exclui(indiceSerie);
        }   
        public static void ExcluirFilme()
        {
            Console.Write("Digite o id do Filme: ");
            int indiceFilme = int.Parse(Console.ReadLine());

            repositoriof.Exclui(indiceFilme);
        }        

        public static void VisualizarSerie()
        {
            Console.Write("Digite o indice da Série: ");
            int indiceSerie = int.Parse(Console.ReadLine());

            var serie = repositorio.RetornaPorId(indiceSerie);
            Console.WriteLine(serie);

        }

        public static void VisualizarFilme()
        {
            Console.Write("Digite o indice do Filme: ");
            int indiceFilme = int.Parse(Console.ReadLine());

            var filme = repositoriof.RetornaPorId(indiceFilme);
            Console.WriteLine(filme);

        }

        
        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("Dio Séries a seu dispor!!");
            Console.WriteLine("Informe a opção desejada: ");

            Console.WriteLine("1- Listar Séries");
            Console.WriteLine("2- Inserir nova Série");
            Console.WriteLine("3- Atualizar Série");
            Console.WriteLine("4- Excluir Série");
            Console.WriteLine("5- Visualizar Série");
            Console.WriteLine("C- Limpar Tela");
            Console.WriteLine("X- Sair");
            Console.WriteLine();
            
            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;
        }
    }
    

}
