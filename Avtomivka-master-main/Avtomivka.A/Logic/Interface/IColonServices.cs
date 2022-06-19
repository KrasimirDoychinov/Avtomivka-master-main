namespace Avtomivka.A.Logic.Interface
{
    using Avtomivka.A.Data.Models;
    using System.Threading.Tasks;

    public interface IColonServices : IBaseServices<Colon>
    {
        Task Create(int number);

        Task Update(string id, int number);

        Task Take(string id, string userId);

        Task UnTake(string id);
    }
}
