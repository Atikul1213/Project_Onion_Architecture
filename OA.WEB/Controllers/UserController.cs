using Microsoft.AspNetCore.Mvc;
using OA.DATA;
using OA.Service;
using System.Collections.Generic;

namespace OA.WEB.Controllers
{
    public class UserController : Controller
    {

        private readonly IUserService _user;

        private readonly IUserProfileService _userProfile;

        public UserController(IUserService user, IUserProfileService userProfile)
        {
            _user = user;
            _userProfile = userProfile;
        }

        public ActionResult Index()
        {
            var usr = _user.GetAll();


            return View(usr);
        }



        public IActionResult Create()
        {

            return View();
        }


        [HttpPost]

        public IActionResult Create(User userobj)
        {

            if(ModelState.IsValid)
            {
                _user.Add(userobj);
                _user.Save();
                return RedirectToAction("Index");
            }
            return View();
        }
    

       

    }
}
