
namespace Aluno.Dominio
{
    public class Aluno
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }

        public bool EMaiorDeIdade()
        {
            return Idade >= 18;
        }
    }
}
