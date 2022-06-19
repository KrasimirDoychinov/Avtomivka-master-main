namespace Avtomivka.A.Data.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class WashReservation : BaseModel
    {
        [Required]
        public string UserName { get; set; }

        public string UserId { get; set; }

        public virtual User User { get; set; }

        [Required]
        public DateTime ReservationDate { get; set; }

        public string ProgramId { get; set; }

        public virtual Program Program { get; set; }

        public string WorkerId { get; set; }

        public virtual Worker Worker { get; set; }

        public string ColonId { get; set; }

        public virtual Colon Colon { get; set; }
    }
}
