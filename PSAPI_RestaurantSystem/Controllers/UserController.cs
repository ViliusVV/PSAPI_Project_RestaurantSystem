﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using PSAPIRestaurantSystem.Models;
using PSAPIRestaurantSystem.Models.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace PSAPIRestaurantSystem.Controllers
{
    public class UserController : Controller
    {
        private readonly RestaurantContext _context;
        private readonly ILogger<UserController> _logger;

        public UserController(RestaurantContext context, ILogger<UserController> logger)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult FoodMenu()
        {
            var restaurantContext = _context.Menus.Include(m => m.MenuEntries);
            return View(restaurantContext.ToList());
        }
        public IActionResult LoginForm()
        {
            return View();
        }
        [HttpPost]
        public IActionResult LoginForm(LoginViewModel model)
        {
            _logger.LogDebug(model.LoginName);
            var usr = _context.Users.Where(u => u.Email == model.LoginName)
                .Include(e => e.Employee)
                    .ThenInclude(a => a.Admin)
                .Include(e => e.Employee)
                    .ThenInclude(w => w.Waiter)
                .Include(p => p.Person)
                .FirstOrDefault();

            HttpContext.Session.SetString("role", "admin");
            if (usr == null)
            {
                return View();
            }
            else
            {
                HttpContext.Session.SetInt32("userID", usr.UserId);
                HttpContext.Session.SetString("name", usr.Person.Name);
                HttpContext.Session.SetString("surname", usr.Person.Surname);
            }
            if (usr.Employee != null)
            {
                if (usr.Employee.Waiter != null)
                {
                    HttpContext.Session.SetString("role", "waiter");

                }

                else if (usr.Employee.Admin != null)
                {
                    HttpContext.Session.SetString("role", "admin");
                }
            }
            else
            {
                HttpContext.Session.SetString("role", "user");
            }

            return Redirect("/");
        }

        // Open generic review list page
        public IActionResult ReviewsPage()
        {
            var reviews = _context.Reviews.Include(u => u.User).ThenInclude(p => p.Person);
            return View(reviews.ToList());
        }

        // Edit/Create review
        public IActionResult EditableReviewsPage()
        {
            var usrID = HttpContext.Session.GetInt32("userID");

            var review = _context.Reviews.Where(r => r.UserId == usrID).FirstOrDefault();

            if (review == null)
            {
                return RedirectToAction("ReviewInsertForm");
            }
            else
            {
                return RedirectToAction("ReviewEditForm", new { id = usrID } );
            }
            return RedirectToAction("ReviewsPage");
        }

        // Edit review form GET

        public IActionResult ReviewEditForm(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reviewEntry = _context.Reviews.Where(r => r.UserId == id).FirstOrDefault();
            if (reviewEntry == null)
            {
                return NotFound();
            }
            ViewData["Rating"] = new SelectList(Review.digits, "Value", "Text");
            return View(reviewEntry);
        }

        // Insert review form GET

        public IActionResult ReviewInsertForm()
        {
            ViewData["Rating"] = new SelectList(Review.digits, "Value", "Text");
            return View();
        }
        
        // Insert review form POST

        [HttpPost]
        public IActionResult ReviewInsertForm(Review rev)
        {
            ModelState.Remove("ReviewId");
            if (ModelState.IsValid)
            {
                rev.UserId = (int)HttpContext.Session.GetInt32("userID");
                rev.ReviewDate = DateTime.Now;
                _context.Add(rev);
                _context.SaveChanges();

                return Redirect("/User/ReviewsPage");
            }
            ViewData["Rating"] = new SelectList(Review.digits, "Value", "Text");
            return View(rev);
        }

        // Edit review form POST
        [HttpPost]
        public IActionResult ReviewEditForm(int? id, Review reviewEntry)
        {
            if (ModelState.IsValid)
            {
                reviewEntry.UserId = (int)HttpContext.Session.GetInt32("userID");
                reviewEntry.ReviewDate = DateTime.Now;
                _context.Update(reviewEntry);
                _context.SaveChanges();

                return Redirect("/User/ReviewsPage");
            }

            ViewData["Rating"] = new SelectList(Review.digits, "Value", "Text");
            return View(reviewEntry);
        }

        // User logout

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();

            return Redirect("/");
        }
    }
}