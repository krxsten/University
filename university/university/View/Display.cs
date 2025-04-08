using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using university.Conerollers;
using university.Controllers;
using university.Data.Models;

namespace university.View
{
    public class Display
    {
        public UniversityControllers universityController = new UniversityControllers();
        public FacultyController facultyController = new FacultyController();
        public MajorController majorController = new MajorController();
        public void ShowMenu()
        {
            Console.WriteLine("1.Add university");
            Console.WriteLine("2.Add faculty");
            Console.WriteLine("3.Add major");
            Console.WriteLine("4.Show all universities");
            Console.WriteLine("5.Show faculties by university ID");
            Console.WriteLine("6.Show majors by faculty ID");
            Console.WriteLine("7.Show university ID by name");
            Console.WriteLine("8.Show faculty ID and name by name");
            Console.WriteLine("9.Show major ID and name by name");
            Console.WriteLine("10.Exit");
            Console.WriteLine("Вашият избор: ");
            string[] command = Console.ReadLine().Split();
            while (command[0] != "Exit")
            {
                switch (command[0])
                {
                    case "Add university":
                        InputUniversity();
                        break;
                    case "Add faculty":
                        InputFaculty();
                        break;
                    case "Add major":
                        InputMajor();
                        break;
                    case "Show all universities":
                        GetAllUniversities();
                        break;
                    case "Show faculties by university ID":
                        GetFacultiesByUniversityId();
                        break;
                    case "Show majors by faculty ID":
                        GetMajorsByFacultyId();
                        break;
                    case "Show university ID by name":
                        GetUniversityIdByName();
                        break;
                    case "Show faculty ID and name by name":
                        GetFacultyIdAndNameByName();
                        break;
                    case "Show major ID and name by name":
                        GetMajorIdAndNameByName();
                        break;
                }
                command = Console.ReadLine().Split();
            }

        }

        public void InputUniversity()
        {
            Console.WriteLine("Въведете име на университет: ");
            string nameUni = Console.ReadLine();
            universityController.AddUniversity(nameUni);
        }

        public void InputFaculty()
        {
            Console.WriteLine("Въведете име на факултет: ");
            string name = Console.ReadLine();
            Console.WriteLine("Въведете ID: ");
            int id = int.Parse(Console.ReadLine());
            facultyController.AddFaculty(name, id);
        }

        public void InputMajor()
        {
            Console.WriteLine("Въведете име: ");
            string name = Console.ReadLine();
            Console.WriteLine("Въведете ID: ");
            int id = int.Parse(Console.ReadLine());
            majorController.AddMajor(name, id);
        }

        public void GetAllUniversities()
        {
            var universities = universityController.GetAllUniversities();
            foreach (var item in universities)
            {
                Console.WriteLine($"ID: {item.ID} Name: {item.Name}");
            }
        }

        public void GetFacultiesByUniversityId()
        {
            Console.Write("Въведете ID на университет: ");
            int id = int.Parse(Console.ReadLine());
            var faculties = facultyController.GetFacultiesByUniversityId(id);
            foreach (var item in faculties)
            {
                Console.WriteLine($"ID: {item.ID} Name: {item.Name}");
            }
        }

        public void GetMajorsByFacultyId()
        {
            Console.Write("Въведете ID на факултатив: ");
            int id = int.Parse(Console.ReadLine());
            var majors = majorController.GetMajorsByFacultyId(id);
            foreach (var item in majors)
            {
                Console.WriteLine($"ID: {item.ID} Name: {item.Name}");
            }
        }

        public void GetUniversityIdByName()
        {
            Console.Write("Въведете име на университет: ");
            string name = Console.ReadLine();
            var university = universityController.GetUniversityIdByName(name);
            Console.WriteLine($"ID: {university}");
        }
        public void GetFacultyIdAndNameByName()
        {
            Console.Write("Въведете име на университет: ");
            string name = Console.ReadLine();
            var faculties = facultyController.GetFacultiesByName(name);
            foreach (var item in faculties)
            {
                Console.WriteLine($"ID: {item.ID} Name: {item.Name}");
            }
        }
        public void GetMajorIdAndNameByName()
        {
            Console.Write("Въведете име: ");
            string name = Console.ReadLine();
            var majors = majorController.GetMajorsByName(name);
            foreach (var item in majors)
            {
                Console.WriteLine($"ID: {item.ID} Name: {item.Name}");
            }
        }
    }
}

