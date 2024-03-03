namespace TP2.Models
{
    public class Pessoa
    {
        private string nome;
        private int idade;
        private string cpf;

        public string Nome { get => nome; set => nome = value; }
        public int Idade { get => idade; set => idade = value; }
        public string Cpf { get => cpf; set => cpf = value; }
    }
}
