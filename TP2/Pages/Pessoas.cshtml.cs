using TP2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TP2.Pages
{
    public class PessoasModel : PageModel
    {
        public List<Pessoa> PessoasList { get; set; }
        public void OnGet()
        {
            PessoasList = new List<Pessoa>();

            PessoasList.Add(new Pessoa { Nome = "Joaquim", Cpf = "457.637.947-02", Idade = 56 });
            PessoasList.Add(new Pessoa { Nome = "Marcia", Cpf = "777.578.701-51", Idade = 19 });
            PessoasList.Add(new Pessoa { Nome = "Leon", Cpf = "054.479.696-97", Idade = 46 });
            PessoasList.Add(new Pessoa { Nome = "Carlos", Cpf = "177.852.746-00", Idade = 45 });
            PessoasList.Add(new Pessoa { Nome = "Melissa", Cpf = "133.789.963-88", Idade = 27 });
        }
    }
}
