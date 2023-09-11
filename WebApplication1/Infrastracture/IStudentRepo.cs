using WebApplication1.Models;

namespace WebApplication1.Infrastracture
{
    public interface IStudentRepo
    {
        List<Student> GetallStudent();
        Student GetStudentByID(int id);

        Student InsertData(Student model);
    }
}
