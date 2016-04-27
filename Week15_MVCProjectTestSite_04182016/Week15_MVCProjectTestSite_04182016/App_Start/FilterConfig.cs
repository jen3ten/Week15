using System.Web;
using System.Web.Mvc;

namespace Week15_MVCProjectTestSite_04182016
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
