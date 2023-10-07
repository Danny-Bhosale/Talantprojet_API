using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalantoProject.Common.DTOs.Account;
using TalantoProject.Common.Repositories;
using TalantoProject.Common.Services;

namespace TalantoProject.Services
{
    public class AccountService: IAccountServices
    {
        public readonly IAccountRepositories _accountRepositories;

        public AccountService(IAccountRepositories accountRepositories)
        {
            _accountRepositories = accountRepositories;
        }
       public async Task<LoginResponse> VerifyLoginDetails(LoginRequest request)
        {
            LoginResponse response = new LoginResponse();
            try
            {
              var dbUser = await _accountRepositories.GetLoginDetails(request.UserName!, request.Password!);
                if (dbUser == null)
                {
                    response.Success = false;
                    response.ErrorMessage = "Invalid Credentials";
                }
                else
                {
                    response.Success = true;
                }
                return response;

            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
