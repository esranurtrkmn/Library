using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Model.Models
{
    public class Writer
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Surname { get; set; }

        public List<BookWriter> BookWriters { get; set; }

        [NotMapped]
        public string NameSurname
        {
            get
            {
                return $"{Name}  {Surname}";
                
            }

        }


    }
}
