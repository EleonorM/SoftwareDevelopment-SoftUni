﻿namespace MusicHub.DataProcessor.ImportDtos
{
    using System.ComponentModel.DataAnnotations;

    public class ImportWriterDto
    {
        [Required]
        [MaxLength(20), MinLength(3)]
        public string Name { get; set; }

        [RegularExpression(@"[A-Z][a-z]+ [A-Z][a-z]+")]
        public string Pseudonym { get; set; }
    }
}
