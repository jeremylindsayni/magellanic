// ***********************************************************************
// Assembly         : Magellanic.Interfaces.Domain
// Author           : Jeremy Lindsay
// Created          : 21-Dec-2014
//
// Last Modified By : Jeremy Lindsay
// Last Modified On : 21-Dec-2014
// ***********************************************************************
/// <summary>
/// The Security namespace.
/// </summary>
namespace Magellanic.Interfaces.Domain.Security
{
    using Magellanic.Enumerations.Domain.Users;

    /// <summary>
    /// The IPerson interface.
    /// </summary>
    public interface IPerson
    {
        /// <summary>
        /// Gets or sets the first name.
        /// </summary>
        /// <value>The first name.</value>
        string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the other forenames.
        /// </summary>
        /// <value>The other forenames.</value>
        string OtherForenames { get; set; }

        /// <summary>
        /// Gets or sets the last name.
        /// </summary>
        /// <value>The last name.</value>
        string LastName { get; set; }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>The title.</value>
        string Title { get; set; }

        /// <summary>
        /// Gets or sets the name preferred by user.
        /// </summary>
        /// <value>The name preferred by user.</value>
        string NamePreferredByUser { get; set; }

        /// <summary>
        /// Gets or sets the gender.
        /// </summary>
        /// <value>The gender.</value>
        Gender Gender { get; set; }
    }
}
