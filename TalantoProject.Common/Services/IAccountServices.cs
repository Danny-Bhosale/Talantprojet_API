using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalantoProject.Common.DTOs.Account;

namespace TalantoProject.Common.Services
{
    public interface IAccountServices
    {
       Task<LoginResponse> VerifyLoginDetails(LoginRequest request);
    }
}
