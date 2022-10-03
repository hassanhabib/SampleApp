using SampleApp.Models.Students;
using SampleApp.Models.Students.Exceptions;

namespace SampleApp.Services.Foundations.Students
{
    public partial class StudentService : IStudentService
    {
        private static void ValidateStudent(Student student)
        {
            if (student is null)
            {
                throw new NullStudentException();
            }
        }
    }
}
