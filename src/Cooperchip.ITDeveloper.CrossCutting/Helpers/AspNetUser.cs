using CooperchipItDeveloper.Domain.Interfaces;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Cooperchip.ITDeveloper.CrossCutting.Helpers
{
    public class AspNetUser : IUserInContext<Guid>
    {
        private readonly IHttpContextAccessor _accessor;

        public AspNetUser(IHttpContextAccessor accessor)
        {
            _accessor = accessor;
        }

        public string Name => _accessor.HttpContext.User.Identity.Name;

        public Guid GetUserId()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Claim> GetClaimsIdentity()
        {
            throw new NotImplementedException();
        }

        public string GetUserApelido()
        {
            throw new NotImplementedException();
        }

        public string GetUserDataNascimento()
        {
            throw new NotImplementedException();
        }

        public string GetUserEmail()
        {
            throw new NotImplementedException();
        }

        public string GetUserImgProfilePath()
        {
            throw new NotImplementedException();
        }

        public string GetUserNomeCompleto()
        {
            throw new NotImplementedException();
        }

        public bool IsAuthenticated()
        {
            return true;
        }

        public bool IsInRole(string role)
        {
            throw new NotImplementedException();
        }
    }
}
