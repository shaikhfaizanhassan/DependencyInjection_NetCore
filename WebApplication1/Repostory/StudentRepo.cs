using WebApplication1.Data;
using WebApplication1.Infrastracture;
using WebApplication1.Models;

namespace WebApplication1.Repostory
{
    public class StudentRepo : IStudentRepo
    {
        private readonly StudentDbContgext db;

        public StudentRepo(StudentDbContgext db) 
        {
            this.db = db;
        }

        List<Student> IStudentRepo.GetallStudent()
        {
            var getdata = db.students.ToList();
            return getdata;
        }

        Student IStudentRepo.GetStudentByID(int id)
        {
            var getdataid = db.students.Where(x=>x.Sid==id).FirstOrDefault();
            return getdataid;
        }

        Student IStudentRepo.InsertData(Student model)
        {
            var data = new Student()
            {
                Sname = model.Sname,
                Semail = model.Semail
            };
            db.students.Add(data);
            db.SaveChanges();

            return data;

        }

    }
}
