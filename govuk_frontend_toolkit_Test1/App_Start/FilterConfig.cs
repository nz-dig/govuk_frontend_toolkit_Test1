using System.Web;
using System.Web.Mvc;

namespace govuk_frontend_toolkit_Test1
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}