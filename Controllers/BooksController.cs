using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VjezbaZaIspit.Data;
using VjezbaZaIspit.Models.Dbo;
using VjezbaZaIspit.Service;

namespace VjezbaZaIspit.Controllers
{
    [Authorize]
    public class BooksController : Controller
    {
        private readonly ApplicationDbContext context;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly IBookService bookService;
        public BooksController(ApplicationDbContext context, UserManager<ApplicationUser> userManager, IBookService bookService)
        {
            this.context = context;
            this.userManager = userManager;
            this.bookService = bookService;
        }

        // GET: Books
        public async Task<IActionResult> Index()
        {
            return context.Book != null ?
                        View(await context.Book.ToListAsync()) :
                        Problem("Entity set 'ApplicationDbContext.Book'  is null.");
        }

        // GET: Books/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || context.Book == null)
            {
                return NotFound();
            }

            var book = await context.Book
                .FirstOrDefaultAsync(m => m.Id == id);
            if (book == null)
            {
                return NotFound();
            }

            return View(book);
        }

        // GET: Books/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Books/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Created,Title")] Book book)
        {
            //if (ModelState.IsValid)
            //{

            //  var user = await  userManager.GetUserAsync(User);

            //    book.ApplicationUser = user;

            //    context.Add(book);
            //    await context.SaveChangesAsync();
            //    return RedirectToAction(nameof(Index));
            //}
            //return View(book);


            //var user = await userManager.GetUserAsync(User);
            //book.Author = await context.Author.FirstAsync();
            //book.ApplicationUser = user;
            //book.Publisher = await context.Publisher.FirstAsync();

            //context.Add(book);
            //await context.SaveChangesAsync();
            //return RedirectToAction(nameof(Index));

            await bookService.Add(book.Title, await userManager.GetUserAsync(User));
            return RedirectToAction(nameof(Index));


        }

        // GET: Books/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || context.Book == null)
            {
                return NotFound();
            }

            var book = await context.Book.FindAsync(id);
            if (book == null)
            {
                return NotFound();
            }
            return View(book);
        }

        // POST: Books/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Created,Title")] Book book)
        {
            context.Update(book);
            await context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        // GET: Books/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || context.Book == null)
            {
                return NotFound();
            }

            var book = await context.Book
                .FirstOrDefaultAsync(m => m.Id == id);
            if (book == null)
            {
                return NotFound();
            }

            return View(book);
        }

        // POST: Books/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (context.Book == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Book'  is null.");
            }
            var book = await context.Book.FindAsync(id);
            if (book != null)
            {
                context.Book.Remove(book);
            }

            await context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BookExists(int id)
        {
            return (context.Book?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
