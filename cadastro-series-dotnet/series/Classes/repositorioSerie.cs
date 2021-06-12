using series.interfaces;

namespace series.Classes
{
    public class repositorioSerie : iRepositorio <serie>
    {
        private List<serie> listaSerie = new List<serie>();
        public void AtualizarSeries(int id, serie entidade)
        {
            listaSerie[id] = entidade;
        }

        public void ExcluiSerie(int id)
        {
           listaSerie[id].Excluir();
        }

        public void Insere(serie entidade)
        {
            listaSerie.Add(objeto);
        }

        public List<serie> Lista ()
        {
            return listaSerie;
        }

        public int ProximoId()
        {
            return listaSerie.count;
        }

        public Serie RetornaPorId(int id)
        {
            return listaSerie(id);
        }
    }
}