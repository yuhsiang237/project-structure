using System.Threading.Tasks;

namespace ProjectStructure.DataAccessor.Commands
{
    public interface IOrderCommand
    {
        /// <summary>
        /// InsertAsync
        /// </summary>
        /// <param name="command">OrderCommandModel</param>
        /// <returns>Task</returns>
        public Task InsertAsync(OrderCommandModel command);

        /// <summary>
        /// UpdateAsync
        /// </summary>
        /// <param name="command">OrderCommandModel</param>
        /// <returns>Task</returns>
        public Task UpdateAsync(OrderCommandModel command);

        /// <summary>
        /// DeleteAsync
        /// </summary>
        /// <param name="command">OrderCommandModel</param>
        /// <returns>Task</returns>
        public Task DeleteAsync(OrderCommandModel command);
    }
}
