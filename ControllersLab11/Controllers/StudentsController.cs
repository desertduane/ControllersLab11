using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ControllersLab11.Controllers
{

    public class StudentsController
    {

        string filePath = @"C:\Users\Duane Rush\source\repos\students.txt";
        public string Index()
        {
            return "Index for Student controller";
        }


        public string Register(string name, int age, string study)
        {
            var student = $"My name is {name} I am {age} years old and I enjoy studying {study}";
            using (StreamWriter sw = File.AppendText(filePath))
            {
                sw.WriteLine(student);
            }
            return student;

        }




        public string HomeState(string state)
        {
            return $"I am from {state}";
        }
        public string Error()
        {
            return "You had a student error";
        }
    }
}
