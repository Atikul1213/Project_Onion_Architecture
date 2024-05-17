using OA.DATA;
using OA.REPO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.Service
{
    public class UserService : Repository<User>, IUserService
    {
        private ApplicationDbContext _db;
        // public IUserService userservice { get; private set; }

        public UserService(ApplicationDbContext db) : base(db)
        {
            _db = db;
           // userservice = new UserService(_db);
        }



        public void Save()
        {
            _db.SaveChanges();
        }

       
    }
}
