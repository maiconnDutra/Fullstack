using Aluno.Dominio;

public class AlunoServico : IAlunoServico
{
    private readonly IAlunoRepositorio _repositorio;

    // 💡 Injeção de dependência via construtor
    public AlunoServico(IAlunoRepositorio repositorio)
    {
        _repositorio = repositorio;
    }

    public void AdicionarEstudante(Estudante estudante)
    {
        _repositorio.Adicionar(estudante); // Passa o objeto completo
    }
}