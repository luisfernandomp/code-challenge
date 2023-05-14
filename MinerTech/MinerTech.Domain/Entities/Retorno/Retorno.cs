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
        public decimal Total { get; private set; }
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }
        public IList<RetornoCargueiro> RetornosCargueiro { get; set; }
        public IList<RetornoHistorico> RetornosHistorico { get; set; }
        public void CadastrarRetorno(DateTime dataSaida,
                                     DateTime? dataRetorno,
                                     Usuario usuario)
        {
            DataSaida = dataSaida;
            DataRetorno = dataRetorno;
            DataCadastro = DateTime.Now;
            Usuario = usuario; 
        }

        public bool VerificarHorario()
        {
            if(DataSaida.Hour < 8)
                return false;

            return true;
        }

        public bool VerificarDiaSemana()
        {
            if(DateTime.Now.DayOfWeek == DayOfWeek.Sunday) 
                return false;

            return true;
        }
        
        private void AlterarTotal(decimal total)
        {
            Total = total;
        }

        public void CalcularTotalRecebimento()
        {
            decimal totalRecebimento = 0;

            foreach (var item in RetornosCargueiro)
            {
                totalRecebimento += item.CalcularPrecoTotal();
            }

            AlterarTotal(totalRecebimento);
        }

        public void AlocarCargueiroMineiro()
        {
            foreach (var item in RetornosCargueiro)
            {
                item.AlocarMinerioCargueiro();
            }
        }
    }
}
