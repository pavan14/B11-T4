﻿using System.Web;
using System.Web.Mvc;

namespace Filter_CustomHandleError
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
