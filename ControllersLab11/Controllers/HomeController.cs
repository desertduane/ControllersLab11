using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControllersLab11.Controllers
{
   
    public class HomeController
    {
        public string Index()
        {
            return "Welcome to the student registration";
        }
     
        public string Hello(int age)
        {
            return $"Welcome to the Student Home page {age}";
        }
    }
}
