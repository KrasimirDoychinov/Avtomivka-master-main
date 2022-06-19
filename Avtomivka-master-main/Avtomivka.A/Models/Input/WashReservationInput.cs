namespace Avtomivka.A.Models.Input
{
    using Avtomivka.A.Attributes;
    using Avtomivka.A.Data.Models;
    using Avtomivka.A.Models.View;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class WashReservationInput : BaseVM
    {
        public string ColonId { get; set; }

        [Required]
        [ReservationDateValidation]
        public DateTime ReservationDate { get; set; } = DateTime.Now;

        [Required]
        [Display(Name = "Program")]
        public string ProgramId { get; set; }

        public IEnumerable<Data.Models.Program> Programs { get; set; }

        [Required]
        [Display(Name = "Worker")]
        public string WorkerId { get; set; }

        public IEnumerable<Worker> Workers { get; set; }

        
    }
}
