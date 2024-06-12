using CoreSM.Models;
using CoreSM.Repository;
using System.Collections.Generic;
using System.Linq;

namespace CoreSM.Model
{
    public class UsersRepository : GenericRepository<Users>, IUsers_Repository
    {
        private readonly SalesDbContext db;

        public UsersRepository(SalesDbContext context) : base(context)
        {
        }

        public List<Users> GetUsers() => db.Users.ToList();
        public Users PutUsers(Users Users)
        {
            _context.Users.Update(Users);
            _context.SaveChanges();
            return _context.Users.Where(x => x.UserID == Users.UserID).FirstOrDefault();
        }

        public List<Users> AddUsers(Users Users)
        {
            _context.Users.Add(Users);
            _context.SaveChanges();
            return null;
        }

        public Users GetUsersById(int Id)
        {
            return db.Users.Where(x => x.UserID == Id).FirstOrDefault();
        }
        public IEnumerable<Users> GetUsersByCompany(int compID)
        {
            return _context.Users.Where(x => x.UserID == compID && x.IsActive == false);
        }

        public Users GetUsersByUserAndPass(string username, string password)
        {
            return _context.Users.FirstOrDefault(x => x.UserName.ToLower().Trim() == username && x.Password == password);
        }
    }
}
