﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecart_Web
{
    public static class WC
    {
        public const string ImagePath = @"\images\product\";
        public const string SessionCart = "ShoppingCartSession";

        public const string AdminRole = "Admin";
        public const string ManagerRole = "Manager";

        // combine the roles of admins and managers
        public const string AdminOrManager = AdminRole + "," + ManagerRole;

        public const string CustomerRole = "Customer";

        public const string EmailAdmin = "katlehomokhethi1@proton.me";
    }
}
