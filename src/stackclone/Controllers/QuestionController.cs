using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using stackclone.Models;
using Microsoft.AspNetCore.Identity;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace stackclone.Controllers
{
    public class QuestionController : Controller
    {
        private readonly StackDbContext _db;
        private readonly UserManager<User> _userManager;

        public QuestionController(UserManager<User> userManager, StackDbContext db)
        {
            _userManager = userManager;
            _db = db;
        }
        public IActionResult Index()
        {
            return View(_db.Questions.ToList());
        }
    }
}
