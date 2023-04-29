using System.Threading.Tasks;
using System.Collections.Generic;
using Solution.Models;
using System;
using Microsoft.EntityFrameworkCore;
using Solution.Interfaces;
using Solution.Datas.Contexts;

namespace Solution.Repositories
{
    public class SqlCommandApiRepo : ICommandApiRepo
    {
        private readonly ApplicationDbContext _context;

        public SqlCommandApiRepo(ApplicationDbContext context)
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

        public async Task UpdateCommand(Command command)
        {
            ///
        }

        public async Task<bool> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync() >= 0;
        }
    }
}