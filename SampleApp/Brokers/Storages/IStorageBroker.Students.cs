using System.Threading.Tasks;
using SampleApp.Models.Students;

namespace SampleApp.Brokers.Storages
{
    public partial interface IStorageBroker
    {
        ValueTask<Student> InsertStudentAsync(Student student);
    }
}
