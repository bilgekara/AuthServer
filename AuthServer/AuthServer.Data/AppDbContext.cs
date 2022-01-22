using System;
using AuthServer.Core.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AuthServer.Data
{
    public class AppDbContext : IdentityDbContext<UserApp, IdentityRole, string>
	{
		// DbContextOptions -> startupda doldurucam, base ctor'a göndericem
		public AppDbContext(DbContextOptions<AppDbContext> options : base(options)
		{
		}

        // Product, r. token -> üyelik sistemiyle alakasız iki dbset daha var
        public DbSet<Product> Products { get; set; }

        public DbSet<UserRefreshToken> UserRefreshTokens { get; set; }

        // configure -> vt oluşurken bu tabloların özellikleri nasıl olacak

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}

