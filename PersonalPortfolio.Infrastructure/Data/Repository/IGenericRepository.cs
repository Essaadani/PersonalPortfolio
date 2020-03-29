using System.Collections.Generic;
using System.Text;

namespace PersonalPortfolio.Infrastructure.Data.Repository
{
    public interface IGenericRepository<T> where T: class
    {
        IEnumerable<T> GetAll();
        T GetById(object id);
        void Insert(T entity);
        void Update(T entity);
        void Delete(object id);
    }
}
