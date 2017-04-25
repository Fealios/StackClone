using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using stackclone.Models;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;

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
        public IActionResult Details(int id)
        {
            var thisQuestion = _db.Questions.FirstOrDefault(questions => questions.id == id);
            return View(thisQuestion);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(int QuestionId, string content)
        {
            var comment = new Comment();
            comment.content = content;
            var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            var currentUser = await _userManager.FindByIdAsync(userId);
            comment.Question = _db.Questions
                .FirstOrDefault(question => question.id == QuestionId);
            comment.user = currentUser;
            _db.Comments.Add(comment);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
