﻿using HotelListing.WEB_API.Models.Users;
using Microsoft.AspNetCore.Identity;

namespace HotelListing.WEB_API.Contracts
{
    public interface IAuthManager
    {
        Task<IEnumerable<IdentityError>> Register(ApiUserDto userDto);
        Task<bool> Login(LoginDto loginDto);
    }
}
