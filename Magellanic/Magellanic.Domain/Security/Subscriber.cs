// ***********************************************************************
// Assembly         : Magellanic.Domain
// Author           : Jeremy Lindsay
// Created          : 22-Dec-2014
//
// Last Modified By : Jeremy Lindsay
// Last Modified On : 22-Dec-2014
// ***********************************************************************
/// <summary>
/// The Security namespace.
/// </summary>
namespace Magellanic.Domain.Security
{
    using Magellanic.Interfaces.Domain.Security;

    /// <summary>
    /// The Subscriber class.
    /// </summary>
    public class Subscriber : Credentials, ISubscriber
    {
        /// <summary>
        /// Gets or sets a value indicating whether this instance is remembered at next log on.
        /// </summary>
        /// <value><c>true</c> if this instance is remembered at next log on; otherwise, <c>false</c>.</value>
        public bool IsRememberedAtNextLogOn { get; set; }
    }
}
