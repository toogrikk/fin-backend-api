namespace fin_backend_api.Services;

using fin_backend_api.Data;
using fin_backend_api.Models;
using Microsoft.EntityFrameworkCore;



public class CategoryService
{
    private readonly ApplicationDbContext _context;

    public CategoryService(ApplicationDbContext context)
    {
        _context = context;
    }

    public Category Create(Category category)
    {
        _context.Categories.Add(category);
        _context.SaveChanges();
        return category;
    }

    public List<Category> GetAll()
    {
        return _context.Categories.ToList();
    }
}
