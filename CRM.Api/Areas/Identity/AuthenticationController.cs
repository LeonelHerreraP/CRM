using CRM.Model.InputModels;
using CRM.Service.IService;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;

namespace CRM.Api.Areas.Identity
{
    [Area("Identity")]
    [DisplayName("Authentication Controller")]
    [Route("api/[area]/[controller]")]
    [ApiController]
    public class AuthenticationController(IAuthenticationService authenticationService) : ControllerBase
    {

        [HttpPost("login")]
        [DisplayName("Login")]
        public async Task<IActionResult> Login([FromBody] ApplicationUserInputModel model)
        {
            var result = await authenticationService.LoginAsync(model);
            return result ? Ok(result) : StatusCode(500);
        }

        [HttpPost("register")]
        [DisplayName("Register")]
        public async Task<IActionResult> Register([FromBody] ApplicationUserInputModel model)
        {
            var result = await authenticationService.RegisterAsync(model);
            return result ? Ok(result) : StatusCode(500);

        }

        [HttpPost("forgot-password")]
        [DisplayName("Forgot Password")]
        public async Task<IActionResult> ForgotPassword([FromBody] ApplicationUserInputModel model)
        {
            var result = await authenticationService.ForgotPasswordAsync(model);
            return result ? Ok(result) : StatusCode(500);
        }

        [HttpPost("reset-password")]
        [DisplayName("Reset Password")]
        public async Task<IActionResult> ResetPassword([FromBody] ApplicationUserInputModel model)
        {
            var result = await authenticationService.ResetPasswordAsync(model);
            return result ? Ok(result) : StatusCode(500);
        }

        [HttpPost("change-password")]
        [DisplayName("Change Password")]
        public async Task<IActionResult> ChangePassword([FromBody] ApplicationUserInputModel model)
        {
            var result = await authenticationService.ChangePasswordAsync(model);
            return result ? Ok(result) : StatusCode(500);
        }

        [HttpPost("refresh-token")]
        [DisplayName("Refresh Token")]
        public async Task<IActionResult> RefreshToken([FromBody] ApplicationUserInputModel model)
        {
            var result = await authenticationService.RefreshTokenAsync(model);
            return result ? Ok(result) : StatusCode(500);
        }
    }
}
