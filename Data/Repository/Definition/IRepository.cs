using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository.Definition
{
    public interface IRepository <T>
    {
        void Add(T t);
        List<T> GetAll();
        T FindById(int id);
        void Delete(T t);
        List<T> Search(Expression<Func<T, bool>> pred);
    }
}
