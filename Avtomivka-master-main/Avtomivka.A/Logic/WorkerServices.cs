namespace Avtomivka.A.Logic
{
    using Avtomivka.A.Data;
    using Avtomivka.A.Data.Models;
    using Avtomivka.A.Logic.Interface;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class WorkerServices : BaseServices<Worker>, IWorkerServices
    { 
        private readonly ApplicationDbContext context;

        private const string _table = nameof(Worker);
        public WorkerServices(ApplicationDbContext context
            )
            : base(context)
        {
            this.context = context;
        }

        public async Task<string> Create(string name, int age, 
            string image, string description)
        {
            var worker = new Worker
            {
                Name = name,
                Age = age,
                Image = image,
                Description = description
            };

            await this.context.Workers.AddAsync(worker);
            await this.context.SaveChangesAsync();
            return worker.Id;
        }

        public async Task Update(string id, string name,
            int age, string image, string description)
        {
            var worker = this.ById(id);

            if (worker != null)
            {
                worker.Name = name;
                worker.Age = age;
                worker.Image = image;
                worker.Description = description;
                worker.Modified = DateTime.Now;

                this.context.Workers.Update(worker);
                await this.context.SaveChangesAsync();
            }
        }

        public IEnumerable<Worker> AllNotTaken()
            => this.context.Workers
            .Where(x => !x.Taken && !x.Delete);

        public async Task UpdateStatus(string id, bool taken)
        {
            var worker = this.ById(id);
            if (worker != null)
            {
                worker.Taken = taken;
                worker.Modified = DateTime.Now;

                this.context.Workers.Update(worker);
                await this.context.SaveChangesAsync();
            }
        }
    }
}
