using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinerTech.Domain.Entities.Classes.Dtos
{
    public class ClasseResponseDto
    {
        public string Descricao { get; set; }
        public decimal Capacidade { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }
    }
}
