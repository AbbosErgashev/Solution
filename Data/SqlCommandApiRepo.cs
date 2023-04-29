using System.Threading.Tasks;
using System.Collections.Generic;
using Solution.Models;
using System;
using Solution.Data;
using Microsoft.EntityFrameworkCore;

namespace Solution.Data
{
    public class SqlCommandApiRepo : ICommandApiRepo
    {
        private readonly CommandContext _context;

        public SqlCommandApiRepo(CommandContext context)
        {
            _context = context;
        }

        public async Task CreateCommand(Command command)
        {
            if (command == null)
            {
                throw new ArgumentNullException(nameof(command));
            }

            await _context.Commands.AddAsync(command);
        }

        public void DeleteCommand(Command command)
        {
            if (command == null)
            {
                throw new ArgumentNullException(nameof(command));
            }

            _context.Commands.Remove(command);
        }

        public async Task<IEnumerable<Command>> GetAllCommands()
        {
            return await _context.Commands.ToListAsync();
        }

        public async Task<Command> GetCommandById(int id)
        {
            return await _context.Commands.FirstOrDefaultAsync(command => command.Id == id);
        }

        public Task UpdateCommand(Command command)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync() >= 0;
        }
    }
}