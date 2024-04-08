using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterometro.Domain
{
    public class AtorContagem 
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public int Contador { get; set; }
        public DateTime DataContagem { get; set; }

        public AtorContagem(string nome, int contador, DateTime dataContagem)
        {
            Nome = nome;
            Contador = contador;
            DataContagem = dataContagem;
        }
    }
}
