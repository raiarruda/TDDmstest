
using aplicacao.Servicos;

namespace tests.Servicos;
[TestClass]
public class ValidacoesServicoTest
{
    [TestMethod]
    public void PalindromoValido_Sucesso()
    {
        //arrange
        var validacaoService = new ValidacoesServico();
        var palavra = "arara";

        //act
        var validaPalidromo = validacaoService.ValidarPalidromo(palavra);

        //assert
        Assert.IsTrue(validaPalidromo);

    }
    [TestMethod]
    public void PalindromoInvalido_Sucesso()
    {
        //arrange
        var validacaoService = new ValidacoesServico();
        var palavra = "araras";

        //act
        var validaPalidromo = validacaoService.ValidarPalidromo(palavra);

        //assert
        Assert.IsFalse(validaPalidromo);

    }
    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void PalindromoValidoParametroVazio_Falha()
    {
        //arrange
        var validacaoService = new ValidacoesServico();
        var palavra = "";

        //act
        var validaPalidromo = validacaoService.ValidarPalidromo(palavra);

        //assert
        var excecao = Assert.ThrowsException<ArgumentException>(() => validacaoService.ValidarPalidromo(palavra));
        Assert.AreEqual("A palavra de entrada não pode ser vazia.", excecao.Message);


    }

}
