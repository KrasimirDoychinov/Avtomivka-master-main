namespace Avtomivka.A.Logic
{
    using Avtomivka.A.Data;
    using Avtomivka.A.Logic.Interface;
    using System;
    using System.Threading.Tasks;

    public class ProgramServices : BaseServices<Data.Models.Program>,IProgramServices
    {
        private readonly ApplicationDbContext context;

        private const string _table = nameof(Data.Models.Program);
        public ProgramServices(ApplicationDbContext context)
            : base(context)
        {
            this.context = context;
        }

        public async Task Create(string name, double price, 
            string description)
        {
            var program = new Data.Models.Program
            {
                Name = name,
                Price = price,
                Description = description
            };

            await this.context.Programs.AddAsync(program);
            await this.context.SaveChangesAsync();
        }

        public async Task Update(string id, string name, 
            double price, string description)
        {
            var program = this.ById(id);

            if (program != null)
            {
                program.Name = name;
                program.Price = price;
                program.Description = description;
                program.Modified = DateTime.Now;
            }

            this.context.Programs.Update(program);
            await this.context.SaveChangesAsync();
        }
    }
}
