using System.Threading.Tasks;

namespace ProjectStructure.BusinessActor.Commands
{
    public interface ICommandHandler<TCommand>
    {
        /// <summary>
        /// Run Command
        /// </summary>
        /// <param name="command">Command model</param>
        /// <returns>Task</returns>
        Task HandleAsync(TCommand command);
    }

    public interface ICommandHandler<TCommand,TResult>
    {
        /// <summary>
        /// Run Command
        /// </summary>
        /// <param name="command">Command model</param>
        /// <returns>Task</returns>
        Task<TResult> HandleAsync(TCommand command);
    }

}
