using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FirstLook.Models
{
    public class MailingList
    {

        /* same as
         * 
         * public Mailing(string first, string last, string email) {
         *  FirstName = first;
         * }
         * 
         * Data classes typically dont have constructers but they can have them
         * 
         */

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
    }
}