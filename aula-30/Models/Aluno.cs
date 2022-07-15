namespace aula_30.Models
{
    public class Aluno
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }

        public Instituicao Instituicao { get; set; }

        public int InstituicaoId { get; set; }
    }
}
