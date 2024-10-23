using Pratik_DependencyInjection.Teacher;

namespace Pratik_DependencyInjection.Concrete
{
    public class Teacher : ITeacher
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public void GetTeacherInfo()
        {
            Console.WriteLine($"{FirstName} {LastName}");
        }
    }
}
