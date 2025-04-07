using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace university.Data.Models
{
    public class University
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public List<Faculty> Faculties { get; set; } = new List<Faculty>();

        public University(int iD, string name, List<Faculty> faculties)
        {
            ID = iD;
            Name = name;
            Faculties = faculties;
        }
    }
}
