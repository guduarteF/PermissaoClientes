using System.ComponentModel.DataAnnotations;

namespace BlazorApp3.Models
{
    public class PermissaoTipo
    {
        [Key]
        public int TipoEmailID { get; set; }

        public string Descrição { get; set; }

    }
}
