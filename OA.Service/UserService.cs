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
        public UserService(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }





    }
}
