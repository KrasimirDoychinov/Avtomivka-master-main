namespace Avtomivka.A.Logic.Interface
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IBaseServices<T>
        where T : class
    {
        IEnumerable<T> All();

        IEnumerable<T> ForExport();

        T ById(string id);

        Task<bool> Delete(string id, string table);
    }
}
