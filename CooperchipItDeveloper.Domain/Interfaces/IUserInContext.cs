using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace CooperchipItDeveloper.Domain.Interfaces
{
    public interface IUserInContext<TKey>
    {
        string Name { get; }
        Guid GetUserId();
        string GetUserEmail();
        bool IsAuthenticated();
        bool IsInRole(string role);
        IEnumerable<Claim> GetClaimsIdentity();
        string GetUserApelido();
        string GetUserNomeCompleto();
        string GetUserDataNascimento();
        string GetUserImgProfilePath();
    }
}
