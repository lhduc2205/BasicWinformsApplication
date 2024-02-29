using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinformsBasic.Common.Enums;

namespace WinformsBasic.Models.Entities
{
    public class Role
    {
        public int Id { get; set; }
        public RoleType Name { get; set; } = RoleType.User;
    }
}
