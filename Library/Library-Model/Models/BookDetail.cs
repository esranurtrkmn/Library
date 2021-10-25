using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Model.Models
{
    public class BookDetail
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int PageCount { get; set; }

        [Required]
        public int EpisodeCount { get; set; }

        public Book Book { get; set; }

    }
}
