using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Biblioteca.Data;
using Biblioteca.Models;

namespace Biblioteca.Pages_Utilizadores
{
    public class DetailsModel : PageModel
    {
        private readonly Biblioteca.Data.BibliotecaContext _context;

        public DetailsModel(Biblioteca.Data.BibliotecaContext context)
        {
            _context = context;
        }

        public Utilizador Utilizador { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var utilizador = await _context.Utilizador.FirstOrDefaultAsync(m => m.UserID == id);

            if (utilizador is not null)
            {
                Utilizador = utilizador;

                return Page();
            }

            return NotFound();
        }
    }
}
