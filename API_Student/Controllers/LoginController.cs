using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using API_Student.DAL;
using API_Student.Models;
using Newtonsoft.Json;

namespace API_Student.Controllers
{
    public class LoginController : ApiController
    {
        MyLogin dal = new MyLogin();
        [HttpGet]
        public IHttpActionResult GetList(string name,string pwd)
        {
            return Json( dal.GetLogin(name, pwd));          
        }
    }
}
