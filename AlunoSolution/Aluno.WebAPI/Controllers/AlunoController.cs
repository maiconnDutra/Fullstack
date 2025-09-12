using Aluno.Dominio;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class EstudanteController : ControllerBase
{
    private readonly IAlunoServico _servico;

    public EstudanteController(IAlunoServico servico)
    {
        _servico = servico;
    }

    [HttpPost]
    public IActionResult Post(Estudante estudante)
    {
        _servico.Adicionar(estudante); // Alterado para aceitar o objeto completo
        return Ok("Estudante cadastrado!");
    }

    [HttpGet]
    public IActionResult Get() => Ok(_servico.ObterTodos());
}