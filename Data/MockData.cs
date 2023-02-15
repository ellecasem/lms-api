﻿using LmsApi.Models;

namespace LmsApi.Data
{
    public static class MockData
    {
        public static void Initializer(LmsContext context)
        {
            context.Database.EnsureCreated();

            if (context.Roles.Any())
            {
                return;   // Role has been populated
            }

            var roles = new Role[]
            {
                new Role { Id = 1, RoleName = "Admin"},
                new Role { Id = 2, RoleName = "Librarian" },
                new Role { Id = 3, RoleName = "Borrower" }
            }; 

            context.Roles.AddRange(roles);

            var users = new User[]
            {
                new User { Id = 1, FirstName = "Addy" , LastName = "Andromeda", Email = "addy@test.com", RoleId = 1 },
                new User { Id = 2, FirstName = "Libby", LastName = "Brook", Email = "libbt@test.com", RoleId = 2 },
                new User { Id = 3, FirstName = "Warren", LastName = "Reed", Email = "warren@test.com", RoleId = 3 },
                new User { Id = 4, FirstName = "Minchin", LastName = "Lin", Email = "minch@test.com", RoleId = 3 }
            };

            context.Users.AddRange(users);

            var books = new Book[]
            {
                new Book { Id = 1, Name = "REST API Design Rulebook" , Author = "Mark Masse", Genre = "Computer Science", Quantity = 1, ShelfLocation = LmsApi.Models.ShelfLocation.Loc1 },
                new Book { Id = 2, Name = "API Design Patterns", Author = "JJ Geewax", Genre = "Computer Science", Quantity = 2, ShelfLocation = LmsApi.Models.ShelfLocation.Loc2 },
                new Book { Id = 3, Name = "APIs: A Strategy Guide", Author = "Brail-Jacobson-Woods", Genre = "Computer Science", Quantity = 3, ShelfLocation = LmsApi.Models.ShelfLocation.Loc3 },
                new Book { Id = 4, Name = "RESTful Java Web Services", Author = "Jobinesh Purushothaman", Genre = "Computer Science", Quantity = 3, ShelfLocation = LmsApi.Models.ShelfLocation.Loc1 }
            };

            context.Books.AddRange(books);

            var histories = new History[]
            {
                new History { Id = 1, BookId = 1, BorrowerId = 1, BorrowDate = DateTime.Now, ReturnDate = DateTime.Now.AddDays(1), ActualReturnDate = null }
            };

            context.Histories.AddRange(histories);

            context.SaveChanges();
        }
    }
}
