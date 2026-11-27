Biblioteca Isla

App Web em ASP.NET Core Razor Pages - Contexto Académico 

Funcionalidades: gestão de utilizadores e livros (CRUD), autenticação e páginas protegidas
Tecnologias: .NET (C#), Razor Pages, Entity Framework Core, SQLite, ASP.NET Core Identity, Bootstrap

------------------------------------

Instalar (1 vez por máquina)
.NET SDK (versão 8 ou superior)
Visual Studio Code com a extensão, C# Dev Kit (opcionais: .NET Install Tool, SQLite Viewer, NuGet Gallery, Git Extension Pack)
dotnet tool install --global dotnet-ef

------------------------------------

Descomprimir ficheiro ZIP, Abrir pasta Biblioteca no VS Code

------------------------------------

Correr o projeto
dotnet dev-certs https --trust   # só na 1.ª vez: confiar no certificado HTTPS local (aceita o aviso)
dotnet restore                   # descarrega as dependências (NuGet)
dotnet run                       # compila e arranca a aplicação

------------------------------------

Funcionalidades Iniciais
Registo com email e password segura (minimo 6 caracteres, uma maiúscula, minuscula, número e um caracter especial)
Login
Em Utilizadores e Livros já existem dados de exemplo listados e com página de detalhes. Com login, é possível criar, editar e eliminar esses dados.  
Nos detalhes do Utilizador é possível ver os livros por ele levantados
Na lista de Utilizadores é possível ordenar por ordem alfabetica.
Para criar novos dados, o id do Utilizador corresponde ao NIF e o contacto espera 9 digitos a iniciar por 9.

------------------------------------

dotnet build - compila e mostra erros
dotnet watch - hot reload
dotnet run - executa App

dotnet clean - limpar ficheiros compilados
dotnet restore - restaurar dependências

dotnet ef migrations add NomeDaMigracao - criar nova após criação/alteração de modelo
dotnet ef database update - executa a anterior
dotnet ef migrations remove - remove a anterior

Para recriar a base de dados do zero: apagar Biblioteca.db e dotnet run
Para ver o conteudo da base de dados extensao VSCode SQLite Viewer
Biblioteca.db está no .gitignore

------------------------

git status - ver mudanças
git add . - adicionar alterações
git commit -m "Breve Descrição" - gravar alterações
pit push - enviar para repo