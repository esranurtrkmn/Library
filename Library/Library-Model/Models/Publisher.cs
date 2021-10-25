using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Model.Models
{
    public class Publisher
    {
        [Key]
        public int Id { get; set; }

        [Column("Name")]
        [Required]
        public string PublisherName { get; set; }

        [Required]
        public string Location { get; set; }
        
        public List<Book> Books { get; set; }
    }
}
