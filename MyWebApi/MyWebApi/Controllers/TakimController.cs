using MyWebApi.Models;
using MyWebApi.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MyWebApi.Controllers
{
    public class TakimController : ApiController
    {

        Model veritabani = new Model();

        [HttpGet]
        public HttpResponseMessage Detay(int takim_id)
        {
            TakimDetay detay = new TakimDetay(takim_id);
            if (detay == null)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, "boyle bir takim bulunamadi");
            }
            return Request.CreateResponse(HttpStatusCode.OK,detay);
        }
        


    }
}
