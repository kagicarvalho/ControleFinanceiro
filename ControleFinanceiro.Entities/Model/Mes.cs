using System.Collections.Generic;

namespace ControleFinanceiro.Entities.Models
{
    public class Mes
    {
        public Mes()
        { }

        public Mes(int mesId, string nome, ICollection<Ganho> ganhos, ICollection<Despesa> despesas)
        {
            MesId = mesId;
            Nome = nome;
            Ganhos = ganhos;
            Despesas = despesas;
        }

        public int MesId { get; set; }
        public string Nome { get; set; }
        public virtual ICollection<Ganho> Ganhos { get; set; }
        public virtual ICollection<Despesa> Despesas { get; set; }
    }
}
