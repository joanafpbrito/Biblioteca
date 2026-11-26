using System;
using Biblioteca.Models;

namespace Biblioteca.Data;

public static class SeedData
{
     public static void Initialize(BibliotecaContext context)
    {
        if (context.Utilizador.Any()) return;

        context.Utilizador.AddRange(
            new Utilizador { UserID = 694623598, Nome = "João Matias",     Tel = "916790229" },
            new Utilizador { UserID = 812345602, Nome = "Maria Fernandes", Tel = "923456789" },
            new Utilizador { UserID = 923456712, Nome = "Pedro Santos",    Tel = "911234567" },
            new Utilizador { UserID = 734567823, Nome = "Ana Ribeiro",     Tel = "934567890" },
            new Utilizador { UserID = 845678933, Nome = "Rui Carvalho",    Tel = "913456123" },
            new Utilizador { UserID = 956789045, Nome = "Sofia Almeida",   Tel = "926789012" }
        );
        context.SaveChanges();

        context.Livro.AddRange(
            new Livro { Titulo = "Aprender a programar numa semana", Autor = "Allen B. Downey", DataLancamento = new DateTime(2024, 12, 3),  UserID = 694623598 },
            new Livro { Titulo = "Escrever uma dissertação", Autor = "Umberto Eco", DataLancamento = new DateTime(2020, 3, 12), UserID = 812345602 },
            new Livro { Titulo = "Como tirar 20 nos exames", Autor = "Barbara Oakley", DataLancamento = new DateTime(2001, 11, 11), UserID = 694623598 },
            new Livro { Titulo = "Bases de Dados para Todos", Autor = "Abraham Silberschatz",  DataLancamento = new DateTime(2018, 5, 20),  UserID = 923456712 },
            new Livro { Titulo = "C# na Prática", Autor = "Jon Skeet", DataLancamento = new DateTime(2022, 9, 1), UserID = 734567823 },
            new Livro { Titulo = "Algoritmos e Estruturas de Dados", Autor = "Robert Sedgewick", DataLancamento = new DateTime(2015, 2, 17), UserID = 845678933 },
            new Livro { Titulo = "Redes de Computadores", Autor = "Andrew S. Tanenbaum", DataLancamento = new DateTime(2019, 10, 5), UserID = 956789045 },
            new Livro { Titulo = "O Principezinho", Autor = "Antoine de Saint-Exupéry", DataLancamento = new DateTime(2021, 6, 30), UserID = null },
            new Livro { Titulo = "A Rapariga no Comboio", Autor = "Paula Hawkins", DataLancamento = new DateTime(2015, 1, 13), UserID = null },
            new Livro { Titulo = "A Sombra do Vento", Autor = "Carlos Ruiz Zafón", DataLancamento = new DateTime(2001, 4, 17), UserID = null },
            new Livro { Titulo = "1984", Autor = "George Orwell", DataLancamento = new DateTime(1949, 6, 8), UserID = null },
            new Livro { Titulo = "O Hobbit", Autor = "J. R. R. Tolkien", DataLancamento = new DateTime(1937, 9, 21), UserID = null },
            new Livro { Titulo = "Orgulho e Preconceito", Autor = "Jane Austen", DataLancamento = new DateTime(1813, 1, 28), UserID = null },
            new Livro { Titulo = "Duna", Autor = "Frank Herbert", DataLancamento = new DateTime(1965, 8, 1), UserID = null },
            new Livro { Titulo = "O Alquimista", Autor = "Paulo Coelho", DataLancamento = new DateTime(1988, 1, 1), UserID = null }
);
        context.SaveChanges();
    }
}
