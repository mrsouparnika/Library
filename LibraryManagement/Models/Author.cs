namespace LibraryManagement.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Author")]
    public partial class Author
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Author()
        {
            Books = new HashSet<Book>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(128)]
        [Display(Name = "Author")]
        public string AuthorName { get; set; }

        public int Age { get; set; }

        [Display(Name = "Gender")]
        public int GenderId { get; set; }

        [Display(Name = "Born In")]
        public int CountryId { get; set; }

        [Required]
        [StringLength(1024)]
        public string About { get; set; }

        public virtual Country Country { get; set; }

        public virtual Gender Gender { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Book> Books { get; set; }
    }
}
