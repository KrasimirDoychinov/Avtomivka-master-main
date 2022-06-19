namespace Avtomivka.A.Logic.Interface
{
    using System.Threading.Tasks;

    public interface IProgramServices : IBaseServices<Data.Models.Program>
    {
        Task Create(string name, double price,
            string description);

        Task Update(string id, string name,
            double price, string description);
    }
}
