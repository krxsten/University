using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace university.Data.Models
{
    public class Faculty
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [ForeignKey(nameof(University))]
        public int UniversityID { get; set; }
        public University University { get; set; }
        public List<Major> Majors { get; set; }= new List<Major>();
        public Faculty(int iD, string name, int universityID, List<Major> majors)
        {
            ID = iD;
            Name = name;
            UniversityID = universityID;
            Majors = majors;
        }
    }
}
