using System;
using System.Collections.Generic;
using System.Text;
using VisualBusinessCards.Dtos.Users;

namespace VisualBusinessCards.Services.Interface
{
    public interface IUserServices
    {
        void Register(RegisterUsersDto registerUserDto);
        string Login(LoginDtos loginDto);
    }
}
