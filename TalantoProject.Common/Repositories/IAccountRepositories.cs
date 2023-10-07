using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalantoProject.Common.Entities;

namespace TalantoProject.Common.Repositories
{
    public interface IAccountRepositories
    {
        Task<LoginDetails> GetLoginDetails(string username, string password);
    }
}
