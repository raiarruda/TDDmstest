// using Microsoft.VisualStudio.TestTools.UnitTesting;
using aplicacao.Servicos;
using aplicacao.BancoDeDados;
using aplicacao.Entidades;
namespace tests;

[TestClass]
public class ClienteServicoTest
{
    [TestMethod]
    public void ClienteServicoEhDefinido()
    {
    
        var clienteServico = new ClienteServico(new BancoContexto());

        Assert.IsNotNull(clienteServico);
    }
    [TestMethod]
    public void DeveRetornarListaDeClientesVazia()
    {
        List<Cliente> clientes;

        var clienteServico = new ClienteServico(new BancoContexto());
        clientes = clienteServico.Todos();

        Assert.IsNotNull(clienteServico);
        Assert.AreEqual(0,clientes.Count);
    }

    [TestMethod]
    public void DeveSalvarClienteNaLista()
    {
        List<Cliente> clientes;
        var cliente = new Cliente();
        cliente.nome = "Raissa";
        
        var clienteServico = new ClienteServico(new BancoContexto());
        clienteServico.Salvar(cliente);
        clientes = clienteServico.Todos();

        Assert.IsNotNull(clienteServico);
        Assert.AreEqual(1,clientes.Count);
        Assert.AreEqual(cliente, clientes.First());
        Assert.AreEqual("Raissa", clientes.First().nome);
    }

    [TestMethod]
    public void DeveRetornarListaDeClientesUmElemento()
    {
        List<Cliente> clientes;

        var clienteServico = new ClienteServico(new BancoContexto());
        clientes = clienteServico.Todos();

        Assert.IsNotNull(clienteServico);
        Assert.AreEqual(1,clientes.Count);
    }
}