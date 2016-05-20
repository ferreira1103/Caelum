using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRM01;

namespace CRM01
{
    public class Relacionamento
    {
        //Metodo construtor vazio
        public Relacionamento() { }

        //Propriedades/Atributos
        //... variáveis de trabalho

        //Metodos get/set
        public string Codigo { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string ComplementoEndereco { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Nascimento { get; set; }
    }
}
