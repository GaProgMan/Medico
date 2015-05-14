using System;
using System.Collections.Generic;

namespace Winchester
{
    /// <summary>
    /// The User Details class
    /// </summary>
    public class UserDetails
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Winchester.UserDetails"/> class.
        /// </summary>
        public UserDetails()
        {
            UserId = string.Empty;
            FullUserName = string.Empty;
            Medications = new List<Medication>();
            IsNull = true;
        }

        /// <summary>
        /// Gets or sets a value indicating the user identifier.
        /// </summary>
        /// <value>The user identifier.</value>
        public string UserId
        {
            get;
            set;
        }
            
        /// <summary>
        /// Gets or sets a value indicating the full name of the user.
        /// </summary>
        /// <value>The full name of the user.</value>
        public string FullUserName
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the list of user medications.
        /// </summary>
        /// <value>The medications.</value>
        public List<Medication> Medications
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is null.
        /// </summary>
        /// <value><c>true</c> if this instance is null; otherwise, <c>false</c>.</value>
        public bool IsNull
        {
            get;
            set;
        }
    }
}

