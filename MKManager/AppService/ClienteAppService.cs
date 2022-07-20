using MKManager.Model;
using MKManager.Repository;

namespace MKManager.AppService
{
    public class ClienteAppService
    {
        public void CadastrarCliente(ClienteModel cliente) => ClienteRepository.CadastrarCliente(cliente);
    }
}