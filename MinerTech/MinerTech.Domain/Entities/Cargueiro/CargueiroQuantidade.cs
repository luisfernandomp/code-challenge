using MinerTech.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinerTech.Domain
{
    public class CargueiroQuantidade : BaseEntity
    {
        public int Quantidade { get; private set; }
        public int CargueiroId { get; set; }
        public Cargueiro Cargueiro { get; set; }
        
        public void CadastrarCargueiroQuantidade(int quantidade, Cargueiro cargueiro)
        {
            Quantidade = quantidade;
            Cargueiro = cargueiro;
        }

    }
}
