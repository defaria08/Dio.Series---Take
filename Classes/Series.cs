namespace Dio.Series
{
    public class Series : EntidadeBase
    {

        //Atributos
        private Genero Genero {get; set;}
        private string Titulo {get; set;}
        private string Descricao {get; set;}
        private int Ano {get; set;}
        private bool Excluido {get;set;}

        //Metodos
        public Series(int id, Genero genero, string titulo, string descicao, int ano)
        {
            this.id = id;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descricao = descicao;
            this.Ano = ano;
            this.Excluido = false;

        }

        public override string ToString()
        {
            //Environment.NewLine https://docs.microsoft.com/en-us/dotnet/api/system.environmnent.newline?view=netcore-3.1
            string retorno = "";
            retorno +="Gênero: " + this.Genero + "\n";
            retorno +="Título: " + this.Titulo + "\n";
            retorno +="Descrição: " + this.Descricao  + "\n";
            retorno +="Ano do Início: " + this.Ano + "\n";
            retorno +="Excluido: "+ this.Excluido;
            return retorno;
        }
        public string retornaTitulo()
        {
            return this.Titulo;
        }
        public int retornaId()
        {
            return this.id;
        }
        public void Excluir()
        {
            this.Excluido = true;
        }
        public bool retornaExcluido()
        {
            return this.Excluido;
        }

    }


    
}