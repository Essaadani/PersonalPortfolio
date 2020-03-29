using PersonalPortfolio.Infrastructure.Data.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace PersonalPortfolio.Infrastructure.Data.UnitOfWork
{
    public interface IUnitOfWork<T> where T : class
    {
        IGenericRepository<T> Entity { get; }
        void Save();
    }
}
