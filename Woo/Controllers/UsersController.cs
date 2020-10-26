using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Woo.Data;
using Woo.Models;
using Woo.ViewModels;

namespace Woo.Controllers
{
    [Authorize(Roles = "Admin")]
    public class UsersController : Controller
    {
        /*private readonly WooContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        /*public UsersController(WooContext context, UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager, RoleManager<IdentityRole> roleManager)
        {
            this._context = context;
            this._userManager = userManager;
            this._signInManager = signInManager;
            this._roleManager = roleManager;
        }

        // GET: Users
        public async Task<IActionResult> Index()
        {
            return View(await _context.User.ToListAsync());
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Login()
        {
            LoginViewModel model = new LoginViewModel();
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login(LoginViewModel model, string returnUrl)
        {
            //IdentityUser user = new ApplicationUser(model.user);
            //IdentityRole role = new IdentityRole("User");

            //var result1 = await _userManager.CreateAsync(user,model.password);
            //var role = await _roleManager.FindByIdAsync("Admin");
            //var result1 = await _roleManager.CreateAsync(role);
            //result1 = await _userManager.AddToRoleAsync(user, "Admin");

            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(model.user, model.password, false,false);

                if (result.Succeeded)
                {
                    if (!string.IsNullOrEmpty(returnUrl))
                    {
                        return Redirect(returnUrl);
                    }
                    else
                    {
                        return RedirectToAction("index", "home");
                    }
                }

                ModelState.AddModelError(string.Empty, "Invalid Login Attempt");
            }

            return View();
        }

        // GET: Users
        
        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("login", "users");
        }


        // GET: Users/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _context.User
                .FirstOrDefaultAsync(m => m.ID == id);
            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        // GET: Users/Create
        public ActionResult Create()
        {
            //int i = 0;

            ViewBag.rolelist1 = _context.Roles.ToList();
            //ViewBag.rolelist1 = await _roleManager.Roles.Select(x => x.Id, x.).ToListAsync();

            ViewBag.rolelist =  _roleManager.Roles.Select(x => new { id = x.Id, name = x.Name }).ToList();

            ViewBag.rolelistxx = _roleManager.Roles.Select(x => new { x.Id, x.Name }).ToList();

            ViewBag.itemlist =  _context.Item.ToList();

            //ViewData["rolelist2"] = _roleManager.Roles.Select(x => new { Id = x.Id, name = x.Name }).ToList();


            return View();
        }

        // POST: Users/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,UserNum,EName,AName,password,RoleId,Comment,SellerID,DeviceId,Enabled,GrantBy,GrantFromDate,GrantToDate,GrantComment,CreationDate,CreatedID,UpdatingDate,UpdatedID,SysComment")] User user)
        {
            if (ModelState.IsValid)
            {
                var Iuser = new ApplicationUser
                {
                    UserName = user.EName,
                    Email = user.EName
                };

                var result = await _userManager.CreateAsync(Iuser, user.password);

                if (result.Succeeded)
                {
                    var role = await _roleManager.FindByIdAsync(user.RoleId);
                    //result = await _userManager.AddToRoleAsync(Iuser, role.Id);
                    result = await _userManager.AddToRoleAsync(Iuser, role.Name);
                }

                if (result.Succeeded)
                {
                    _context.Add(user);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }


                
            }
            return View(user);
        }

        // GET: Users/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _context.User.FindAsync(id);
            if (user == null)
            {
                return NotFound();
            }
            return View(user);
        }

        // POST: Users/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,UserNum,EName,AName,password,Comment,SellerID,DeviceId,Enabled,GrantBy,GrantFromDate,GrantToDate,GrantComment,CreationDate,CreatedID,UpdatingDate,UpdatedID,SysComment")] User user)
        {
            if (id != user.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(user);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserExists(user.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(user);
        }

        // GET: Users/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _context.User
                .FirstOrDefaultAsync(m => m.ID == id);
            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        // POST: Users/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var user = await _context.User.FindAsync(id);
            _context.User.Remove(user);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UserExists(int id)
        {
            return _context.User.Any(e => e.ID == id);
        }*/
    }
}
