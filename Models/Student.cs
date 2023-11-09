using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace library.Models
{
    public class Student: Member
    {

        [Display(Name = "Student College")]
        public string studentCollege { get; set; }

        public void checkoutBook() {
        }

        public void returnBook() {
        }
    }
}