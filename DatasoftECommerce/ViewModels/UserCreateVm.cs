﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatasoftECommerceApi.ViewModels
{
    public class UserCreateVm
    {
        public string Email { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public string RePassword { get; set; }
    }
}
