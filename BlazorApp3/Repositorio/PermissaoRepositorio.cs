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

        public void AdicionarCliente(bool permitido, int tipoEmailID, int enviarParaId, int formaEnvioRmId)
        {

            PermissaoCliente novoCliente = new PermissaoCliente();
            List<PermissaoTipo> listagemTipos = ListarPermissaoTipo();
            List<PermissaoEnviarPara> listagemEnviarPara = ListarPermissaoEnviarPara();
            List<PermissaoFormaEnvio> listagemForma = ListarFormaPermissao();

            foreach (var x in listagemTipos)
            {
                if(x.TipoEmailID == tipoEmailID)
                {
                    novoCliente.TipoEmailID = x;
                }
               
            }

            foreach (var y in listagemEnviarPara)
            {
                if (y.EnviarParaID == enviarParaId)
                {
                    novoCliente.EnviarParaID = y;
                }

            }

            foreach (var z in listagemForma)
            {
                if (z.FormaEnvioRmID == formaEnvioRmId)
                {
                    novoCliente.FormaEnvioRmID = z;
                }

            }

            novoCliente.Permitido = permitido;
 
            _context.permissaoClientes.Add(novoCliente);
            _context.SaveChanges();
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


        public void Editar(int clienteId, bool permitido, int tipoEmailID, int enviarParaId, int formaEnvioRmId)
        {
            PermissaoCliente novoCliente = new PermissaoCliente();
            List<PermissaoTipo> listagemTipos = ListarPermissaoTipo();
            List<PermissaoEnviarPara> listagemEnviarPara = ListarPermissaoEnviarPara();
            List<PermissaoFormaEnvio> listagemForma = ListarFormaPermissao();

            foreach (var x in listagemTipos)
            {
                if (x.TipoEmailID == tipoEmailID)
                {
                    novoCliente.TipoEmailID = x;
                }

            }

            foreach (var y in listagemEnviarPara)
            {
                if (y.EnviarParaID == enviarParaId)
                {
                    novoCliente.EnviarParaID = y;
                }

            }

            foreach (var z in listagemForma)
            {
                if (z.FormaEnvioRmID == formaEnvioRmId)
                {
                    novoCliente.FormaEnvioRmID = z;
                }

            }

            novoCliente.Permitido = permitido;

            //
            PermissaoCliente clienteEditado = FiltrarPorId(clienteId);
            clienteEditado.EnviarParaID = novoCliente.EnviarParaID;
            clienteEditado.FormaEnvioRmID = novoCliente.FormaEnvioRmID;
            clienteEditado.TipoEmailID = novoCliente.TipoEmailID;
            clienteEditado.Permitido = novoCliente.Permitido;

            _context.permissaoClientes.Update(clienteEditado);
            _context.SaveChanges();
        }

        public PermissaoCliente FiltrarPorId(int id)
        {
            return _context.permissaoClientes.FirstOrDefault(x => x.ClientID == id);
        }

        public List<PermissaoCliente> ListarClientes()
        {
            return _context.permissaoClientes.ToList();
        }

        public void RemoverCliente(int id)
        {
            PermissaoCliente clienteRemovido = FiltrarPorId(id);
            _context.permissaoClientes.Remove(clienteRemovido);
            _context.SaveChanges();
        }
    }
}
