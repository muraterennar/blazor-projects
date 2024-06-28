using Persistence.Contexts;
using TestAppStateManagment.Shared;

namespace Persistence.Concreate.UserRepository;

public class UserRepository : RepositoryBase<User, EfDbContext>, IUserRepository
{
    public UserRepository(EfDbContext context) : base(context)
    {
    }
}
