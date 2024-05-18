using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploFundamentos.Common.Models
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        DateTime dataAtual = DateTime.Now.AddDays(5);

        public void Apresentar()
        {
            Console.WriteLine($"Óla, meu nome é {Nome}.\nTenho {Idade} anos.\n{dataAtual.ToString("dd/MM/yyyy HH:mm")}");
        }
    }
}
