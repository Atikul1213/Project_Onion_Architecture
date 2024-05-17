using OA.DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OA.REPO
{
    public interface IRepository<T> where T : BaseEntity
    {

        IEnumerable<T> GetAll();

        T Get(Expression<Func<T, bool>> filter);

        void Add(T entity);

        void Remove(T entity);

        void Update(T entity);

        void RemoveRange(IEnumerable<T> entity);

    }
}
