﻿using Microsoft.Extensions.Configuration;

namespace CCCA16_NETv2.AccountApp.Test
{
    public class FakeConfigurationBuilder
    {
        public static IConfigurationRoot Do()
        {
            var myConfiguration = new Dictionary<string, string>
            {
                { "ConnectionStrings:db", "Server=localhost;Database=postgres;User Id=postgres;Password=123456;" },
            };
            return new ConfigurationBuilder()
                .AddInMemoryCollection(myConfiguration)
                .Build();
        }
    }
}
