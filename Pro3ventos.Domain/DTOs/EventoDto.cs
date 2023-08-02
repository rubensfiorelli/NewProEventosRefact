namespace Pro3ventos.Domain.DTOs
{
    public class EventoDto
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Local { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataTermino { get; set; }
        public string ImgUrl { get; set; }
        public string WhatsApp { get; set; }
        public string Email { get; set; }
        //public List<Lote> Lotes { get; set; }
        //public List<RedeSocial> RedesSociais { get; set; }
        //public List<Palestrante> Palestrantes { get; set; }
        public DateTime CreateAt { get; set; }
    }
}
