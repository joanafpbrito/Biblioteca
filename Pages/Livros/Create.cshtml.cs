using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Biblioteca.Data;
using Biblioteca.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Biblioteca.Pages_Livros
{
    public class CreateModel : PageModel
    {
        private readonly BibliotecaContext _context;

        public CreateModel(BibliotecaContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            Livro = new Livro{UserID = null};
            return Page();
        }

        [BindProperty]
        public Livro Livro { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Livro.Add(Livro);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
