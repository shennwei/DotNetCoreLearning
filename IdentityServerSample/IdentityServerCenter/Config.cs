﻿using IdentityServer4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityServerCenter
{
    public class Config
    {
        public static IEnumerable<ApiResource> GetResource()
        {
            return new List<ApiResource> {
                new ApiResource("api","My Api")
            };
        }

        public static IEnumerable<Client> GetClient()
        {
            return new List<Client>
            {
                new Client(){
                    ClientId="Client",
                    AllowedGrantTypes= GrantTypes.ClientCredentials,
                    ClientSecrets={new Secret("secret".Sha256()) },
                    AllowedScopes={"api"}
                }
            };
        }
    }
}
