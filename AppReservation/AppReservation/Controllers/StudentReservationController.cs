using AppReservation.Data;
using AppReservation.Models;
using AppReservation.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace AppReservation.Controllers
{
    public class StudentReservationController : Controller
    {

        private readonly ApplicationDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly Reservation reservation;

        public StudentReservationController(ApplicationDbContext context, UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _context = context;
            _userManager = userManager;
            _roleManager = roleManager;
        }


        // GET: StudentReservationController
        public async Task <ActionResult> Index()
        {
            var user = await _userManager.GetUserAsync(User);
            var UserReservation = await _context.Reservations
                .Select(res => new ResStudentViewModel
                {
                    StudentId = res.StudentId,
                    Date = res.Date,
                    Status = res.Status,
                    Cause = res.Cause,
                    ReservationTypeId = res.Reserv.Id,
                    Name = res.Reserv.name
                })
            .Where(res => res.StudentId == user.Id)
            .ToListAsync();
            return View(UserReservation);
        }

        // GET: StudentReservationController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: StudentReservationController/Create
        public ActionResult Create()
        {
            var reservationType = _context.TypeReservations.Select(t => new SelectListItem
            {
                Value = t.Id.ToString(),
                Text = t.name
            });
            ViewBag.ResType = reservationType;
            return View();
        }

        // POST: StudentReservationController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task <ActionResult> Create(ResStudentViewModel studentReservation)
        {
            try
            {
                var IdUser = User.FindFirstValue(ClaimTypes.NameIdentifier);
                var resType = _context.TypeReservations.Single(t => t.Id == studentReservation.ReservationTypeId);
                var user = (Student) await _userManager.FindByIdAsync(IdUser);
                var reservation = new Reservation
                {
                    
                    Date= studentReservation.Date ,
                    Status= studentReservation.Status ,
                    Cause= studentReservation.Cause,
                    StudentId= studentReservation.StudentId,
                    Reserv= resType

                };

                _context.Add(reservation);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(studentReservation);
            }
        }

        // GET: StudentReservationController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: StudentReservationController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: StudentReservationController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: StudentReservationController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
