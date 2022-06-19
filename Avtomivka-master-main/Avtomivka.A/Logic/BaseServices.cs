namespace Avtomivka.A.Logic
{
    using Avtomivka.A.Data;
    using Avtomivka.A.Data.Models;
    using Avtomivka.A.Logic.Interface;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class BaseServices<T> : IBaseServices<T> 
        where T : BaseModel
    {
        private readonly ApplicationDbContext context;

        public BaseServices(ApplicationDbContext context)
        {
            this.context = context;
        }

        public IEnumerable<T> All()
            => this.context
            .Set<T>()
            .Where(x => !x.Delete)
            .OrderByDescending(x => x.Modified)
            .ToList();

        public IEnumerable<T> ForExport()
            => this.context
            .Set<T>();

        public T ById(string id)
            => this.context
            .Set<T>()
            .FirstOrDefault(x => x.Id == id);

        public async Task<bool> Delete(string id, string table)
        {
            var item = this.ById(id);
            if (item != null)
            {
                item.Delete = true;
                item.Modified = DateTime.Now;
                return true;
            }

            await this.context.SaveChangesAsync();
            return false;
        }
    }
}
