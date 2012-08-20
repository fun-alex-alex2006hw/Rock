//
// THIS WORK IS LICENSED UNDER A CREATIVE COMMONS ATTRIBUTION-NONCOMMERCIAL-
// SHAREALIKE 3.0 UNPORTED LICENSE:
// http://creativecommons.org/licenses/by-nc-sa/3.0/
//
using System;

namespace Rock.CMS.DTO
{
    /// <summary>
    /// Block Instance Data Transfer Object.
    /// </summary>
	/// <remarks>
	/// Data Transfer Objects are a lightweight version of the Entity object that are used
	/// in situations like serializing the object in the REST api
	/// </remarks>
    public partial class BlockInstance : Rock.DTO<BlockInstance>
    {
		/// <summary>
		/// Gets or sets the System.
		/// </summary>
		/// <value>
		/// System.
		/// </value>
		public bool IsSystem { get; set; }

		/// <summary>
		/// Gets or sets the Page Id.
		/// </summary>
		/// <value>
		/// Page Id.
		/// </value>
		public int? PageId { get; set; }

		/// <summary>
		/// Gets or sets the Layout.
		/// </summary>
		/// <value>
		/// Layout.
		/// </value>
		public string Layout { get; set; }

		/// <summary>
		/// Gets or sets the Block Id.
		/// </summary>
		/// <value>
		/// Block Id.
		/// </value>
		public int BlockId { get; set; }

		/// <summary>
		/// Gets or sets the Zone.
		/// </summary>
		/// <value>
		/// Zone.
		/// </value>
		public string Zone { get; set; }

		/// <summary>
		/// Gets or sets the Order.
		/// </summary>
		/// <value>
		/// Order.
		/// </value>
		public int Order { get; set; }

		/// <summary>
		/// Gets or sets the Name.
		/// </summary>
		/// <value>
		/// Name.
		/// </value>
		public string Name { get; set; }

		/// <summary>
		/// Gets or sets the Output Cache Duration.
		/// </summary>
		/// <value>
		/// Output Cache Duration.
		/// </value>
		public int OutputCacheDuration { get; set; }
	}
}
