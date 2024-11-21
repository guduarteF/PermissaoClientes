using BlazorApp3.Data;
using BlazorApp3.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp3.Repositorio
{
    public class PermissaoRepositorio : IPermissaoRepositorio
    {
        public PermissaoDbContext _context;

        public PermissaoRepositorio(PermissaoDbContext context)
        {
            _context = context;
        }

        public PermissaoCliente AdicionarCliente(bool permitido, int tipoEmailID, int enviarParaId, int formaEnvioRmId)
        {
            PermissaoCliente novoCliente = new PermissaoCliente();
            novoCliente.Permitido = permitido;
            novoCliente.TipoEmailID.TipoEmailID = tipoEmailID;
            novoCliente.EnviarParaID.EnviarParaID = enviarParaId;
            novoCliente.FormaEnvioRmID.FormaEnvioRmID = formaEnvioRmId;
            _context.permissaoClientes.Add(novoCliente);
            return novoCliente;
        }

        public List<PermissaoFormaEnvio> ListarFormaPermissao()
        {
            return _context.permissaoFormaEnvios.ToList();
        }

        public List<PermissaoEnviarPara> ListarPermissaoEnviarPara()
        {
            return _context.permissaoEnviarPara.ToList();
        }

        public List<PermissaoTipo> ListarPermissaoTipo()
        {
            return _context.permissaoTipos.ToList();
        }

        //public PermissaoTipo ListarPermissaoTipo(int id)
        //{
        //    _context.permissaoTipos.
        //}

        //public PermissaoCliente Editar(PermissaoCliente cliente)
        //{
        //    PermissaoCliente clientdbz = ListarPorId(cliente.ClientID);
        //    // nao esta puxando o cliente do banco de dados {null}
        //    clienteDB.Permitido = cliente.Permitido;
        //    clienteDB.EnviarParaID = cliente.EnviarParaID;
        //    clienteDB.FormaEnvioRmID = cliente.FormaEnvioRmID;
        //    clienteDB.TipoEmailID = cliente.TipoEmailID;

        //    _context.permissaoClientes.Update(clienteDB);
        //    _context.SaveChanges();

        //    return clienteDB;
        //}

        public PermissaoCliente FiltrarPorId(int id)
        {
            return _context.permissaoClientes.FirstOrDefault(x => x.ClientID == id);
        }

        public List<PermissaoCliente> ListarClientes()
        {
            return _context.permissaoClientes.ToList();
        }
    }
}
