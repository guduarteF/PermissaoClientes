namespace BlazorApp3.Models;

public interface IPermissaoRepositorio
{
    PermissaoCliente FiltrarPorId(int id);
    List<PermissaoCliente> ListarClientes();
    List<PermissaoFormaEnvio> ListarFormaPermissao();
    List<PermissaoTipo> ListarPermissaoTipo();
    List<PermissaoEnviarPara> ListarPermissaoEnviarPara();
    // PermissaoCliente Editar(PermissaoCliente cliente);
    void AdicionarCliente(bool permitido, int tipoEmailID, int enviarParaId, int formaEnvioRmId);

}
