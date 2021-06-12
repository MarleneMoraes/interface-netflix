namespace series
{
    public class serie : EntidadeBase
    {
        //Atributos da série
        public serie(Genero genero, string titulo, string descricao, int ano)
        {
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Ano = ano;

        }
        private Genero Genero { get; set; }

        private string Titulo { get; set; }
        private string Descricao { get; set; }
        private int Ano { get; set; }

        private bool Excluido { get; set; }

        //Métodos
        public serie(int id, Genero genero, string titulo, string descricao, int ano)
        {
            this.Id = id;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Ano = ano;
            this.Excluido = false;
        }

        public override string ToString()
        {
            string resposta = "";
            resposta += "Gênero " + this.Genero + System.Environment.NewLine;
            resposta += "Título " + this.Titulo + System.Environment.NewLine;
            resposta += "Descrição " + this.Descricao + System.Environment.NewLine;
            resposta += "Ano de Início " + this.Ano;
            return resposta;
        }

        public string retornaTitulo()
        {
            return this.Titulo;
        }

        public string retornaId()
        {
            return this.Id;
        }

        public void Exclui ()
        {
            this.Excluido = true;
        }

    }
}