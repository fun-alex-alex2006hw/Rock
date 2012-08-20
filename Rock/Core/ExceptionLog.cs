//
// THIS WORK IS LICENSED UNDER A CREATIVE COMMONS ATTRIBUTION-NONCOMMERCIAL-
// SHAREALIKE 3.0 UNPORTED LICENSE:
// http://creativecommons.org/licenses/by-nc-sa/3.0/
//
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Runtime.Serialization;

using Rock.Data;

namespace Rock.Core
{
    /// <summary>
    /// Exception Log POCO Entity.
    /// </summary>
    [Table( "coreExceptionLog" )]
    public partial class ExceptionLog : ModelWithAttributes<ExceptionLog>
    {
		/// <summary>
		/// Gets or sets the Parent Id.
		/// </summary>
		/// <value>
		/// Parent Id of the exeption, used for linking inner exceptions..
		/// </value>
		[DataMember]
		public int? ParentId { get; set; }
		
		/// <summary>
		/// Gets or sets the Site Id.
		/// </summary>
		/// <value>
		/// Site Id that the exception occurred on..
		/// </value>
		[DataMember]
		public int? SiteId { get; set; }
		
		/// <summary>
		/// Gets or sets the Page Id.
		/// </summary>
		/// <value>
		/// Page Id that the exception occurred on..
		/// </value>
		[DataMember]
		public int? PageId { get; set; }
		
		/// <summary>
		/// Gets or sets the Exception Date.
		/// </summary>
		/// <value>
		/// Date / time that the exception occurred..
		/// </value>
		[Required]
		[DataMember]
		public DateTime ExceptionDate { get; set; }
		
		/// <summary>
		/// Gets or sets the Has Inner Exception.
		/// </summary>
		/// <value>
		/// Whether the exception has an inner exception..
		/// </value>
		[DataMember]
		public bool? HasInnerException { get; set; }
		
		/// <summary>
		/// Gets or sets the Person Id.
		/// </summary>
		/// <value>
		/// Person Id of the logged in person who experienced the exception..
		/// </value>
		[DataMember]
		public int? PersonId { get; set; }
		
		/// <summary>
		/// Gets or sets the Status Code.
		/// </summary>
		/// <value>
		/// Status code that would have been thrown (404, 500, etc).
		/// </value>
		[MaxLength( 10 )]
		[DataMember]
		public string StatusCode { get; set; }
		
		/// <summary>
		/// Gets or sets the Exception Type.
		/// </summary>
		/// <value>
		/// Name of the exception.
		/// </value>
		[MaxLength( 150 )]
		[DataMember]
		public string ExceptionType { get; set; }
		
		/// <summary>
		/// Gets or sets the Description.
		/// </summary>
		/// <value>
		/// The exception message..
		/// </value>
		[DataMember]
		public string Description { get; set; }
		
		/// <summary>
		/// Gets or sets the Source.
		/// </summary>
		/// <value>
		/// What assembly the exception occurred in..
		/// </value>
		[MaxLength( 50 )]
		[DataMember]
		public string Source { get; set; }
		
		/// <summary>
		/// Gets or sets the Stack Trace.
		/// </summary>
		/// <value>
		/// The stack trace that was produced..
		/// </value>
		[DataMember]
		public string StackTrace { get; set; }
		
		/// <summary>
		/// Gets or sets the Page Url.
		/// </summary>
		/// <value>
		/// The URL of the page that generated the exception..
		/// </value>
		[MaxLength( 250 )]
		[DataMember]
		public string PageUrl { get; set; }
		
		/// <summary>
		/// Gets or sets the Server Variables.
		/// </summary>
		/// <value>
		/// Server variables at the time of the exception..
		/// </value>
		[DataMember]
		public string ServerVariables { get; set; }
		
		/// <summary>
		/// Gets or sets the Query String.
		/// </summary>
		/// <value>
		/// Full query string..
		/// </value>
		[DataMember]
		public string QueryString { get; set; }
		
		/// <summary>
		/// Gets or sets the Form.
		/// </summary>
		/// <value>
		/// Form items at the time of the exception..
		/// </value>
		[DataMember]
		public string Form { get; set; }
		
		/// <summary>
		/// Gets or sets the Cookies.
		/// </summary>
		/// <value>
		/// Cookies at the time of the exception..
		/// </value>
		[DataMember]
		public string Cookies { get; set; }
		
		/// <summary>
        /// Gets a Data Transfer Object (lightweight) version of this object.
        /// </summary>
        /// <value>
        /// A <see cref="Rock.Core.DTO.ExceptionLog"/> object.
        /// </value>
		public Rock.Core.DTO.ExceptionLog DataTransferObject
		{
			get 
			{ 
				Rock.Core.DTO.ExceptionLog dto = new Rock.Core.DTO.ExceptionLog();
				dto.Id = this.Id;
				dto.Guid = this.Guid;
				dto.ParentId = this.ParentId;
				dto.SiteId = this.SiteId;
				dto.PageId = this.PageId;
				dto.ExceptionDate = this.ExceptionDate;
				dto.HasInnerException = this.HasInnerException;
				dto.PersonId = this.PersonId;
				dto.StatusCode = this.StatusCode;
				dto.ExceptionType = this.ExceptionType;
				dto.Description = this.Description;
				dto.Source = this.Source;
				dto.StackTrace = this.StackTrace;
				dto.PageUrl = this.PageUrl;
				dto.ServerVariables = this.ServerVariables;
				dto.QueryString = this.QueryString;
				dto.Form = this.Form;
				dto.Cookies = this.Cookies;
				return dto; 
			}
		}

        /// <summary>
        /// Gets the auth entity.
        /// </summary>
		[NotMapped]
		public override string AuthEntity { get { return "Core.ExceptionLog"; } }
        
		/// <summary>
        /// Gets or sets the Person.
        /// </summary>
        /// <value>
        /// A <see cref="CRM.Person"/> object.
        /// </value>
		public virtual CRM.Person Person { get; set; }

    }
    /// <summary>
    /// Exception Log Configuration class.
    /// </summary>
    public partial class ExceptionLogConfiguration : EntityTypeConfiguration<ExceptionLog>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExceptionLogConfiguration"/> class.
        /// </summary>
        public ExceptionLogConfiguration()
        {
			this.HasOptional( p => p.Person ).WithMany().HasForeignKey( p => p.PersonId ).WillCascadeOnDelete(false);
		}
    }
}
