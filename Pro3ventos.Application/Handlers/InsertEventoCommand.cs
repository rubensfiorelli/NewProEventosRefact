using Pro3ventos.Application.Input.Commands.EventoContext;
using Pro3ventos.Application.Input.Handlers.Interfaces;
using Pro3ventos.Domain.Entities;
using Pro3ventos.Domain.Interfaces.Repositories;

namespace Pro3ventos.Application.Input.Handlers
{
    public class InsertEventoCommand : IHandler<EventoCommand, State>
    {
        private readonly IWriteEventoRepository _repository;

        public InsertEventoCommand(IWriteEventoRepository repository)
        {
            _repository = repository;
        }

        public State Action(EventoCommand command)
        {
            var evento = new Evento(command.Nome, command.Local, command.DataTermino, command.ImgUrl, command.WhatsApp, command.Email);

            if (!evento.IsValid())
                return new State(400, "Erro ao inserir evento", evento.Notifications);

            try
            {
                using (_repository.InsertEvento(evento))
                {
                    return new State(201, "Evento criado com sucesso", evento);
                }
            }
            catch (Exception ex)
            {

                return new State(500, ex.Message, null);
            }

        }
    }
}
