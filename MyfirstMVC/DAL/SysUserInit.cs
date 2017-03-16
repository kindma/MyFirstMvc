using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using MyfirstMVC.Models;

namespace MyfirstMVC.DAL
{
    public class SysUserInit : DropCreateDatabaseIfModelChanges<AccountContext>
    {
        protected override void Seed(AccountContext context)
        {
            var initUsers = new List<SysUser>
            {
                new SysUser{ UserName="admin",  PassWord="admin",Email="admin@qq.com"},
                new SysUser{ UserName="admin2", PassWord="admin2", Email="admin2@qq.com"}
            };

            var initRoles = new List<SysRole>
            {
                new SysRole{ RoleName="admin", RoleDesc="it is admin"},
                new SysRole{ RoleName="super", RoleDesc="it is super"}
            };

            initUsers.ForEach(s => context.SysUsers.Add(s));
            initRoles.ForEach(s => context.SysRoles.Add(s));
            context.SaveChanges();
        }
    }
}