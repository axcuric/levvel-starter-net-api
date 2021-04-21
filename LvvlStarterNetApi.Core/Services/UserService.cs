using LvvlStarterNetApi.Core.Models;
using LvvlStarterNetApi.SharedKernel.Interfaces;
using System.Linq;

namespace LvvlStarterNetApi.Core.Services
{
    public class UserService : ICommonServices<User>
    {
        public UserService()
        {

        }

        public int Count(IQueryable<User> ListOfEntity)
        { 
            if(ListOfEntity != default(User))
            {
                return ListOfEntity.Count();
            }

            return 0;
        } 
    }
}
