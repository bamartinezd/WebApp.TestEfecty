﻿using System.Web;
using System.Web.Mvc;

namespace WebApp.TestEfecty.BackEnd
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
