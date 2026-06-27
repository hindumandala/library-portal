using Microsoft.AspNetCore.Mvc;
using LibraryPortal.Data;
using LibraryPortal.Models;
using System.Linq;
using Microsoft.AspNetCore.Authorization;


namespace LibraryPortal.Controllers;
[Authorize] 
public class BooksController : Controller
{
    private readonly LibraryContext _context;

    public BooksController(LibraryContext context)
    {
        _context = context;
    }

    // GET: /Books
    public IActionResult Index(string search)
{
    var books = _context.Books.ToList();
    
    if(!string.IsNullOrEmpty(search))
    {
        books = books.Where(b => b.Title.Contains(search, 
               StringComparison.OrdinalIgnoreCase)).ToList();
    }
    
    ViewData["search"] = search;
    return View(books);
}
    // GET: /Books/Create (show empty form)
public IActionResult Create()
{
    return View();
}

// POST: /Books/Create (save form data)
[HttpPost]
public IActionResult Create(Book book)
{
    if(ModelState.IsValid)
    {
        _context.Books.Add(book);
        _context.SaveChanges();
        return RedirectToAction("Index");
    }
    return View(book);
}
// GET: /Books/Edit/1
public IActionResult Edit(int id)
{
    var book = _context.Books.Find(id);
    return View(book);
}

// POST: /Books/Edit/1
[HttpPost]
public IActionResult Edit(Book book)
{
    if(ModelState.IsValid)
    {
        _context.Books.Update(book);
        _context.SaveChanges();
        return RedirectToAction("Index");
    }
    return View(book);
}

// GET: /Books/Delete/1
public IActionResult Delete(int id)
{
    var book = _context.Books.Find(id);
    _context.Books.Remove(book);
    _context.SaveChanges();
    return RedirectToAction("Index");
}
}