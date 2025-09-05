using Aluno.Dominio;

public class AlunoRepositorio : IAlunoRepositorio
{
    private static List<Estudante> _estudantes = new();

    public void Adicionar(Estudante estudante)
    {
        _estudantes.Add(estudante);
    }

    public List<Estudante> Listar()
    {
        return _estudantes;
    }
}