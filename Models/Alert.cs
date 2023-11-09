using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace library.Models
{
    public class Alert
    {
        [Display(Name = "Alert ID")]
        public int Id { get; set; }
        [Display(Name = "Issue Date")]
        public DateOnly IssueDate { get; set; }
        [Display(Name = "Book Name")]
        public string BookName { get; set; }
        public DateOnly ReturnDate { get; set; }
        [Display(Name = "Return Date")]
        public int Fine { get; set; }

        public int fineCall() {
            return 0;
        }

        public void viewAlert() 
        {
        }

        public void sendToLibrarian() 
        {
        }

        public void deleteAlert() 
        {
        }
    }
}