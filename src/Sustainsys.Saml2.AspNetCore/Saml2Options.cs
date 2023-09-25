﻿using Microsoft.AspNetCore.Authentication;

namespace Sustainsys.Saml2.AspNetCore;

/// <summary>
/// Saml2 authentication options
/// </summary>
public class Saml2Options : RemoteAuthenticationOptions
{
    /// <summary>
    /// Ctor
    /// </summary>
    public Saml2Options()
    {
        CallbackPath = "/Saml2/Acs";
    }
}