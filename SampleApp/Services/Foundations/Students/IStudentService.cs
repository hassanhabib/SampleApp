using System.Threading.Tasks;
using SampleApp.Models.Students;

namespace SampleApp.Services.Foundations.Students
{
    public interface IStudentService
    {
        ValueTask<Student> AddStudentAsync(Student student);
    }
}
