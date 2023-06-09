using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinerTech.Domain.Entities.Minerios.Dtos
{
    public class MinerioResponseDto
    {
        public string Codigo { get; set; }
        public string Caracteristica { get; set; }
        public bool Ativo { get; set; }
    }
}
