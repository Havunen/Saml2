﻿using Microsoft.AspNetCore.Http;

namespace Sustainsys.Saml2.Bindings;

/// <summary>
/// A SAML2 Binding that operates on the front channel, i.e. browser.
/// </summary>
public abstract class FrontChannelBinding
{
    /// <summary>
    /// The Uri identifying the binding
    /// </summary>
    public abstract string Identification { get; }

    /// <summary>
    /// Binds a Saml2 message to the http response.
    /// </summary>
    /// <param name="message">Saml2 message</param>
    /// <param name="httpResponse">Http response to bind message to</param>
    /// <returns>Task</returns>
    /// <exception cref="System.ArgumentException">If message properties not properly set</exception>
    public Task Bind(HttpResponse httpResponse, Saml2Message message)
    {
        if (string.IsNullOrWhiteSpace(message.Name))
        {
            throw new ArgumentException("Name property must have value", nameof(message));
        }

        if(message.Xml == null)
        {
            throw new ArgumentException("Xml property must have value", nameof(message));
        }

        return DoBind(httpResponse, message);
    }

    /// <summary>
    /// Binds a Saml2 message to the http response.
    /// </summary>
    /// <param name="message">Saml2 message</param>
    /// <param name="httpResponse">Http response to bind message to</param>
    /// <returns>Task</returns>
    protected abstract Task DoBind(HttpResponse httpResponse, Saml2Message message);
}