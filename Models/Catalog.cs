using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace library.Models
{
    public class Catalog
    {
        [Display(Name = "Catalog ID")]
        public int Id { get; set; }
        [Display(Name = "Author Name")]
        public string AuthorName { get; set; }
        [Display(Name = "Number of Copies")]
        public int NumberOfCopies { get; set; }
        [Display(Name = "Number of Available Copies")]
        public virtual ICollection<Book> Books { get; set; }

        public void updateInfo() 
        {
        }

        public void searchBook() 
        {
        }

    }
}