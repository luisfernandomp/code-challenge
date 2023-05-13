using MinerTech.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinerTech.Domain
{
    public class Retorno : BaseEntity
    {
        public DateTime DataSaida { get; private set; }
        public DateTime? DataRetorno { get; private set; }
        public DateTime DataCadastro { get; private set; }
        public int CargueiroId { get; set; }
        public Cargueiro Cargueiro { get; set; }
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }
        public ICollection<RetornoHistorico> RetornosHistorico { get; set; }
        public void CadastrarRetorno(DateTime dataSaida,
                                     DateTime dataRetorno,
                                     Cargueiro cargueiro,
                                     Usuario usuario)
        {
            Cargueiro = cargueiro;
            DataSaida = dataSaida;
            DataRetorno = dataRetorno;
            DataCadastro = DateTime.Now;
            Usuario = usuario; 
        }

        public bool VerificarHorario()
        {
            return false;
        }

        public bool VerificarDiaSemana()
        {
            return false;
        }

        public decimal CalcularTotalRecebimento()
        {
            return 0;
        }
    }
}
