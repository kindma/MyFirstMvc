﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyfirstMVC.Models
{
    public class SysUser
    {
        public int ID { set; get; }
        public string UserName { get; set; }
        public string PassWord { get; set; }
        public string Email { get; set; }
        public ICollection<SysUserRole> SysUserRoles { get; set; }
    }
}