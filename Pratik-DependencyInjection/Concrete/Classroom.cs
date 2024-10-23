using Pratik_DependencyInjection.Teacher;

namespace Pratik_DependencyInjection.Concrete
{
    public class Classroom
    {
        private readonly ITeacher _teacher;

        public Classroom(ITeacher teacher)
        {
            _teacher = teacher;
        }

        public void StartClass()
        {
            Console.WriteLine("Sınıf başladı");
            _teacher.GetTeacherInfo();
        }
    }
}
