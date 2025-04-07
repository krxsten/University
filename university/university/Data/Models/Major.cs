using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace university.Data.Models
{
    public class Major
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [ForeignKey(nameof(Faculty))]
        public int FacultyID { get; set; }
        public Faculty Faculty { get; set; }
        public Major(int iD, string name, int facultyID)
        {
            ID = iD;
            Name = name;
            FacultyID = facultyID;
        }

    }
}
