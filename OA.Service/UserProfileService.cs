using OA.DATA;
using OA.REPO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.Service
{
    public class UserProfileService : Repository<UserProfile>, IUserProfileService
    {
        private ApplicationDbContext _db;

        public UserProfileService(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

    }
}
