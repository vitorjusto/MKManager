using MKManager.Model;
using MKManager.Model.Result;
using MKManager.Repository;

namespace MKManager.AppService
{
    public class ClienteAppService
    {
        public static void CadastrarCliente(ClienteModel cliente) => ClienteRepository.CadastrarCliente(cliente);
        public static IEnumerable<ListagemClienteResult> ListarClientes() => ClienteRepository.ListarClientes();
        public static void AtualizarCliente(ClienteModel cliente) => ClienteRepository.AtualizarCliente(cliente);
        public static void ExcluirCliente(ClienteModel cliente) => ClienteRepository.ExcluirCliente(cliente);
    }
}
