namespace aplicacao.Servicos;

public class ValidacoesServico
{
    public bool ValidarPalidromo(string palavra)
    {

         if (string.IsNullOrEmpty(palavra))
        {
            throw new ArgumentException("A palavra de entrada não pode ser vazia.");
        }
        
        var invertida = new string(palavra.Reverse().ToArray());

        return (palavra == invertida);
    }
}
