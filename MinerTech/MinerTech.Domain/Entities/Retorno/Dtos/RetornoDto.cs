using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinerTech.Domain
{
    public class RetornoDto
    {
        public DateTime DataSaida { get; set; }
        public DateTime? DataRetorno { get; set; }
        public DateTime DataCadastro { get; set; }
        public decimal Total { get; set; }
        public int UsuarioId { get; set; }
        public List<CargueiroDto> Cargueiros { get; set; }
    }
}
