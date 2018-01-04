namespace LibraryManagement.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Book")]
    public partial class Book
    {
        public int Id { get; set; }

        [Required]
        [StringLength(128)]
        [Display(Name = "Book")]
        public string BookName { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "ISBN Number")]
        public string ISBN { get; set; }

        [Required]
        [StringLength(1024)]
        public string Description { get; set; }

        [Display(Name = "Author")]
        public int AuthorId { get; set; }

        public virtual Author Author { get; set; }
    }
}
