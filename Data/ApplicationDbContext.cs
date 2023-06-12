using System;
//using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using PersonalFinanceManager.Models;


namespace PersonalFinanceManager.Data
{
	public class ApplicationDbContext : IdentityDbContext
    {
        //options includes information to conncet to our database
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
        {

        }

        public DbSet<User> User { get; set; }
    }
}

