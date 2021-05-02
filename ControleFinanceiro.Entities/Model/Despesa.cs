namespace ControleFinanceiro.Entities.Models
{
    public class Despesa
    {
        public Despesa()
        { }

        public Despesa(int despesaId, int cartaoId, Cartao cartao, string descricao, int categoriaId, Categoria categoria, double valor, int dia, int mesId, Mes mes, int ano, string usuarioId, Usuario usuario)
        {
            DespesaId = despesaId;
            CartaoId = cartaoId;
            Cartao = cartao;
            Descricao = descricao;
            CategoriaId = categoriaId;
            Categoria = categoria;
            Valor = valor;
            Dia = dia;
            MesId = mesId;
            Mes = mes;
            Ano = ano;
            UsuarioId = usuarioId;
            Usuario = usuario;
        }

        public int DespesaId { get; set; }
        public int CartaoId { get; set; }
        public Cartao Cartao { get; set; }
        public string Descricao { get; set; }
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }
        public double Valor { get; set; }
        public int Dia { get; set; }
        public int MesId { get; set; }
        public Mes Mes { get; set; }
        public int Ano { get; set; }
        public string UsuarioId { get; set; }
        public Usuario  Usuario { get; set; }
    }
}
