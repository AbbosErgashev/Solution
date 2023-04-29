using System.Threading.Tasks;

namespace Solution.Datas.SavingDatasAsync
{
    public interface ISaveChangesAsync
    {
        public Task<bool> SaveChangesAsync();
    }
}