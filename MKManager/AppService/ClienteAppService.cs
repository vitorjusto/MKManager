using MKManager.Model;
using MKManager.Repository;

namespace MKManager.AppService
{
    public class ClienteAppService
    {
        public void CadastrarCliente(ClienteModel cliente) => ClienteRepository.CadastrarCliente(cliente);
        public void ListarClientes() => ClienteRepository.ListarClientes();
        public void AtualizarCliente(ClienteModel cliente) => ClienteRepository.AtualizarCliente(cliente);
        public void ExcluirCliente(ClienteModel cliente) => ClienteRepository.ExcluirCliente(cliente);
    }
}
