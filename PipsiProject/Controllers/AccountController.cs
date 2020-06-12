using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PipsiProject.Models;

namespace PipsiProject.Controllers
{
    public class AccountController : Controller
    {
        private UserManager<UserModel> UserMgr { get; }
        private SignInManager<UserModel> SignInMgr { get; }
        private RoleManager<UserRole> RoleMgr { get; }
        private readonly IdentityAppContext _identityContext;

        public AccountController(IdentityAppContext context, UserManager<UserModel> userManager, SignInManager<UserModel> signInManager, RoleManager<UserRole> roleManager)
        {
            _identityContext = context;
            UserMgr = userManager;
            SignInMgr = signInManager;
            RoleMgr = roleManager;
        }

        public async Task<IActionResult> Logout()
        {
            await SignInMgr.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

 //-------------------------------------------LOGIN----GET-------------------------------------------------------------

        //[HttpGet]
        public IActionResult Login()
        {
                ViewData["Message2"] = "Zaloguj się";
                return View();
        }
//-------------------------------------LOGBEHIND-after-register--------------------------------------------------------
        //[HttpGet]
        public async Task<IActionResult> LogBehind(UserModel user)
        {
            if (user != null)
            {
                var userToLog = await UserMgr.FindByNameAsync(user.UserName);
                await SignInMgr.SignInAsync(userToLog, false);
                
                ViewData["Message"] = "Użytkownik został zarejestrowany."; 
                return View();
            }
            else
            {
                return View("Login");
            }
        }

        ////----------------------------------------CHECK-USER-ROLE---------------------------------------------------------------

        //public async Task<IActionResult> CheckRole(UserModel currentUser)
        //{
        //    var allUsers = await _identityContext.UserModel

        //       .Join(_identityContext.UserRoles,
        //        users => users.Id,
        //        roles => roles.RoleId,
        //    (users, roles) => new
        //    {
        //        usId = users.Id,
        //        usName = users.UserName,
        //        usRoleId = roles.RoleId
        //    }
        //)
        //.AsNoTracking()
        //.ToListAsync();

        //   var entUser = await UserMgr.GetRolesAsync(currentUser);

        //    return View(user);
        //}


        //-------------------------------------------LOGIN----POST-------------------------------------------------------------
        [HttpPost]
        public async Task<IActionResult> Login(string uName, string uPass)
        {
            var result = await SignInMgr.PasswordSignInAsync(uName, uPass, false, false);
            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.Result = "Logowanie się nie powiodło... (" + result.ToString() + ")";
            }
            return View();
        }
        //-------------------------------------------REGISTER----GET-------------------------------------------------------------
        public IActionResult Register()
        {
                return View();
        }

        //-------------------------------------------REGISTER----POST------------------------------------------------------------
        [HttpPost]
        public async Task<IActionResult> Register(string uName, string uPass, string fName, string lName, string uMail)
        {
            try
            {
                UserModel user = await UserMgr.FindByNameAsync(uName);
                
                if (user != null)
                {
                    ViewBag.Message = "Ten użytkownik jest już zarejestrowany.";
                    return View();
                }
                else
                {
                    string roleNameA = "admin";
                    string roleDescripA = "Administrator systemu";
                    string roleNameB = "user";
                    string roleDescripB = "Użytkownik systemu";

                    if (await RoleMgr.FindByNameAsync(roleNameA) == null)
                    {
                        await RoleMgr.CreateAsync(new UserRole(roleNameA, roleDescripA));
                    }
                    if (await RoleMgr.FindByNameAsync(roleNameB) == null)
                    {
                        await RoleMgr.CreateAsync(new UserRole(roleNameB, roleDescripB));
                    }

                    user = new UserModel
                    {
                        UserName = uName,
                        Email = uMail,
                        FirsName = fName,
                        LastName = lName
                    };

                    IdentityResult result = await UserMgr.CreateAsync(user, uPass);
                    if (result.Succeeded)
                    {
                        await UserMgr.AddPasswordAsync(user, uPass);
                        await UserMgr.AddToRoleAsync(user, roleNameB);   // ustawienie roli jako użytkownik (nie admin)
                        
                        ViewBag.Message2 = " Zaloguj się:";
                        //ViewBag.Name = uName;                NIEBEZPIECZNE - przekazanie danych do formularza
                        //ViewBag.Pass = uPass;
                    }
                    else
                    {
                        ViewBag.Message = "Użytkownik nie został zarejestrowany: " + result.Errors.ToString();
                    }
                    user = await UserMgr.FindByNameAsync(uName);
                    return RedirectToAction("LogBehind","Account", user);     //RedirectToAction("Login", "Account", user.Id);
                    
                }
            }
            catch (Exception ex)
            {
                ViewBag.Message = "Coś poszło nie tak... (" + ex.Message + ")";
                return View();
            }
        }

        //public async Task<IActionResult> Register()
        //{
        //    try
        //    {
        //        ViewBag.Message = "Użytkownik jest już zarejestrowany";

        //        UserModel user = await UserMgr.FindByNameAsync("TestUser");
        //        if (user == null)
        //        {
        //            user = new UserModel();
        //            user.UserName = "TestUser";
        //            user.Email = "TestUser@test.com";
        //            user.FirsName = "Stefan";
        //            user.LastName = "Batory";

        //            IdentityResult result = await UserMgr.CreateAsync(user, "Test123!");
        //            ViewBag.Message = "Urzytkownik został stworzony.";

        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        ViewBag.Message = ex.Message;
        //    }
        //    return View();
        //}


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}