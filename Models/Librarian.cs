using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace library.Models
{
    public class Librarian
    {
        [Display(Name = "Librarian ID")]
        public int Id { get; set; }
        [Display(Name = "Name")]
        public string name { get; set; }
        [Display(Name = "Address")]
        public string adress { get; set; }
        [Display(Name = "Phone Number")]
        public string phoneNumber { get; set; }

        public void updateInfo() {
            Console.WriteLine("Info Updated");
        }

        public void issueBooks() {
            Console.WriteLine("Book Issued");
        }

        public void memberInfo() {
            Console.WriteLine("Member Info");
        }

        public void searchBook() {
            Console.WriteLine("Book Searched");
        }

        public void returnBook() {
            Console.WriteLine("Book Returned");
        }
    }
}