using Authentication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Authentication.Controllers
{
    public class SecurityController : ApiController
    {
        //[HttpGet]
        //public bool Register(string emailAddress, string password)
        //{
        //    using (var context = new AuthenticationEntities())
        //    {
        //        var user = (from x in context.Users
        //                    where x.EmailAddress == emailAddress
        //                    select x).FirstOrDefault();
        //        if (user != null)
        //        {
        //            throw new Exception("A user With This Email Address Already Exists");
        //        }

        //        var newuser = new User();
        //        newuser.EmailAddress = emailAddress;
        //        newuser.Password = password;
        //        context.Users.Add(newuser);
        //        context.SaveChanges();
        //        return true;
        //    }
        //}


        [HttpGet]
        public bool Login(string emailAddress, string password)
        {
            using (var context = new AuthenticationEntities())
            {
                var user = (from x in context.Users
                            where x.EmailAddress == emailAddress &&
                                x.Password == password
                            select x).FirstOrDefault();
                if (user == null)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }
    }
}
