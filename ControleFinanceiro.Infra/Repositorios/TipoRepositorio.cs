using ControleFinanceiro.Entities.Models;
using ControleFinanceiro.Infra.Interfaces;

namespace ControleFinanceiro.Infra.Repositorios
{
    public class TipoRepositorio : RepositorioGenerico<Tipo>, ITipoRepositorio
    {
        public TipoRepositorio(Contexto contexto) : base(contexto)
        {
        }
    }
}
