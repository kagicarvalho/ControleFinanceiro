using System.Collections.Generic;

namespace ControleFinanceiro.Entities.Models
{
    public class Tipo
    {
        public Tipo()
        { }

        public Tipo(int tipoId, string nome, ICollection<Categoria> categorias)
        {
            TipoId = tipoId;
            Nome = nome;
            Categorias = categorias;
        }

        public int TipoId { get; set; }
        public string Nome { get; set; }
        public virtual ICollection<Categoria> Categorias { get; set; }
    }
}
