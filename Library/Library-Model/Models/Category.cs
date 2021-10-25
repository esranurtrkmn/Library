using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Model.Models
{  
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Column("Name")]
        [Required]
        public string CategoryName { get; set; }
    }
}
