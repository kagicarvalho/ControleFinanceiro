using Microsoft.AspNetCore.Identity;

namespace ControleFinanceiro.Entities.Models
{
    public class Funcao : IdentityRole<string>
    {
        public string Descricao { get; set; }
    }
}
