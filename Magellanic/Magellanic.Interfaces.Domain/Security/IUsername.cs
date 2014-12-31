// ***********************************************************************
// Assembly         : Magellanic.Interfaces.Domain
// Author           : Jeremy Lindsay
// Created          : 22-Dec-2014
//
// Last Modified By : Jeremy Lindsay
// Last Modified On : 22-Dec-2014
// ***********************************************************************
/// <summary>
/// The Security namespace.
/// </summary>
namespace Magellanic.Interfaces.Domain.Security
{
    /// <summary>
    /// The IUserName interface.
    /// </summary>
    public interface IUserName
    {
        /// <summary>
        /// Gets or sets the name of the user.
        /// </summary>
        /// <value>The name of the user.</value>
        string UserName { get; set; }
    }
}
