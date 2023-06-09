namespace MinerTech.Domain.Entities.Cargueiros.Dtos
{
    public class CargueiroDto
    {
        public int ClasseId { get; set; }
        public string? Classe { get; set; }
        public int MinerioId { get; set; }
        public string? Minerio { get; set; }
        public decimal PesoMinerio { get; set; }
    }
}
