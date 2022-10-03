using System.Threading.Tasks;
using SampleApp.Models.Students;

namespace SampleApp.Services.Foundations
{
    public interface IStudentService
    {
        ValueTask<Student> AddStudentAsync(Student student);
    }
}
