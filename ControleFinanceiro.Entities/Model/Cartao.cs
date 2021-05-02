using System.Collections.Generic;

namespace ControleFinanceiro.Entities.Models
{
    public class Cartao
    {
        public Cartao()
        { }

        public Cartao(int cartaoId, string nome, string bandeira, string numero, double limite, string usuarioId, Usuario usuario, ICollection<Despesa> despesas)
        {
            CartaoId = cartaoId;
            Nome = nome;
            Bandeira = bandeira;
            Numero = numero;
            Limite = limite;
            UsuarioId = usuarioId;
            Usuario = usuario;
            Despesas = despesas;
        }

        public int CartaoId { get; set; }

        public string Nome { get; set; }

        public string Bandeira { get; set; }

        public string Numero { get; set; }

        public double Limite { get; set; }

        public string UsuarioId { get; set; }
        public Usuario Usuario { get; set; }

        public virtual ICollection<Despesa> Despesas { get; set; }
    }
}
