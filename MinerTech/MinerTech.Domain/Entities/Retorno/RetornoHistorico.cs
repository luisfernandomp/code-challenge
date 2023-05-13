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
        public void CadastrarHistorico
            (
            int quantidadeAtual,
            int quantidade,
            DateTime dateCadastro,
            Retorno retorno,
            Usuario usuario)
        {
            QuantidadeAnterior = 1;
            QuantidadeAtual = quantidadeAtual;
            Quantidade = quantidade;
            DateCadastro = dateCadastro;
            Retorno = retorno;
            Usuario = usuario;
        }

        public int QuantidadeAnterior { get; private set; }
        public int QuantidadeAtual { get; private set; }
        public int Quantidade { get; private set; }
        public DateTime DateCadastro { get; private set; }
        public int RetornoId {get; set; }
        public Retorno Retorno { get; set; }
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }
   
    }
}
