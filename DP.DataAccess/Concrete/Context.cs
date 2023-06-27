﻿using DP.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.DataAccess.Concrete
{
	public class Context : DbContext
	{
		public Context(DbContextOptions<Context> options) : base(options)
		{

		}
		public DbSet<Customer> Customers { get; set; }
		public DbSet<Process> Processes { get; set; }
	}
}
