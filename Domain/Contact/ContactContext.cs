using Microsoft.EntityFrameworkCore;

namespace Domain.Contact
{
    public class ContactContext : DbContext
    {
        public DbSet<Contact> Contacts { get; set; }

        public ContactContext(DbContextOptions<ContactContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contact>().HasData(
                new Contact
                {
                    Id = 1,
                    FirstName = "Иаан",
                    LastName = "Иванов",
                    PhoneNumber = "8 (747) 45-45-456",
                    Address = "Ул. Пушкина",
                    Description = "Норм чувак"
                },

                new Contact
                {
                    Id = 2,
                    FirstName = "Сергей",
                    LastName = "Сергеев",
                    PhoneNumber = "8 (747) 35-35-356",
                    Address = "Ул. Калатушкина",
                    Description = "Серёга для братьев"
                });
        }
    }
}
