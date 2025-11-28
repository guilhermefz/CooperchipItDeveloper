using Cooperchip.ITDeveloper.CrossCutting.Extensions;
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
    public class AspNetUser : IUserInContext
    {
        private readonly IHttpContextAccessor _accessor;

        public AspNetUser(IHttpContextAccessor accessor)
        {
            _accessor = accessor;
        }

        public string Name => _accessor.HttpContext.User.Identity.Name;

        public Guid GetUserId() { return IsAuthenticated() ? Guid.Parse(_accessor.HttpContext.User.GetUserId()) : Guid.Empty; }

        public IEnumerable<Claim> GetClaimsIdentity() { return _accessor.HttpContext.User.Claims; }

        public string GetUserApelido() { return IsAuthenticated() ? _accessor.HttpContext.User.GetUserApelido() : string.Empty; }

        public string GetUserDataNascimento() { return IsAuthenticated() ? _accessor.HttpContext.User.GetUserDataNascimento() : string.Empty; }

        public string GetUserEmail() { return IsAuthenticated() ? _accessor.HttpContext.User.GetUserEmail() : string.Empty; }

        public string GetUserImgProfilePath() { return IsAuthenticated() ? _accessor.HttpContext.User.GetUserImgProfilePath() : string.Empty; }

        public string GetUserNomeCompleto() { return IsAuthenticated() ? _accessor.HttpContext.User.GetUserNomeCompleto() : string.Empty; }


        public bool IsAuthenticated() { return _accessor.HttpContext.User.Identity.IsAuthenticated; }

        public bool IsInRole(string role) { return _accessor.HttpContext.User.IsInRole(role); }
    }
}
