using CoreSM.Interface;
using CoreSM.Models;
using System.Collections.Generic;

namespace CoreSM.Model
{
    public interface IUsers_Repository : IGenericRepository<Users>
    {
        List<Users> AddUsers(Users Users);
        List<Users> GetUsers();
        Users PutUsers(Users Users);
        Users GetUsersByUserAndPass(string username, string password);
        Users GetUsersById(int id);
        IEnumerable<Users> GetUsersByCompany(int compID);
    }
}
