using Pro3ventos.Application.Input.Commands.Interfaces;

namespace Pro3ventos.Application.Input.Handlers.Interfaces
{
    public interface IHandler<in T, out W> where T : ICommand where W : State
    {
        W Action(T command);
    }
}
