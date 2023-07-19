using System;
using Microsoft.EntityFrameworkCore;
namespace TestApi.Models
{
	public class UserContext:DbContext
	{
		public UserContext(DbContextOptions<UserContext> options)
			:base(options)
		{
		}

        //protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlite(@"Data Source =/Users/borahaliloglu/Projects/TestApi/TestApi/Database/Project1.db");
        public DbSet<User> Users { get; set; }
	}
}

