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
            return Ok(result);
        }

        [HttpPost("register")]
        [DisplayName("Register")]
        public async Task<IActionResult> Register([FromBody] ApplicationUserInputModel model)
        {
            var result = await authenticationService.RegisterAsync(model);
            return Ok(result);

        }

        [HttpPost("forgot-password")]
        [DisplayName("Forgot Password")]
        public async Task<IActionResult> ForgotPassword([FromBody] ApplicationUserInputModel model)
        {
            var result = await authenticationService.ForgotPasswordAsync(model);
            return Ok(result);
        }

        [HttpPost("reset-password")]
        [DisplayName("Reset Password")]
        public async Task<IActionResult> ResetPassword([FromBody] ApplicationUserInputModel model)
        {
            var result = await authenticationService.ResetPasswordAsync(model);
            return Ok(result);
        }

        [HttpPost("change-password")]
        [DisplayName("Change Password")]
        public async Task<IActionResult> ChangePassword([FromBody] ApplicationUserInputModel model)
        {
            var result = await authenticationService.ChangePasswordAsync(model);
            return Ok(result);
        }

        [HttpPost("refresh-token")]
        [DisplayName("Refresh Token")]
        public async Task<IActionResult> RefreshToken([FromBody] ApplicationUserInputModel model)
        {
            var result = await authenticationService.RefreshTokenAsync(model);
            return Ok(result);
        }
    }
}
