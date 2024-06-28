using TestAppStateManagment.Shared;

namespace Applicaiton.Abstract;

public interface IUserService
{
    List<User> GetAll(int? startPage, int? pageSize);
    User GetById(int Id);
    User Add(User entity);
    User Update(User entity);
    User Delete(int Id);

}
