using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Security.Claims;

namespace WeDriversMVC.Web.Filters
{
    public class CheckPermissons : Attribute, IAuthorizationFilter
    {
        private readonly string _permisson;
        public CheckPermissons(string permisson)
        {
            _permisson = permisson;
        }
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            bool isAuthorized = CheckUserPermissons(context.HttpContext.User, _permisson);

            if (!isAuthorized)
            {
                context.Result = new UnauthorizedResult();
            }
        }

        private bool CheckUserPermissons(ClaimsPrincipal user, string permisson)
        {
            return permisson == "Read";
        }
    }
}
