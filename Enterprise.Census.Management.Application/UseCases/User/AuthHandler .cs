using AutoMapper;
using Enterprise.Census.Management.Application.DTOs.Requests;
using Enterprise.Census.Management.Application.DTOs.Requests.User;
using Enterprise.Census.Management.Application.DTOs.Responses;
using Enterprise.Census.Management.Domain.Entities;
using Enterprise.Census.Management.Domain.Interfaces;
using MediatR;

namespace Enterprise.Census.Management.Application.UseCases;
public class AuthHandler : IRequestHandler<CreateUserRequest, CreateUserResponse>,
                            IRequestHandler<SendLoginRequest, LoginResponse>,
                            IRequestHandler<ChangePasswordRequest, bool>,
                            IRequestHandler<PasswordResetRequest, bool>,
                            IRequestHandler<SendResetPasswordRequest, bool>
{
    private readonly IAuthRepository _authRepository;
    private readonly IMapper _mapper;
    private readonly IUnitOfWork _unitOfWork;

    public AuthHandler(IAuthRepository authRepository, IMapper mapper, IUnitOfWork unitOfWork)
    {
        _mapper = mapper;
        _unitOfWork = unitOfWork;
        _authRepository = authRepository;
    }

    public async Task<CreateUserResponse> Handle(CreateUserRequest request, CancellationToken cancellationToken)
    {
        var mapedeUser = _mapper.Map<User>(request);
        var result = await _authRepository.CreateUserAsync(mapedeUser.Username, mapedeUser.PhoneNumber);
        await _unitOfWork.Commit(cancellationToken);
        return _mapper.Map<CreateUserResponse>(result);
    }

    public async Task<LoginResponse> Handle(SendLoginRequest request, CancellationToken cancellationToken)
    {
        var user = await _authRepository.ValidateUserAsync(request.Username, request.Password);

        if (user == null)
        {
            return new LoginResponse
            {
                Message = "Usuário não encontrado.",
                IsTemporaryPassword = false
            };
        }
        if (user.IsTemporaryPassword)
        {
            return new LoginResponse
            { 
                Message = "Deves alterar sua senha antes de logar!",
                IsTemporaryPassword = user.IsTemporaryPassword,
            };
        }
        var token = await _authRepository.GenerateJwtTokenAsync(request.Username, request.Password);

        return new LoginResponse
        {
            Id = user.Id,
            Token = token,
            Username = user.Username,
            IsTemporaryPassword = user.IsTemporaryPassword,
            Message = user.IsTemporaryPassword ? "A sua senha é temporária. Por favor, atualize-a." : "Login bem-sucedido."
        };
    }

    public async Task<bool> Handle(ChangePasswordRequest request, CancellationToken cancellationToken)
    {
        return await _authRepository.ChangePasswordAsync(request.username, request.oldPassword, request.newPassword);
    }

    public async Task<bool> Handle(SendResetPasswordRequest request, CancellationToken cancellationToken)
    {
        return await _authRepository.ResetPasswordAsync(request.token, request.newPassword);
    }

    public async Task<bool> Handle(PasswordResetRequest request, CancellationToken cancellationToken)
    {
        return await _authRepository.RequestPasswordResetAsync(request.username);
    }
}
    

