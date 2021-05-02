using ControleFinanceiro.Entities.Models;
using ControleFinanceiro.Infra.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ControleFinanceiro.Infra.Repositorios
{
    public class MesRepositorio : RepositorioGenerico<Mes>, IMesRepositorio
    {
        private readonly Contexto _contexto;
        public MesRepositorio(Contexto contexto) : base(contexto)
        {
            _contexto = contexto;
        }

        public new IQueryable<Mes> PegarTodos()
        {
            try
            {
                return _contexto.Meses.OrderBy(m => m.MesId);

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
