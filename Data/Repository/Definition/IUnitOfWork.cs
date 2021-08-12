using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository.Definition
{
    public interface IUnitOfWork: IDisposable
    {
        public IStudentRepository Student { get; set; }
        public IAdministratorRepository Administrator { get; set; }
        void Commit();
    }
}
