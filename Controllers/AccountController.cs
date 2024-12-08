using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Petstore_GroupProject8.Models;

namespace Petstore_GroupProject8.Controllers
{
    public class AccountController : Controller
    {
        private readonly SignInManager<Customer> _signInManager;

        public AccountController(SignInManager<Customer> signInManager)
        {
            _signInManager = signInManager;
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}
