using System;
using System.Collections.Generic;
using Dio.Series.Interfaces;


namespace Dio.Series
{

    public class FilmeRepositorio : IRepositorio<Filmes>
    {
        private List<Filmes> listaSerie = new List<Filmes>();
         public void Atualizar(int id, Filmes entidade)
         {
             listaSerie[id] = entidade;
         }
         public void Exclui(int id)
         {
             listaSerie[id].Excluir();
         }
         public void Insere(Filmes entidade)
         {
             listaSerie.Add(entidade);
         }
         public List<Filmes> Lista()
         {
             return listaSerie;
         }
         public int ProximoId()
         {
             return listaSerie.Count;
         }
         public Filmes RetornaPorId(int id)
         {
             return listaSerie[id];
         }


    }
    
}