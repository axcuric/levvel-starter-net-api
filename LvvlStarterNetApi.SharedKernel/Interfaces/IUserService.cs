using System.Collections.Generic;
using System.Linq;

namespace LvvlStarterNetApi.SharedKernel.Interfaces
{
    public interface IUserService: ICommonServices<IUser>
    {
        List<IUser> FindUserFirstName(IQueryable<IUser> users, string firstNameToFind);
    }
}
