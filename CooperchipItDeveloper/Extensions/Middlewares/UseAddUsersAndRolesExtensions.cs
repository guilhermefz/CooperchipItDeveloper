namespace CooperchipItDeveloper.Mvc.Extensions.Middlewares
{
    public static class UseAddUsersAndRolesExtensions
    {
        public static IApplicationBuilder UseAddUserAndRoles(this IApplicationBuilder app)
        {
            return app.UseMiddleware<DefaultUsersAndRolesMiddleware>();
        }
    }
}
