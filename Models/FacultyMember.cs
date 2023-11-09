using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace library.Models
{
    public class FacultyMember: Member
    {
        [Display(Name = "Faculty College")]
        public string facultyCollege { get; set; }

        public void checkoutBook() {
        }

    }
}