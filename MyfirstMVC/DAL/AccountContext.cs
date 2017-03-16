using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using MyfirstMVC.Models;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace MyfirstMVC.DAL
{
    public class AccountContext: DbContext
    {
        public AccountContext() : base("SysUserDbConectionString") { }

        public DbSet<SysUser> SysUsers { get; set; }
        public DbSet<SysRole> SysRoles { get; set; }

        public DbSet<SysUserRole> SysUserRoles { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}