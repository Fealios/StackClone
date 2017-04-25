//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.AspNetCore.Identity;
//using stackclone.Models;


//namespace stackclone.Controllers
//{
//    public class AccountController : Controller
//    {
//        private readonly UserDbContext _db;
//        private readonly UserManager<User> _userManager;
//        private readonly SignInManager<User> _signInManager;

//        public AccountController (UserManager<User> userManager, SignInManager<User> signInManager, UserDbContext db)
//        {
//            _userManager = userManager;
//            _signInManager = signInManager;
//            _db = db;
//        }

//        public IActionResult Index()
//        {
//            return View();
//        }
//    }
//}
