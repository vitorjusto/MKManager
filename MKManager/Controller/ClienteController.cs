using MKManager.Model;
using MKManager.Repository;

namespace MKManager.Controller
{
    public class ClienteController
    {
        public void CadastrarCliente(ClienteModel cliente) => ClienteRepository.CadastrarCliente(cliente);
    }
}