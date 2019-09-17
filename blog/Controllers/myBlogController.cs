using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using blog.Models;

namespace blog.Controllers
{
    public class myBlogController : Controller
    {
        private readonly DatabaseContext _context;

        public myBlogController(DatabaseContext context)
        {
            _context = context;
        }

        // GET: myBlog
        public async Task<IActionResult> Index()
        {
            return View(await _context.myBlogs.ToListAsync());
        }

        // GET: myBlog/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var myBlog = await _context.myBlogs
                .FirstOrDefaultAsync(m => m.blogId == id);
            if (myBlog == null)
            {
                return NotFound();
            }

            return View(myBlog);
        }

        // GET: myBlog/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: myBlog/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("blogId,blogTitle,imagePath,blogDescription,blogDateTime,isPublished")] myBlog myBlog)
        {
            if (ModelState.IsValid)
            {
                _context.Add(myBlog);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(myBlog);
        }

        // GET: myBlog/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var myBlog = await _context.myBlogs.FindAsync(id);
            if (myBlog == null)
            {
                return NotFound();
            }
            return View(myBlog);
        }

        // POST: myBlog/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("blogId,blogTitle,imagePath,blogDescription,blogDateTime,isPublished")] myBlog myBlog)
        {
            if (id != myBlog.blogId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(myBlog);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!myBlogExists(myBlog.blogId))
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
            return View(myBlog);
        }

        // GET: myBlog/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var myBlog = await _context.myBlogs
                .FirstOrDefaultAsync(m => m.blogId == id);
            if (myBlog == null)
            {
                return NotFound();
            }

            return View(myBlog);
        }

        // POST: myBlog/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var myBlog = await _context.myBlogs.FindAsync(id);
            _context.myBlogs.Remove(myBlog);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool myBlogExists(int id)
        {
            return _context.myBlogs.Any(e => e.blogId == id);
        }
    }
}
