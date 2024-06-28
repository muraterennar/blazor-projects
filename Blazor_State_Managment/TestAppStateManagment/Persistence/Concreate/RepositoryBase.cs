using Microsoft.EntityFrameworkCore;
using Persistence.Abstract;
using System.Linq.Expressions;
using TestAppStateManagment.Shared;

namespace Persistence.Concreate;

public class RepositoryBase<T, TContext> : IRepository<T>
    where T : BaseEntity, new()
    where TContext : DbContext
{

    TContext _context;

    public RepositoryBase(TContext context)
    {
        _context = context;
    }

    public T Add(T entity)
    {
        _context.Add(entity);
        _context.SaveChanges();
        return entity;
    }

    public T Delete(int Id)
    {
        var getUser = GetById(x => x.user_id == Id);
        _context.SaveChanges();
        return null;
    }

    public List<T> GetAll(int? startPage, int? pageSize)
    {
        return _context.Set<T>().Skip(startPage.Value).Take(pageSize.Value).ToList();
    }

    public T GetById(Expression<Func<T, bool>> expression)
    {
        return _context.Set<T>().Where(expression).FirstOrDefault();
    }

    public T Update(T entity)
    {
        var getUser = GetById(x => x.user_id == entity.user_id);
        _context.Entry(getUser).CurrentValues.SetValues(entity);
        _context.SaveChanges();
        return entity;
    }
}
