using System.Linq.Expressions;
using TestAppStateManagment.Shared;

namespace Persistence.Abstract;

public interface IRepository<T>
{
    List<T> GetAll(int? startPage, int? pageSize);
    T GetById(Expression<Func<T, bool>> expression);
    T Add(T entity);
    T Update(T entity);
    T Delete(int Id);
}
