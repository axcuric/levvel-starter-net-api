using LvvlStarterNetApi.Core.Models;
using LvvlStarterNetApi.SharedKernel.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace LvvlStarterNetApi.Core.Services
{
    public class UserService : IUserService
    {
        public UserService()
        {

        }

        public int Count(IQueryable<IUser> ListOfEntity)
        {
            if (ListOfEntity != default(User))
            {
                return ListOfEntity.Count();
            }

            return 0;
        }

        public List<IUser> FindUserFirstName(IQueryable<IUser> users, string firstNameToFind)
        {
            List<IUser> result = new List<IUser>();
            foreach (var user in users)
            {
                if(user.FirstName == firstNameToFind)
                {
                    result.Add(user);
                }
            }

            return result;

        }
    }
}
