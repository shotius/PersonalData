using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;


namespace Service.Contracts
{
    public interface IRepositoryBase<T>
    {
        IEnumerable<T> FindAll();

        IEnumerable<T> FindByCondition(Expression<Func<T, bool>> expression);

        T Get(int id);

        void Create(T Entity);

        void Update(T Entity);
        
        void Delete(T Entity);

    }
}
