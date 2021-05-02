namespace ControleFinanceiro.Entities.Models
{
    public class Ganho
    {
        public Ganho()
        { }

        public Ganho(int ganhoId, string descricao, int categoriaId, Categoria categoria, double valor, int dia, int mesId, Mes mes, int ano, string usuarioId, Usuario usuario)
        {
            GanhoId = ganhoId;
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

        public int GanhoId { get; set; }
        public string Descricao { get; set; }
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }
        public double Valor { get; set; }
        public int Dia { get; set; }
        public int MesId { get; set; }
        public Mes Mes { get; set; }
        public int Ano { get; set; }
        public string UsuarioId { get; set; }
        public Usuario Usuario { get; set; }
    }
}
