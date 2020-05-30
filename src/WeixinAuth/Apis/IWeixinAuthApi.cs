﻿using Microsoft.AspNetCore.Authentication.OAuth;
using Newtonsoft.Json.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Myvas.AspNetCore.Authentication.WeixinAuth.Internal
{
    public interface IWeixinAuthApi
    {
        Task<OAuthTokenResponse> GetToken(HttpClient backchannel, string tokenEndpoint, string appId, string appSecret, string code, CancellationToken cancellationToken);
        Task<JObject> GetUserInfo(HttpClient backchannel, string userInformationEndpoint, string accessToken, string openid, CancellationToken cancellationToken, WeixinAuthLanguageCodes languageCode = WeixinAuthLanguageCodes.zh_CN);
    }
}