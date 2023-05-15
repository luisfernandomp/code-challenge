using MinerTech.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinerTech.Domain
{
    public class ClasseMinerioCompativel : BaseEntity
    {
        public ClasseMinerioCompativel(Minerio minerio, Classe classe)
        {
            Minerio = minerio;
            Classe = classe;
        }

        public ClasseMinerioCompativel()
        {

        }

        public int MinerioId { get; set; }
        public Minerio Minerio { get; set; }
        public int ClasseId { get; set; }
        public Classe Classe { get; set; }
    }
}
