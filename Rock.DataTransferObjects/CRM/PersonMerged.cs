//
// THIS WORK IS LICENSED UNDER A CREATIVE COMMONS ATTRIBUTION-NONCOMMERCIAL-
// SHAREALIKE 3.0 UNPORTED LICENSE:
// http://creativecommons.org/licenses/by-nc-sa/3.0/
//
using System;

namespace Rock.CRM.DTO
{
    /// <summary>
    /// Person Trail Data Transfer Object.
    /// </summary>
	/// <remarks>
	/// Data Transfer Objects are a lightweight version of the Entity object that are used
	/// in situations like serializing the object in the REST api
	/// </remarks>
    public partial class PersonMerged : Rock.DTO<PersonMerged>
    {
		/// <summary>
		/// Gets or sets the Current Id.
		/// </summary>
		/// <value>
		/// Current Id.
		/// </value>
		public int CurrentId { get; set; }

		/// <summary>
		/// Gets or sets the Current Guid.
		/// </summary>
		/// <value>
		/// Current Guid.
		/// </value>
		public Guid CurrentGuid { get; set; }
	}
}
