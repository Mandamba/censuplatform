using Enterprise.Census.Management.Application.DTOs.Requests;
using Enterprise.Census.Management.Application.DTOs.Requests.User;
using MediatR;
using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;

namespace FUTTURE.MANAGEMENT.REPORT.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AuthController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] CreateUserRequest request)
        {
            var command = new CreateUserRequest(request.userName, request.phoneNumber);
            var result = await _mediator.Send(command);

            if (result != null)
            {
                return Ok(new { Message = "Usuário criado com sucesso." });
            }

            return BadRequest(new { Message = "Usuário já existe." });
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] SendLoginRequest request)
        {
            var command = new SendLoginRequest(request.Username, request.Password);
            var result = await _mediator.Send(command);

            if (result.Id == 0 && !result.IsTemporaryPassword)
            {
                return Unauthorized();
            }
            return Ok(result);
        }

        [HttpPost("change-password")]
        public async Task<IActionResult> ChangePassword([FromBody] ChangePasswordRequest request)
        {
            var command = new ChangePasswordRequest(request.username, request.oldPassword, request.newPassword);
            var result = await _mediator.Send(command);

            if (result)
            {
                return Ok(new { Message = "Senha alterada com sucesso." });
            }

            return BadRequest(new { Message = "Falha ao alterar senha." });
        }

        [HttpPost("reset-password-request")]
        public async Task<IActionResult> RequestPasswordReset([FromBody] PasswordResetRequest request)
        {
            var command = new PasswordResetRequest(request.username);
            var result = await _mediator.Send(command);

            if (result)
            {
                return Ok(new { Message = "Token de redefinição de senha enviado." });
            }

            return BadRequest(new { Message = "Usuário não encontrado." });
        }

        [HttpPost("reset-password")]
        public async Task<IActionResult> ResetPassword([FromBody] SendResetPasswordRequest request)
        {
            var command = new SendResetPasswordRequest(request.token, request.newPassword);
            var result = await _mediator.Send(command);

            if (result)
            {
                return Ok(new { Message = "Senha redefinida com sucesso." });
            }

            return BadRequest(new { Message = "Token inválido ou expirado." });
        }
    }
}
