using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Biblioteca.Data;
using Biblioteca.Models;

namespace Biblioteca.Pages_Livros
{
    public class CreateModel : PageModel
    {
        private readonly Biblioteca.Data.BibliotecaContext _context;

        public CreateModel(Biblioteca.Data.BibliotecaContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
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
