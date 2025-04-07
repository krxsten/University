using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using university.Data;
using university.Data.Models;

namespace university.Conerollers
{
    public class UniversityControllers
    {
        public void AddUniversity(string name)
        {
            UniversityDBContext context = new UniversityDBContext();
            University university = new University(1, name, new List<Faculty>());
            context.Universities.Add(university);
        }

        public List<University> GetAllUniversities()
        {
           UniversityDBContext context = new UniversityDBContext();
           return context.Universities.ToList();
        }

        public University GetUniversityByName(string name)
        {
            UniversityDBContext context = new UniversityDBContext();
            return context.Universities.FirstOrDefault(x => x.Name == name);
        }

        public int GetUniversityIdByName(string name)
        {
            UniversityDBContext context = new UniversityDBContext();
            University university = context.Universities.FirstOrDefault(u => u.Name == name);
            return university.ID;
        }
    }
}
