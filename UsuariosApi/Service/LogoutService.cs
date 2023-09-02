using FluentResults;
using Microsoft.AspNetCore.Identity;
using System;

namespace UsuariosApi.Service
{
    public class LogoutService
    {
        private SignInManager<IdentityUser<int>> _signInManager;

        public LogoutService(SignInManager<IdentityUser<int>> signInManager)
        {
            _signInManager = signInManager;
        }

        public Result DeslogaUsuario()
        {
            var resultadoIdentity = _signInManager.SignOutAsync();
            if (resultadoIdentity.IsCompleted)
            {
                return Result.Ok();
            }
            return Result.Fail("Logout falhou!");
        }
    }
}
