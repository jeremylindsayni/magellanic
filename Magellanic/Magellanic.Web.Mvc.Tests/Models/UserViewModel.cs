// ***********************************************************************
// Assembly         : Magellanic.Web.MvcTests
// Author           : Jeremy Lindsay
// Created          : 07-Jan-2015
//
// Last Modified By : Jeremy Lindsay
// Last Modified On : 11-Jan-2015
// ***********************************************************************
/// <summary>
/// The Models namespace. This is used for test purposes only.
/// </summary>
namespace SampleApplication.Models
{
    using System.Collections.Generic;

    /// <summary>
    /// The UserViewModel class.
    /// </summary>
    public class UserViewModel
    {
        public UserViewModel(IList<User> userNames)
        {
            this.UserNames = userNames;
        }

        /// <summary>
        /// Gets or sets the user identifier.
        /// </summary>
        /// <value>The user identifier.</value>
        public string UserId { get; set; }

        /// <summary>
        /// Gets or sets the user names.
        /// </summary>
        /// <value>The user names.</value>
        public IList<User> UserNames { get; private set; }
    }
}