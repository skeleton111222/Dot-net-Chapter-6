//using Microsoft.AspNetCore.Mvc;

//using Mvcdemoapp.Models;

//namespace Mvcdemoapp.Controllers
//{
//    public class StudentController : Controller
//    {
//        public IActionResult Index()
//        {

//            Student student = new Student();
//            //student.Name = "Donald Trump Jr";
//            //student.Age = 20;
//            return View(student);
//        }
//        [HttpPost]
//        public IActionResult Index(Student student)
//        {
//            return View(student); 
//        }
//        public IActionResult Dashboard()
//        {
//            return View();
//        }
//    }
//}


using Microsoft.AspNetCore.Mvc;
using Mvcdemoapp.Models;
using Mvcdemoapp.Services;

namespace Mvcdemoapp.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentService _studentService;

        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        public IActionResult Index()
        {
            Student student = _studentService.GetStudent();

            return View(student);
        }
    }
}
