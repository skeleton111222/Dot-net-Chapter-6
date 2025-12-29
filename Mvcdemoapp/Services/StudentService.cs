using Mvcdemoapp.Models;
namespace Mvcdemoapp.Services
{
    public class StudentService : IStudentService
    {
        public Student GetStudent() 
        {
            return new Student
            {
                Name = "Ram Krishna",
                Age =20
            };

        }
    }
}
