using System.ComponentModel.DataAnnotations;

namespace BlazorApp3.Models
{
    public class PermissaoFormaEnvio
    {
        [Key]
        public int FormaEnvioRmID { get; set; }
        public string Descricao { get; set; }


    }
}
