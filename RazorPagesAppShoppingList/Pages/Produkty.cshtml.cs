using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesShoppingList.Models;

namespace RazorPagesShoppingList.Pages
{
    public class ProduktyModel : PageModel
    {
        private readonly MyDbContext _context;

        public List<Products> Produkty { get; set; } = new List<Products>();    

        [BindProperty]

        public Products NewProducts { get; set; }

        public ProduktyModel(MyDbContext context)
        {
            _context = context;
        }
        public void OnGet()
        {
            Produkty = _context.Produkty.ToList();  
        }

        public IActionResult OnPost()
        {
            _context.Produkty.Add(NewProducts);
            _context.SaveChanges(); 
            return RedirectToPage();
        }
    }
}
