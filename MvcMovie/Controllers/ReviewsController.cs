using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;

namespace MvcMovie.Controllers
{
    public class ReviewController : Controller
    {
        private readonly MvcMovieContext _context;

        public ReviewController(MvcMovieContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index(string sortby, string direction)
        {
            if (sortby == null && direction == null)
            {
                return View(await _context.Review.ToListAsync());
            }

            var reviews = await _context.Review.OrderBy(r => r.Reviewer).ToListAsync();
            if (sortby == "reviewer" && direction == "desc")
            { 
                reviews = await _context.Review.OrderByDescending(r => r.Reviewer).ToListAsync();
            }
            else if (sortby == "movie" && direction == "asc")
            { 
                reviews = await _context.Review.OrderBy(r => r.MovieTitle).ToListAsync();
            }
            else if (sortby == "movie" && direction == "desc")
            {
                reviews = await _context.Review.OrderByDescending(r => r.MovieTitle).ToListAsync();
            }
            else
            { 
                reviews = await _context.Review.OrderBy(r => r.Reviewer).ToListAsync();
            }

            return View(reviews);
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var review = await _context.Review
                .FirstOrDefaultAsync(m => m.ID == id);
            if (review == null)
            {
                return NotFound();
            }

            return View(review);
        }

        public IActionResult Create(int? id, string movieTitle)
        {
            if (id == null) { id = 0; }
            ViewData["thisMovieID"] = id;
            ViewData["thisMovieTitle"] = movieTitle;
            return View();
        }

     
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Reviewer,UserReview,MovieID,MovieTitle")] Review review)
        {
            if (ModelState.IsValid)
            {
                _context.Add(review);
                await _context.SaveChangesAsync();
                return RedirectToAction($"Details{"/" + review.MovieID}", "Movies");
            }
            ViewData["thisMovieID"] = review.MovieID;
            ViewData["thisMovieTitle"] = review.MovieTitle;
            return View(review);
        }

   
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var review = await _context.Review.FindAsync(id);
            if (review == null)
            {
                return NotFound();
            }
            return View(review);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Reviewer,UserReview,MovieID,MovieTitle")] Review review)
        {
            if (id != review.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(review);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ReviewExists(review.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction($"Details{"/" + review.MovieID}", "Movies");
            }
            ViewData["thisMovieID"] = review.MovieID;
            ViewData["thisMovieTitle"] = review.MovieTitle;
            return View(review);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var review = await _context.Review
                .FirstOrDefaultAsync(m => m.ID == id);
            if (review == null)
            {
                return NotFound();
            }

            return View(review);
        }

   
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var review = await _context.Review.FindAsync(id);
            _context.Review.Remove(review);
            await _context.SaveChangesAsync();
            return RedirectToAction($"Details{"/" + review.MovieID}", "Movies");
        }

        private bool ReviewExists(int id)
        {
            return _context.Review.Any(e => e.ID == id);
        }
    }
}