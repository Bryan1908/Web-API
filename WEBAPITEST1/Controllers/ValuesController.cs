using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.Http;
using WEBAPITEST1.Models;

namespace WEBAPITEST1.Controllers
{
    public class ValuesController : ApiController
    {
        static string storedData;

        // GET api/values
        public string Get()
        {
            return storedData;
        }

        public string Post(string data)
        {
            storedData = data;
            return "OK";

        }

        public void Put(int id, [FromBody]string value)
        {

        }

        public string Delete()
        {
            storedData = "";
            return "OK";
        }

    }
}
