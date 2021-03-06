﻿// ***********************************************************************
// Assembly         : Magellanic.Interfaces.Domain
// Author           : Jeremy Lindsay
// Created          : 12-21-2014
//
// Last Modified By : Jeremy Lindsay
// Last Modified On : 12-21-2014
// ***********************************************************************
/// <summary>
/// The Security namespace.
/// </summary>
namespace Magellanic.Interfaces.Domain.Security
{
    /// <summary>
    /// The ICredentials interface.
    /// </summary>
    public interface ICredentials : IUserName
    {
        /// <summary>
        /// Gets or sets the password.
        /// </summary>
        /// <value>The password.</value>
        string Password { get; set; }
    }
}
