using Aluno.Dominio;

public class AlunoServico : IAlunoServico
{
    private readonly IAlunoRepositorio _repositorio;

    public AlunoServico(IAlunoRepositorio repositorio)
    {
        _repositorio = repositorio;
    }

    public void Adicionar(Estudante estudante)
    {
        if (string.IsNullOrWhiteSpace(estudante.Nome))
            throw new Exception("O nome do aluno é obrigatório.");

        _repositorio.Adicionar(estudante);
    }

    public List<Estudante> Listar()
    {
        return _repositorio.Listar();
    }
}