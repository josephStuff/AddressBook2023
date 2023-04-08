using System;
using AddressBook2023.Models;
using Microsoft.EntityFrameworkCore;


namespace AddressBook2023.Data
{
    public class ApplicationDbContext : DbContext
    {
        
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :
            base(options)
        {
            
        }
            public DbSet<Contact> Contacts { get; set; }


    }
}
