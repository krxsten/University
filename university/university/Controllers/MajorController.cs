using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using university.Data;
using university.Data.Models;

namespace university.Controllers
{
    public class MajorController
    {
        public void AddMajor(string name, int facultyID)
        {
            UniversityDBContext context = new UniversityDBContext();
            Major major = new Major(1, name, facultyID);
            context.Majors.Add(major);
        }
        public List<Major> GetMajorsByFacultyId(int facultyid)
        {
            UniversityDBContext context = new UniversityDBContext();
            var major=context.Majors.Where(x=>x.FacultyID == facultyid).ToList();
            return major;
        }
        public List<Major> GetMajorsByName(string name)
        {
            UniversityDBContext context = new UniversityDBContext();
            var major = context.Majors.Where(x => x.Name == name).ToList();
            return major;
        }
        public Major GetMajorByNameAndFacultyId(string name, int facultyId)
        {
            UniversityDBContext context = new UniversityDBContext();
            var major = context.Majors.FirstOrDefault(x => x.Name == name && x.FacultyID==facultyId);
            return major;
        }

    }
}
