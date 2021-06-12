using System;
using System.Collections.Generic;
using series.interfaces;

namespace series.Classes
{
    public class SerieRepositorio : iRepositorio<serie>
    {
        private List<Serie> listaSerie = new List<Serie>();
        public void Atualiza(int id, Serie objeto)
        {
            listaSerie[id] = objeto;
        }

        public void Atualiza(int id, serie entidade)
        {
            throw new NotImplementedException();
        }

        public void Exclui(int id)
        {
            listaSerie[id].Excluir();
        }

        public void Insere(Serie objeto)
        {
            listaSerie.Add(objeto);
        }

        public void Insere(serie entidade)
        {
            throw new NotImplementedException();
        }

        public List<Serie> Lista()
        {
            return listaSerie;
        }

        public int ProximoId()
        {
            return listaSerie.Count;
        }

        public Serie RetornaPorId(int id)
        {
            return listaSerie[id];
        }

        serie iRepositorio<serie>.RetornaPorId(int id)
        {
            throw new NotImplementedException();
        }
    }
}
