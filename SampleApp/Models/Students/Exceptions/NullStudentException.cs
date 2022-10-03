using Xeptions;

namespace SampleApp.Models.Students.Exceptions
{
    public class NullStudentException : Xeption
    {
        public NullStudentException()
            : base(message: "Student is null.")
        {
        }
    }
}
