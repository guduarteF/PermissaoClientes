using System.ComponentModel.DataAnnotations;

namespace BlazorApp3.Models
{
    public class PermissaoCliente
    {
        [Key]
        public int ClientID { get; set; }
        public bool Permitido { get; set; }
        public PermissaoTipo TipoEmailID { get; set; }
        public PermissaoEnviarPara EnviarParaID { get; set; }
        public PermissaoFormaEnvio FormaEnvioRmID { get; set; }



    }
}
