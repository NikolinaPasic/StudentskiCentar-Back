using Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository.Definition
{
    public interface IStudentRepository : IRepository<Student>
    {
        Task<List<Student>> GetAllAsync();
        Task<Student> GetByUsernameAndPassword(Student s);
        void ChangePassword(Student student);
        void TransferMoney(Student student, double iznos);
        Task<Student> GetStudent(int id);
    }
}
