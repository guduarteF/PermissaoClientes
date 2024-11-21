using System.ComponentModel.DataAnnotations;

namespace BlazorApp3.Models
{
    public class PermissaoEnviarPara
    {
        [Key]
        public int EnviarParaID { get; set; }
        public string Descrição { get; set; }

    }
}
