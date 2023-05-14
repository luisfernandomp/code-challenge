using MinerTech.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinerTech.Domain
{
    public class RetornoHistorico : BaseEntity
    {
        public int QuantidadeAnterior { get; private set; }
        public int QuantidadeAtual { get; private set; }
        public int Quantidade { get; private set; }
        public DateTime DateCadastro { get; private set; }
        public int CargueiroId {get; set; }
        public Cargueiro Cargueiro { get; set; }
        public int MinerioId { get; set; }
        public Minerio Minerio { get; set; }
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }

        public void CadastrarHistorico
            (
            int quantidadeAtual,
            int quantidadeAnterior,
            int quantidade,
            Usuario usuario)
        {
            QuantidadeAnterior = quantidadeAnterior;
            QuantidadeAtual = quantidadeAtual;
            Quantidade = quantidade;
            DateCadastro = DateTime.Now;
            Usuario = usuario;
        }

    }
}
