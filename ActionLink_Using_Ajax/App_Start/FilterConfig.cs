﻿using System.Web;
using System.Web.Mvc;

namespace ActionLink_Using_Ajax
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
