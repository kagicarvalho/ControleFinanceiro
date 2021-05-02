using ControleFinanceiro.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ControleFinanceiro.Infra.Interfaces
{
    public interface IMesRepositorio : IRepositorioGenerico<Mes>
    {
        new IQueryable<Mes> PegarTodos();
    }
}
