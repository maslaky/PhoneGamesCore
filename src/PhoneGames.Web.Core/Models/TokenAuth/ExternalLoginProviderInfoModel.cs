﻿using Abp.AutoMapper;
using PhoneGames.Authentication.External;

namespace PhoneGames.Models.TokenAuth
{
    [AutoMapFrom(typeof(ExternalLoginProviderInfo))]
    public class ExternalLoginProviderInfoModel
    {
        public string Name { get; set; }

        public string ClientId { get; set; }
    }
}
