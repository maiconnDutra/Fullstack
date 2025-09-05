using Aluno.Dominio;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class AlunoController : ControllerBase
{
    private readonly IAlunoServico _servico;

    public AlunoController(IAlunoServico servico)
    {
        _servico = servico;
    }

    [HttpPost]
    public IActionResult Post(Estudante estudante)
    {
        _servico.Adicionar(estudante);
        return Ok("Aluno cadastrado com sucesso!");
    }

    [HttpGet]
    public IActionResult Get()
    {
        return Ok(_servico.Listar());
    }
}