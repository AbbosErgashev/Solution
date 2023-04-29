using System.Collections.Generic;
using System.Threading.Tasks;
using Solution.Datas.SavingDatasAsync;
using Solution.Models;

namespace Solution.Interfaces
{
    public interface IUserApiRepo : ISaveChangesAsync
    {
        Task<IEnumerable<User>> GetAllUsers();

        Task<User> GetUserById(int id);

        Task CreateUser(User user);

        Task UpdateUser(User user);

        void DeleteUser(User user);
    }
}