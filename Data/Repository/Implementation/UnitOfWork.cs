using Data.Repository.Definition;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository.Implementation
{
    public class UnitOfWork: IUnitOfWork
    {

        private Context context;
        public IStudentRepository Student { get; set; }
        public IAdministratorRepository Administrator { get; set; }
        public UnitOfWork(Context context)
        {
            this.context = context;
            Student = new RepositoryStudent(context);
            Administrator = new RepositoryAdministrator(context);
        }

        public void Commit()
        {
            context.SaveChanges();
        }

        public void Dispose()
        {
            context.Dispose();
        }
    }
}
