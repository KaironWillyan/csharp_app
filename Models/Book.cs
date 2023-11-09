using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace library.Models
{
    public abstract class Book
    {
        [Display(Name = "Book ID")]
        public int Id { get; set; }
        [Display(Name = "Book Name")]
        public string BookName { get; set; }
        [Display(Name = "Author Name")]
        public string AuthorName { get; set; }
        [Display(Name = "Number of Pages")]
        public int NumberOfPages { get; set; }

    }
}