using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookList.Models
{
    public class Book
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string name { get; set; }
        public string author { get; set; }
    }
}