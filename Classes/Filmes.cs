namespace Dio.Series
{
    public class Filmes : EntidadeBase
    {

        //Atributos
        private Genero Genero {get; set;}
        private string Titulo {get; set;}
        private string Descricao {get; set;}
        private int Ano {get; set;}
        private bool Excluido {get;set;}

        //Metodos
        public Filmes(int id, Genero genero, string titulo, string descicao, int ano)
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