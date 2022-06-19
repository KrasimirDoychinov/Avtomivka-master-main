namespace Avtomivka.A.Logic
{
    using Avtomivka.A.Data;
    using Avtomivka.A.Data.Models;
    using Avtomivka.A.Logic.Interface;
    using System;
    using System.Threading.Tasks;

    public class ColonServices : BaseServices<Colon>, IColonServices
    {
        private readonly ApplicationDbContext context;

        private const string _table = nameof(Colon);
        public ColonServices(ApplicationDbContext context) 
            : base(context)
        {
            this.context = context;
        }
        public async Task Create(int number)
        {
            var colon = new Colon
            {
                Number = number
            };

            await this.context.Colons.AddAsync(colon);
            await this.context.SaveChangesAsync();
        }

        public async Task Take(string id, string userId)
        {
            var colon = this.ById(id);

            if (colon != null)
            {
                colon.Taken = true;
                colon.UserId = userId;
                colon.Modified = DateTime.Now;
                this.context.Colons.Update(colon);
                await this.context.SaveChangesAsync();
            }
        }

        public async Task UnTake(string id)
        {
            var colon = this.ById(id);

            if (colon != null)
            {
                colon.Taken = false;
                colon.Modified = DateTime.Now;
                this.context.Colons.Update(colon);
                await this.context.SaveChangesAsync();
            }
        }

        public async Task Update(string id, int number)
        {
            var colon = this.ById(id);

            if (colon != null)
            {
                colon.Number = number;
                colon.Modified = DateTime.Now;

                this.context.Colons.Update(colon);
                await this.context.SaveChangesAsync();
            }
        }
    }
}
