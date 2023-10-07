using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalantoProject.Common.DTOs.Account
{
    public class LoginRequest
    {
        public string? UserName { get; set; }
        public string? Password { get; set; }

    }
}
