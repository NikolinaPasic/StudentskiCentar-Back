using Data.Repository.Definition;
using Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository.Implementation
{
    public class RepositoryStudent : IStudentRepository
    {
        private Context _context;
        public RepositoryStudent(Context context)
        {
            _context = context;
        }
        public void Add(Student t)
        {
            throw new NotImplementedException();
        }

        public async Task<Student> BuyMeals(Student student)
        {
            Student s =await _context.Student.SingleAsync(d => d.StudentId == student.StudentId);
            s.StanjeNaRacunu = student.StanjeNaRacunu;
            s.BrojDorucaka = student.BrojDorucaka;
            s.BrojRucaka = student.BrojRucaka;
            s.BrojVecera = student.BrojVecera;
            _context.SaveChanges();
            return s;
        }

        public void ChangePassword(Student s)
        {
            Student student = _context.Student.Single(d => d.StudentId == s.StudentId);
            student.Password = s.Password;
            _context.SaveChanges();
        }

        public void Delete(Student t)
        {
            throw new NotImplementedException();
        }

        public Student FindById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Student>> GetAllAsync()
        {
            return await _context.Student.ToListAsync();
        }

        public async Task<Student> GetByUsernameAndPassword(Student s)
        {
            return await _context.Student.SingleOrDefaultAsync(x => x.Username == s.Username && x.Password == s.Password);

        }

        public List<Student> Search(Expression<Func<Student, bool>> pred)
        {
            throw new NotImplementedException();
        }

        List<Student> IRepository<Student>.GetAll()
        {
            throw new NotImplementedException();
        }

        /*public async Task<ActionResult> IStudentRepository.GetByUsernameAndPassword(Student s)
        {
            return await _context.Student.SingleOrDefaultAsync(x => x.Username == s.Username && x.Password == s.Password);
        }*/

        async Task<Student> IStudentRepository.GetStudent(int id)
        {
            return await _context.Student.SingleAsync(s=>s.StudentId==id);
        }

        void IStudentRepository.TransferMoney(Student s, double iznos)
        {
            Student student = _context.Student.Single(d => d.StudentId == s.StudentId);
            student.StanjeNaRacunu+= iznos;
            _context.SaveChanges();
        }
    }
}
