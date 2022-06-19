namespace Avtomivka.A.Logic
{
    using Avtomivka.A.Data;
    using Avtomivka.A.Data.Models;
    using Avtomivka.A.Logic.Interface;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    public class WashReservationServices : BaseServices<WashReservation>, IWashReservationServices
    {
        private readonly ApplicationDbContext context;

        private const string _table = nameof(WashReservation);
        public WashReservationServices(ApplicationDbContext context) 
            : base(context)
        {
            this.context = context;
        }

        public async Task Create(string userId, string userName, DateTime reservationDate, 
            string programId, string workerId, string colonId)
        {

            var reservation = new WashReservation
            {
                UserName = userName,
                ReservationDate = reservationDate,
                ProgramId = programId,
                WorkerId = workerId,
                ColonId = colonId,
                UserId = userId
            };

            await this.context.WashReservations.AddAsync(reservation);
            await this.context.SaveChangesAsync();
        }


        public async Task Update(string id, string userName, DateTime reservationDate, 
            string programId, string colonId)
        {
            var reservation = this.ById(id);

            if (reservation != null)
            {
                reservation.UserName = userName;
                reservation.ReservationDate = reservationDate;
                reservation.ProgramId = programId;
                reservation.ColonId = colonId;

                this.context.WashReservations.Update(reservation);
                await this.context.SaveChangesAsync();
            }
        }

        public WashReservation ByColonId(string colonId)
            => this.context.WashReservations
            .FirstOrDefault(x => x.ColonId == colonId);

    }
}
