using ControleFinanceiro.Entities.Models;
using System.Linq;
using System.Threading.Tasks;

namespace ControleFinanceiro.Infra.Interfaces
{
    public interface IFuncaoRepositorio : IRepositorioGenerico<Funcao>
    {
        Task AdicionarFuncao(Funcao funcao);

        Task AtualizarFuncao(Funcao funcao);

        IQueryable<Funcao> FiltrarFuncoes(string nomeFuncao);
    }
}
