﻿using System;
//using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using PersonalFinanceManager.Models;

using PersonalFinanceManager.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;

namespace PersonalFinanceManager.Data
{
	public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        //options includes information to conncet to our database
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}

