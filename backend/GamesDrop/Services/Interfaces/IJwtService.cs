using System;
using GamesDrop.Dtos;

namespace GamesDrop.Services.Interfaces
{
    public interface IJwtService
    {
        string GetNewAccessToken(UserDto user, Guid accessTokenJti);
    }
}