using Aluno.Dominio;

public interface IAlunoServico
{
    void Adicionar(Estudante estudante);
    List<Estudante> Listar();
}