using Applicaiton.Abstract;
using Persistence.Concreate.UserRepository;
using TestAppStateManagment.Shared;

namespace Applicaiton.Concreate;

public class UserService : IUserService
{
    private readonly IUserRepository _userRepository;

    public UserService(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public User Add(User entity)
    {
        return _userRepository.Add(entity);
       
    }

    public User Delete(int Id)
    {
        return _userRepository.Delete(Id);
    }

    public List<User> GetAll(int? startPage, int? pageSize)
    {
       return _userRepository.GetAll(startPage, pageSize);
    }

    public User GetById(int Id)
    {
        return _userRepository.GetById(x=>x.user_id == Id);
    }

    public User Update(User entity)
    {
        return _userRepository.Update(entity);
    }
}
