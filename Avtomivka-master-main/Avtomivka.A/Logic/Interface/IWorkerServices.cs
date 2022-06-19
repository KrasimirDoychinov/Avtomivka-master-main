namespace Avtomivka.A.Logic.Interface
{
    using Avtomivka.A.Data.Models;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IWorkerServices : IBaseServices<Worker>
    {
        Task<string> Create(string name, int age, string image, string description);

        Task Update(string id, string name,
            int age, string image, string description);

        IEnumerable<Worker> AllNotTaken();

        Task UpdateStatus(string id, bool taken);
    }
}
