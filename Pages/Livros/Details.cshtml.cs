using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Biblioteca.Data;
using Biblioteca.Models;

namespace Biblioteca.Pages_Livros
{
    public class DetailsModel : PageModel
    {
        private readonly BibliotecaContext _context;

        public DetailsModel(BibliotecaContext context)
        {
            _context = context;
        }

        public Livro Livro { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var livro = await _context.Livro
                .Include(l => l.Utilizador)
                .FirstOrDefaultAsync(m => m.LivroID == id);

            if (livro is not null)
            {
                Livro = livro;

                return Page();
            }

            return NotFound();
        }
    }
}
