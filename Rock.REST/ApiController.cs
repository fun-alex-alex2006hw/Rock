﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net.Http;
using System.Web.Http;

using Rock.Data;

namespace Rock.Rest
{
    public abstract class ApiController<T, D>  : ApiController where T : Rock.Data.Model<T>
    {
        // GET api/<controller>
        public IQueryable<Rock.CMS.DTO.Page> Get()
        {
            return new Service<T>().q PageService().QueryableDTO();
        }

        // GET api/<controller>/5
        public Rock.CMS.DTO.Page Get( int id )
        {
            var service = new PageService();
            Page page;
            if ( !service.TryGet( id, out page ) )
                throw new HttpResponseException( HttpStatusCode.NotFound );
            return page.DataTransferObject;
        }

        // POST api/<controller>
        public HttpResponseMessage Post( [FromBody]Rock.CMS.DTO.Page value )
        {
            if ( !ModelState.IsValid )
            {
            }
            using ( var uow = new UnitOfWorkScope() )
            {
                var service = new PageService();
                var page = new Page();
                service.Add( page, null );

                uow.objectContext.Entry( page ).CurrentValues.SetValues( value );

                if ( !page.IsValid )
                    throw new HttpResponseException( HttpStatusCode.BadRequest );

                service.Save( page, null );

                var response = ControllerContext.Request.CreateResponse( HttpStatusCode.Created );
                response.Headers.Location = new Uri( Request.RequestUri, "/api/pages/" + page.Id.ToString() );
                return response;

            }
        }

        // PUT api/<controller>/5
        public void Put( int id, [FromBody]Rock.CMS.DTO.Page value )
        {
            using ( var uow = new UnitOfWorkScope() )
            {
                var service = new PageService();
                Page page;
                if ( !service.TryGet( id, out page ) )
                    throw new HttpResponseException( HttpStatusCode.NotFound );

                uow.objectContext.Entry( page ).CurrentValues.SetValues( value );

                if ( page.IsValid )
                    service.Save( page, null );
                else
                    throw new HttpResponseException( HttpStatusCode.BadRequest );
            }
        }

        // DELETE api/<controller>/5
        public void Delete( int id )
        {
            var service = new PageService();
            Page page;
            if ( !service.TryGet( id, out page ) )
                throw new HttpResponseException( HttpStatusCode.NotFound );

            service.Delete( page, null );
            service.Save( page, null );
        }
    }
}
