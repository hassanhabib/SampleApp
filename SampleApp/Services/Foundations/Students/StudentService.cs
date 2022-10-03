﻿using System;
using System.Threading.Tasks;
using SampleApp.Brokers.Loggings;
using SampleApp.Brokers.Storages;
using SampleApp.Models.Students;

namespace SampleApp.Services.Foundations.Students
{
    public partial class StudentService : IStudentService
    {
        private readonly IStorageBroker storageBroker;
        private readonly ILoggingBroker loggingBroker;

        public StudentService(
            IStorageBroker storageBroker,
            ILoggingBroker loggingBroker)
        {
            this.storageBroker = storageBroker;
            this.loggingBroker = loggingBroker;
        }

        public async ValueTask<Student> AddStudentAsync(Student student) =>
            await this.storageBroker.InsertStudentAsync(student);
    }
}
