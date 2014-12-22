// ***********************************************************************
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
    /// The ISubscriber interface.
    /// </summary>
    public interface ISubscriber : ICredentials
    {
        /// <summary>
        /// Gets or sets a value indicating whether this instance is remembered at next log on.
        /// </summary>
        /// <value><c>true</c> if this instance is remembered at next log on; otherwise, <c>false</c>.</value>
        bool IsRememberedAtNextLogOn { get; set; }
    }
}