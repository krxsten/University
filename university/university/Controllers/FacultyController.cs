using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using university.Data;
using university.Data.Models;

namespace university.Controllers
{
    public class FacultyController
    {
        public void AddFaculty(string name, int universityID)
        {
            UniversityDBContext context = new UniversityDBContext();
            Faculty faculty = new Faculty(1, name, universityID, new List<Major>());
            context.Faculties.Add(faculty);
        }

        public List<Faculty> GetFacultiesByUniversityId(int universityId)
        {
            UniversityDBContext context = new UniversityDBContext();
            var faculty=context.Faculties.Where(x => x.UniversityID == universityId).ToList();
            return faculty;
        }

        public List<Faculty> GetFacultiesByName(string name)
        {
            UniversityDBContext context = new UniversityDBContext();
            var faculty=context.Faculties.Where(x => x.Name == name).ToList();
            return faculty.ToList();
        }

        public Faculty GetFacultyByNameAndUniversityId(string name, int universityId)
        {
            UniversityDBContext context = new UniversityDBContext();
            var faculty = context.Faculties.FirstOrDefault(x=>x.UniversityID == universityId && x.Name == name);
            return faculty;
        }
    }
}
