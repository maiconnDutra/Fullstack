using Aluno.Dominio;
using Aluno.Repositorio;

public class AlunoRepositorio : IAlunoRepositorio
{
    private readonly EstudanteDbContext _context;

    public AlunoRepositorio(EstudanteDbContext context)
    {
        _context = context;
    }

    public void Adicionar(Estudante estudante)
    {
        _context.Estudantes.Add(estudante);
        _context.SaveChanges();
    }

    public List<Estudante> Listar()
    {
        return _context.Estudantes.ToList();
    }

    // Adicionar os métodos faltantes:

    public List<Estudante> ObterTodos()
    {
        return _context.Estudantes.ToList();
    }

    public Estudante ObterPorId(int id)
    {
        return _context.Estudantes.FirstOrDefault(e => e.Id == id);
    }

    public void Atualizar(Estudante estudante)
    {
        _context.Estudantes.Update(estudante);
        _context.SaveChanges();
    }

    public void Remover(int id)
    {
        var estudante = _context.Estudantes.FirstOrDefault(e => e.Id == id);
        if (estudante != null)
        {
            _context.Estudantes.Remove(estudante);
            _context.SaveChanges();
        }
    }
}
