using System.Collections.Generic;

namespace ControleFinanceiro.Entities.Models
{
    public class Categoria
    {
        public Categoria()
        { }
        public Categoria(int categoriaId, string nome, string icone, int tipoId, Tipo tipo, ICollection<Despesa> despesas, ICollection<Ganho> ganhos)
        {
            CategoriaId = categoriaId;
            Nome = nome;
            Icone = icone;
            TipoId = tipoId;
            Tipo = tipo;
            Despesas = despesas;
            Ganhos = ganhos;
        }

        public int CategoriaId { get; set; }
        public string Nome { get; set; }
        public string Icone { get; set; }

        public int TipoId { get; set; }
        public Tipo Tipo { get; set; }

        public virtual ICollection<Despesa> Despesas { get; set; }

        public virtual ICollection<Ganho> Ganhos { get; set; }
    }
}
