using aplicacao.BancoDeDados;
using aplicacao.Entidades;


namespace aplicacao.Servicos;

public class ClienteServico{


private BancoContexto _bdContexto;
private static List<Cliente> clientes = new List<Cliente>();
    public ClienteServico(BancoContexto bdContexto){
        _bdContexto= bdContexto;
    }

    

    public List<Cliente> Todos()
    {
        return clientes;
    }

    public void Salvar(Cliente cliente)
    {
        clientes.Add(cliente);
    }
}
