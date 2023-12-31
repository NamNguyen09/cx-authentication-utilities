﻿using System.Threading.Tasks;
using cx.Authentication.Utilities.Dtos;
using Microsoft.Owin.Security.Notifications;

namespace cx.Authentication.Services
{
    public partial interface IOidcClientService
    {
        Task<string> GetAccessTokenByCodeAsync(string code, string feideOidcTokenUrl, LoginProvider loginProvider);      
        Task<string> GetUserInfo(string token, string userInfoUrl);
        Task<string> GetPersonalUserInfo(string token, string feideOidcUrl);
        Task<string> GetGroupInfo(string token, string groupApiUrl);
        Task SetAuthentication(AuthorizationCodeReceivedNotification context, LoginProvider ils);
    }
}
