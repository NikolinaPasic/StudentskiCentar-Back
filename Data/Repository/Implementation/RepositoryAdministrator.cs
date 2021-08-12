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
    public class RepositoryAdministrator : IAdministratorRepository
    {
        private Context _context;
        public RepositoryAdministrator(Context context)
        {
            _context = context;
        }

        public void Add(Administrator t)
        {
            throw new NotImplementedException();
        }

        public void Delete(Administrator t)
        {
            throw new NotImplementedException();
        }

        public Administrator FindById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Administrator> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Administrator> Search(Expression<Func<Administrator, bool>> pred)
        {
            throw new NotImplementedException();
        }

        public Administrator GetByUsernameAndPassword(Administrator admin)
        {
           
            return  _context.Administrator.Single(x => x.Username == admin.Username && x.Password == admin.Password);

        }

        ActionResult IAdministratorRepository.GetByUsernameAndPassword(Administrator admin)
        {
            throw new NotImplementedException();
        }
    }
}
