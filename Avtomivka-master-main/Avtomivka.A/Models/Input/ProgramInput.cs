namespace Avtomivka.A.Models.Input
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class ProgramInput
    {
        public string Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        [Range(0, 100)]
        public double Price { get; set; }

        [Required]
        public string Description { get; set; }

    }
}
