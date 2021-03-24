using AppReservation.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppReservation.Controllers
{
    public class RoleController : Controller
    {
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly UserManager<IdentityUser> userManager;
        public RoleController(RoleManager<IdentityRole> roleManager,
                               UserManager<IdentityUser> userManager)
        {
            this.roleManager = roleManager;
            this.userManager = userManager;
        }

        [HttpGet]
        public IActionResult AddRole()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddRole(Role model)
        {
            if (ModelState.IsValid)
            {
                IdentityRole role = new IdentityRole()
                {
                    Name = model.RoleName
                };

                IdentityResult result = await this.roleManager.CreateAsync(role);

                if (result.Succeeded)
                {
                    return RedirectToAction("ListRoles");
                }
                foreach (IdentityError error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }

            return View(model);
        }

        [HttpGet]
        public IActionResult ListRoles()
        {
            var roles = this.roleManager.Roles;
            return View(roles);
        }


        [HttpGet]
        public async Task<IActionResult> EditRole(string id)
        {
            if (id is null)
            {
                return View("../Errors/NotFound", "Please add the role Id in URL");
            }
            IdentityRole role = await roleManager.FindByIdAsync(id);
            if (role is null)
            {
                return View("../Errors/NotFound", $"The role Id : {id} cannot be found");
            }

            EditRole model = new EditRole()
            {
                Id = role.Id,
                RoleName = role.Name,
                Users = new List<string>()
            };

            foreach (IdentityUser user in await userManager.Users.ToListAsync()) // userManager.Users is not awaitble so change to (await userManager.Users.ToListAsync())
            {
                if (await userManager.IsInRoleAsync(user, role.Name))
                {
                    model.Users.Add(user.UserName);
                }
            }
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> EditRole(EditRole model)
        {
            if (ModelState.IsValid)
            {
                var role = await roleManager.FindByIdAsync(model.Id);
                if (role is null)
                {
                    return View("../Errors/NotFound", $"The role Id : {model.Id} cannot be found");
                }
                role.Name = model.RoleName;

                IdentityResult result = await roleManager.UpdateAsync(role);

                if (result.Succeeded)
                {
                    return RedirectToAction("ListRoles");
                }

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }
            return View(model);

        }

    }
}
