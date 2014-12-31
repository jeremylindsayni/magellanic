// ***********************************************************************
// Assembly         : Magellanic.Interfaces.Domain
// Author           : Jeremy Lindsay
// Created          : 31-Dec-2014
//
// Last Modified By : Jeremy Lindsay
// Last Modified On : 31-Dec-2014
// ***********************************************************************
/// <summary>
/// The Domain namespace.
/// </summary>
namespace Magellanic.Interfaces.Domain
{
    /// <summary>
    /// The IFoundationId interface.
    /// </summary>
    public interface IFoundationId
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        long Id { get; set; }
    }
}
