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
    public class IndexModel : PageModel
    {
        private readonly BibliotecaContext _context;

        public IndexModel(BibliotecaContext context)
        {
            _context = context;
        }

        public IList<Livro> Livro { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Livro = await _context.Livro
                .Include(l => l.Utilizador)
                .ToListAsync();
        }
    }
}
