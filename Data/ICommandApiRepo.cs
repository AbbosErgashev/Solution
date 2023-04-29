using System.Collections.Generic;
using System.Threading.Tasks;
using Solution.Models;

namespace Solution.Data
{
    public interface ICommandApiRepo
    {
        Task<IEnumerable<Command>> GetAllCommands();

        Task<Command> GetCommandById(int id);

        Task CreateCommand(Command command);

        Task UpdateCommand(Command command);

        void DeleteCommand(Command command);

        public Task<bool> SaveChangesAsync();
    }
}
