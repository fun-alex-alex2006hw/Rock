//
// THIS WORK IS LICENSED UNDER A CREATIVE COMMONS ATTRIBUTION-NONCOMMERCIAL-
// SHAREALIKE 3.0 UNPORTED LICENSE:
// http://creativecommons.org/licenses/by-nc-sa/3.0/
//
using System;

namespace Rock.Util.DTO
{
    /// <summary>
    /// Job Data Transfer Object.
    /// </summary>
	/// <remarks>
	/// Data Transfer Objects are a lightweight version of the Entity object that are used
	/// in situations like serializing the object in the REST api
	/// </remarks>
    public partial class Job : Rock.DTO<Job>
    {
		/// <summary>
		/// Gets or sets the System.
		/// </summary>
		/// <value>
		/// System.
		/// </value>
		public bool IsSystem { get; set; }

		/// <summary>
		/// Gets or sets the Active.
		/// </summary>
		/// <value>
		/// Active.
		/// </value>
		public bool? IsActive { get; set; }

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

		/// <summary>
		/// Gets or sets the Assemby.
		/// </summary>
		/// <value>
		/// Assemby.
		/// </value>
		public string Assemby { get; set; }

		/// <summary>
		/// Gets or sets the Class.
		/// </summary>
		/// <value>
		/// Class.
		/// </value>
		public string Class { get; set; }

		/// <summary>
		/// Gets or sets the Cron Expression.
		/// </summary>
		/// <value>
		/// Cron Expression.
		/// </value>
		public string CronExpression { get; set; }

		/// <summary>
		/// Gets or sets the Last Successful Run.
		/// </summary>
		/// <value>
		/// Last Successful Run.
		/// </value>
		public DateTime? LastSuccessfulRun { get; set; }

		/// <summary>
		/// Gets or sets the Last Run Date.
		/// </summary>
		/// <value>
		/// Last Run Date.
		/// </value>
		public DateTime? LastRunDate { get; set; }

		/// <summary>
		/// Gets or sets the Last Run Duration.
		/// </summary>
		/// <value>
		/// Last Run Duration.
		/// </value>
		public int? LastRunDuration { get; set; }

		/// <summary>
		/// Gets or sets the Last Status.
		/// </summary>
		/// <value>
		/// Last Status.
		/// </value>
		public string LastStatus { get; set; }

		/// <summary>
		/// Gets or sets the Last Status Message.
		/// </summary>
		/// <value>
		/// Last Status Message.
		/// </value>
		public string LastStatusMessage { get; set; }

		/// <summary>
		/// Gets or sets the Last Run Scheduler Name.
		/// </summary>
		/// <value>
		/// Last Run Scheduler Name.
		/// </value>
		public string LastRunSchedulerName { get; set; }

		/// <summary>
		/// Gets or sets the Notification Emails.
		/// </summary>
		/// <value>
		/// Notification Emails.
		/// </value>
		public string NotificationEmails { get; set; }

        /// <summary>
        /// Gets or sets the Notification Status.
        /// </summary>
        /// <value>
        /// Notification Status.
        /// </value>
        public int NotificationStatus { get; set; }
    }
}
