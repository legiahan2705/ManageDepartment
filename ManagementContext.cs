﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;



    public class ManagementContext : DbContext
    {
    public ManagementContext() : base("ManagementConnectionString") { }
    public DbSet<Department> Departments { get; set; }
    public DbSet<Employee> Employees { get; set; }

}

