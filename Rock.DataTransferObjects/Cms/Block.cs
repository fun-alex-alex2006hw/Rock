//
// THIS WORK IS LICENSED UNDER A CREATIVE COMMONS ATTRIBUTION-NONCOMMERCIAL-
// SHAREALIKE 3.0 UNPORTED LICENSE:
// http://creativecommons.org/licenses/by-nc-sa/3.0/
//
using System;

namespace Rock.CMS.DTO
{
    /// <summary>
    /// Block Data Transfer Object.
    /// </summary>
	/// <remarks>
	/// Data Transfer Objects are a lightweight version of the Entity object that are used
	/// in situations like serializing the object in the REST api
	/// </remarks>
    public partial class Block : Rock.DTO<Block>
    {
		/// <summary>
		/// Gets or sets the System.
		/// </summary>
		/// <value>
		/// System.
		/// </value>
		public bool IsSystem { get; set; }

		/// <summary>
		/// Gets or sets the Path.
		/// </summary>
		/// <value>
		/// Path.
		/// </value>
		public string Path { get; set; }

		/// <summary>
		/// Gets or sets the Name.
		/// </summary>
		/// <value>
		/// Name.
		/// </value>
		public string Name { get; set; }

		/// <summary>
		/// Gets or sets the Description.
		/// </summary>
		/// <value>
		/// Description.
		/// </value>
		public string Description { get; set; }
	}
}
