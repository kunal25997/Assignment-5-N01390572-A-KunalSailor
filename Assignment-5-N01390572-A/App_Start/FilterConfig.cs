using System.Web;
using System.Web.Mvc;

namespace Assignment_5_N01390572_A
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
