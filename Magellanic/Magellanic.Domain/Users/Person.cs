// ***********************************************************************
// Assembly         : Magellanic.Domain
// Author           : Jeremy Lindsay
// Created          : 22-Dec-2014
//
// Last Modified By : Jeremy Lindsay
// Last Modified On : 22-Dec-2014
// ***********************************************************************
/// <summary>
/// The Users namespace.
/// </summary>
namespace Magellanic.Domain.Users
{
    using Magellanic.Enumerations.Domain.Users;
    using Magellanic.Interfaces.Domain.Security;

    /// <summary>
    /// The Person class.
    /// </summary>
    public class Person : IPerson, IFoundationId
    {
        /// <summary>
        /// Gets or sets the first name.
        /// </summary>
        /// <value>The first name.</value>
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the other forenames.
        /// </summary>
        /// <value>The other forenames.</value>
        public string OtherForenames { get; set; }

        /// <summary>
        /// Gets or sets the last name.
        /// </summary>
        /// <value>The last name.</value>
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>The title.</value>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the name preferred by user.
        /// </summary>
        /// <value>The name preferred by user.</value>
        public string NamePreferredByUser { get; set; }

        /// <summary>
        /// Gets or sets the gender.
        /// </summary>
        /// <value>The gender.</value>
        public Gender Gender { get; set; }

        /// <summary>
        /// Gets or sets the username.
        /// </summary>
        /// <value>The username.</value>
        public string UserName { get; set; }

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        public long Id { get; set; }
    }
}
