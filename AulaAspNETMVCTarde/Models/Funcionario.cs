using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AulaAspNETMVCTarde.Models
{
    public class Funcionario
    {
        public int IdFuncionario { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Funcao { get; set; }
    }
}
