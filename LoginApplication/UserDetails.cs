﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginApplication
{
    class UserDetails
    {
        public string Admin
        { get; set; }

        public string AdminPassword
        { get; set; }

        public string User
        { get; set; }

        public string UserPassword
        { get; set; }

        /// <summary>
        /// constructor
        /// </summary>
        public UserDetails()
        {
            Admin = "admin";
            AdminPassword = "42";
            User = "user";
            UserPassword = "666";
        }
    }
}
