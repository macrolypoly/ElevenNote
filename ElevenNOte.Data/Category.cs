using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevenNOte.Data
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        [Required]
        [Display(Name = "Category Name")]
        public string CategoryName { get; set; }
        //public ICollection<Note> Notes {get; set;}
    }
}
