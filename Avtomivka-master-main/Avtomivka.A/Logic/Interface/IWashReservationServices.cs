namespace Avtomivka.A.Logic.Interface
{
    using Avtomivka.A.Data.Models;
    using System;
    using System.Threading.Tasks;

    public interface IWashReservationServices : IBaseServices<WashReservation>
    {
        Task Create(string userId, string userName, DateTime reservationDate,
            string programId, string workerId, string colonId);

        Task Update(string id, string userName, DateTime reservationDate,
            string programId, string colonId);

        WashReservation ByColonId(string colonId);
    }
}
