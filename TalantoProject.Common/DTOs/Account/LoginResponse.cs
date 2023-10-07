using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalantoProject.Common.DTOs.Account
{
    public  class LoginResponse
    {
        public bool Success { get; set; }
        public string? ErrorMessage { get; set; }

    }
}
