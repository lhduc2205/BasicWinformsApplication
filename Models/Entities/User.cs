using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinformsBasic.Models.Entities
{
    public class User
    {
        public int Id {  get; set; }
        public string Username { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string? FirstName {  get; set; }
        public string? LastName { get; set; }
        public Role Role { get; set; } = null!;
    }
}
