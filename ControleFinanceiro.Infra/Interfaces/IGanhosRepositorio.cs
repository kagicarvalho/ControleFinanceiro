using ControleFinanceiro.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiro.Infra.Interfaces
{
    public interface IGanhosRepositorio : IRepositorioGenerico<Ganho>
    {
        IQueryable<Ganho> PegarGanhosPeloUsuarioId(string usuarioId);

        IQueryable<Ganho> FiltrarGanhos(string nomeCategoria);

        Task<double> PegarGanhoTotalPeloUsuarioId(string usuarioId);
    }
}
