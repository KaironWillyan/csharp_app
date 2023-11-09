using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace library.Models
{
    public abstract class Member
    {
        [Display(Name = "Member ID")]
        public int Id { get; set; }
        [Display(Name = "Name")]
        public string Name { get; set; }
        [Display(Name = "Adress")]
        public string Adress { get; set; }
        [Display(Name = "Phone")]
        public int Phone { get; set; }
        [Display(Name = "Books")]
        public virtual ICollection<Book> Books { get; set; }

        public void requestForBook() 
        {
        }

        public void returnBook() 
        {
        }
    }


}