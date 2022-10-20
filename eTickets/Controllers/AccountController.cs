using eTickets.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationIdentity> _userManager;
        private readonly SignInManager<ApplicationIdentity> _signInManager;
        private readonly AppDbContext _context;

        public AccountController(UserManager<ApplicationIdentity> userManager, SignInManager<ApplicationIdentity> signInManager, AppDbContext context)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
