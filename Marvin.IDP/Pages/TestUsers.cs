// Copyright (c) Duende Software. All rights reserved.
// See LICENSE in the project root for license information.


using IdentityModel;
using System.Security.Claims;
using System.Text.Json;
using Duende.IdentityServer;
using Duende.IdentityServer.Test;

namespace Marvin.IDP;

public class TestUsers
{
    public static List<TestUser> Users
    {
        get
        {    
            return new List<TestUser>
            {
                new TestUser
                {
                    SubjectId = "af5a3f13-8456-41df-b62d-fc47f6f658c9",
                    Username = "David",
                    Password = "password",
                    Claims =
                    {
                        new Claim(JwtClaimTypes.GivenName, "David"),
                        new Claim(JwtClaimTypes.FamilyName, "Flagg"),
                    }
                },
                new TestUser
                {
                    SubjectId = "d4b87803-301c-4d29-bbf3-966dab74a877",
                    Username = "Emma",
                    Password = "password",
                    Claims =
                    {
                        new Claim(JwtClaimTypes.GivenName, "Emma"),
                        new Claim(JwtClaimTypes.FamilyName, "Flagg"),
                    }
                }
            };
        }
    }
}