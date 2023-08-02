using Pro3ventos.Application.Input.Commands.Interfaces;

namespace Pro3ventos.Application.Input.Commands.EventoContext
{
    public class EventoCommand : ICommand
    {
        public string Nome { get; set; }
        public string Local { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataTermino { get; set; }
        public string ImgUrl { get; set; }
        public string WhatsApp { get; set; }
        public string Email { get; set; }
    }
}
